using System;
using System.Configuration;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using Dapper;

namespace CoreLib.Helpers
{
    public static class DbHelper
    {
        public static string GetDbFilePath()
        {
            string sqlitePath = ConfigurationManager.AppSettings["SQLITE_PATH"];
            if (string.IsNullOrEmpty(sqlitePath))
                throw new Exception("DefaultConnectionStrings is missing");

            return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, sqlitePath);
        }
        
        public static SQLiteConnection NewConnection()
            => new SQLiteConnection($"Data Source={GetDbFilePath()};Version=3;");

        public static void RunScript(string scriptPath)
        {
            string script = File.ReadAllText(scriptPath);
            var commandString = script.Split(';').Where(s => !string.IsNullOrEmpty(s));

            using (var conn = NewConnection())
                foreach (var cmdStr in commandString)
                    conn.Execute(cmdStr);
        }

        public static void CreateDbIfNotExist()
        {
            string sqlitePath = GetDbFilePath();

            if (!Directory.Exists(Path.GetDirectoryName(sqlitePath)))
                Directory.CreateDirectory(Path.GetDirectoryName(sqlitePath));

            if (!File.Exists(sqlitePath))
                SQLiteConnection.CreateFile(sqlitePath);
        }
    }
}
