namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();
        public static void InitializeConnections(bool database, bool textFiles)
        {
            if(database)
            {
                //TODO - sql connection proper set up
                SqlConnector sql = new SqlConnector();
                Connections.Add(sql);
            }
            if(textFiles)
            {
                // TODO - Create text connection
                TextConnector text = new TextConnector();
                Connections.Add(text);
            }
        }
        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
