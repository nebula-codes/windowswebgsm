using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace windowswebgsm.Data.Models
{
    public class Server
    {
        public enum ServerStatus
        {
            Started = 0,
            Starting = 1,
            Stopped = 2,
            Stopping = 3,
            Restarted = 4,
            Restarting = 5,
            Updated = 6,
            Updating = 7,
            Backuped = 8,
            Backuping = 9,
            Restored = 10,
            Restoring = 11,
            Deleting = 12
        }


        public string SteamID { get; set; }
        public string ID { get; set; }
        public string Name { get; set; }
        public int Port { get; set; }
        public string Address { get; set; }
        public int PID { get; set; }
        public ServerStatus Status { get; set; } = ServerStatus.Started;
        public string QueryPort { get; set; }
        public string Map { get; set; }
        public int Players { get; set; } = 0;
        public int MaxPlayers { get; set; }
        public int Uptime { get; set; }
        public string FormattedUptime { get; set; }

        public bool AutoRestart { get; set; }
        public bool AutoStart { get; set; }
        public bool AutoUpdate { get; set; }
        public bool UpdateOnStart { get; set; }
        public bool BackupOnStart { get; set; }

        public Server()
        {
            this.FormattedUptime = TimeSpan.FromSeconds(this.Uptime).ToString(@"hh\:mm\:ss");
        }

        private int getUptime()
        {
            return this.Uptime;
        }
    }
}
