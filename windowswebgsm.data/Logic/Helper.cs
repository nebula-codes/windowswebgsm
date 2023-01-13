using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO.Compression;
using System.Net;

namespace windowswebgsm.data.Logic
{
    public class Helper
    {
        public string ServerBin { get; set; }
        public string SteamBin { get; set; }
        public string ServerPath = System.AppDomain.CurrentDomain.BaseDirectory;
        public string SteamUserData { get; set; }
        public string SteamGameData {get;set;}
        public string SteamdCMDUri = "https://steamcdn-a.akamaihd.net/client/installer/steamcmd.zip";

        public Helper()
        {
            ServerBin = ServerPath + "\\bin\\";
            SteamBin = ServerPath + "\\steam\\bin\\";
            SteamUserData = SteamBin + "\\steam\\userData.txt";
            SteamGameData = ServerPath + "\\data\\servers\\";
        }

        public void GenerateDirectories()
        {
            System.IO.Directory.CreateDirectory(ServerPath);
            System.IO.Directory.CreateDirectory(ServerBin);
            System.IO.Directory.CreateDirectory(SteamBin);
            System.IO.Directory.CreateDirectory(SteamGameData);
        }

        public async Task<bool> DownloadSteamCMD()
        {
            Directory.CreateDirectory(SteamBin);
            var exePath = Path.Combine(SteamBin, "steamcmd.exe");
            if (File.Exists(exePath)) { return true; }

            try
            {
                var zipPath = Path.Combine(SteamBin, "steamcmd.zip");
                using (var webClient = new WebClient())
                {
                    await webClient.DownloadFileTaskAsync("https://steamcdn-a.akamaihd.net/client/installer/steamcmd.zip", zipPath);
                }

                //Extract steamcmd.zip and delete the zip
                await Task.Run(() => ZipFile.ExtractToDirectory(zipPath, SteamBin));
                await Task.Run(() => File.Delete(zipPath));

                return true;
            }
            catch
            {
                return false;
            }
        }

        public string GetBin()
        {
            return this.ServerBin;
        }

        public string GetServerPath() 
        {
            return this.ServerPath;
        }

        public string GetSteamGameData () {
            return this.SteamGameData;
        }

        public string GetSteamBin() {
            return this.SteamBin;
        }

        public string GetSteamUserData() {
            return this.SteamUserData;
        }
    }
}
