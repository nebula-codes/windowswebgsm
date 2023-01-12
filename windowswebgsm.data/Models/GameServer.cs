namespace windowswebgsm.Data
{
    public class GameServer
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

        public enum ServerType {
            Steam = 0,
            Java = 1,
            Custom = 3,
        }

        public string SteamID { get; set; }
        public string SteamName { get; set; }
        public string IconPath { get; set; }
        public string BannerPath { get; set; }
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


        
        public GameServer()
        {
            this.FormattedUptime = TimeSpan.FromSeconds(this.Uptime).ToString(@"hh\:mm\:ss");
        }

        private int getUptime()
        {
            return this.Uptime;
        }

        public IEnumerable<GameServer> getGeneratedServers()
        {
            List<GameServer> servers = new List<GameServer>();

            servers.Add(this);
            servers.Add(this);

            return servers;
        }
    }
}
