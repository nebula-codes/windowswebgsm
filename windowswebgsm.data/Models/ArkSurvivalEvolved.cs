namespace windowswebgsm.Data {
    public class ArkSurvivalEvolved : IGameServer {
        
        public string QueryPort {get; set;} = "27015";
        public string GamePort{ get; set;} = 27016;
        public string LaunchArguments {get;set;};

        public ArkSurvivalEvolved() {
            
        }

        public string GetDefaultQueryPort() {
            return this.QueryPort;
        }

        public int GetDefaultGamePort() {
            return this.GamePort
        }

        public List<List<string>> GetDefaultGameConfigs() {
            List<string> ConfigPaths = new List<string>();
            List<string> GameConfigs = new List<string>();
            
            ConfigPaths.Add("GameUserSettings.ini");
            GameConfigs.Add("Test")
        }

        public List<string> GetDefaultLaunchArguments() {
            return this.LaunchArguments;
        }

    }
}