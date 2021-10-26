
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using System.Management;
using System.Linq;
using System;

namespace windowswebgsm.Data
{
    public static class DiagnosticHelpers
    {
        public static float SystemCPU { get; private set; }
        public static string SystemCPUName { get;private set; }
        public static double SystemRAMPerc { get; private set; }
        public static double SystemAvailableRAM { get; private set; }
        public static double SystemMaxRAM { get; private set; }
        private static readonly object locker = new object();
        

        static DiagnosticHelpers()
        {
            
            SystemCPU = 0;
            SystemMaxRAM = 0;
            Task.Run(() =>
            {
                var cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total", true);
                var wmiObject = new ManagementObjectSearcher("select * from Win32_OperatingSystem");
                var wmiObject2 = new ManagementObjectSearcher("select * from Win32_ComputerSystem");
                var wmiCpuObject = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_Processor");
                while (true)
                {
                    Thread.Sleep(1000);
                    lock (locker)
                    {
                        SystemCPU = cpuCounter.NextValue();

                        var memoryValues = wmiObject.Get().Cast<ManagementObject>().Select(mo => new {
                            FreePhysicalMemory = Double.Parse(mo["FreePhysicalMemory"].ToString()),
                            TotalVisibleMemorySize = Double.Parse(mo["TotalVisibleMemorySize"].ToString()),
                        }).FirstOrDefault();

                        var memoryValues2 = wmiObject2.Get().Cast<ManagementObject>().Select(mo => new
                        {
                            TotalPhysicalMemory = Double.Parse(mo["TotalPhysicalMemory"].ToString())
                        }).FirstOrDefault();

                        var cpu_values = wmiCpuObject.Get().Cast<ManagementObject>().Select(mo => new
                        {
                            CPUName = mo["Name"].ToString()
                        }).FirstOrDefault();

                        SystemCPUName = cpu_values.CPUName;
                        SystemAvailableRAM = memoryValues.FreePhysicalMemory;
                        SystemMaxRAM = Math.Round(memoryValues2.TotalPhysicalMemory / (1024 * 1024 * 1024), 2);

                        if (memoryValues != null)
                        {
                            SystemRAMPerc = ((memoryValues.TotalVisibleMemorySize - memoryValues.FreePhysicalMemory) / memoryValues.TotalVisibleMemorySize) * 100;
                        }
                    }
                }
            });
        }
    }
}
