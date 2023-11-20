using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.DataAccess;
using System.Configuration;


namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public const string prizesFile = "PrizeModels.csv";
        public const string peopleFile = "PeopleModels.csv";
        public const string teamFile = "TeamModels.csv";
        public const string tournamentFile = "TouranementModels.csv";
        public const string matchupFile = "MatchupModels.csv";
        public const string matchupEntryFile = "MatchupEntryModels.csv";
        public static IDataConnection Connection { get; private set; }
        public static void InitializeConnections(DatabaseType db)
        {
            if (db == DatabaseType.Sql)
            {
                SqlConnector sql = new SqlConnector();
                Connection = sql;
            }
            if(db == DatabaseType.TextFile)
            {
                TextConnector text = new TextConnector();
                Connection = text;
            }

        }
        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
