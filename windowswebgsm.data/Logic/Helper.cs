using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace windowswebgsm.data.Logic
{
    public class Helper
    {
        public string ServerBin { get; set; }
        public string SteamBin { get; set; }
        public string ServerPath = System.AppDomain.CurrentDomain.BaseDirectory;
        public string SteamUserData { get; set; }
        public string SteamGameData {get;set;}
        

        public Helper()
        {
            ServerBin = ServerPath += "\\bin\\";
            SteamBin = ServerPath += "\\steam\\bin\\";
            SteamUserData = SteamBin += "\\userData.txt";
            SteamGameData = ServerPath += "\\data\\servers\\";
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
