namespace windowswebgsm.Data {
    public class ArkSurvivalEvolved : IGameServer {
        
        public string QueryPort {get; set;} = "27015";
        public int GamePort{ get; set;} = 27016;

        public ArkSurvivalEvolved() {
            
        }

        public string GetDefaultQueryPort() {
            return this.QueryPort;
        }

        public int GetDefaultGamePort() {
            return this.GamePort;
        }

        public List<List<string>> GetDefaultGameConfigs() {
            List<string> ConfigPaths = new List<string>();
            List<string> GameConfigs = new List<string>();
            
            List<List<string>> mainList = new List<List<string>>();

            ConfigPaths.Add("GameUserSettings.ini");
            GameConfigs.Add("Test");

            return mainList;
        }

        public List<string> GetDefaultLaunchArguments() {
            List<string> Args = new List<string>();

            return Args;
        }

    }
}