interface IGameServer {
    string GetDefaultQueryPort();
    int GetDefaultGamePort();
    List<List<string>> GetDefaultGameConfigs();
    List<string> GetDefaultLaunchArguments();
}