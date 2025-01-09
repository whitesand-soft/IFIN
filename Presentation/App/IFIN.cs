using System;
using System.IO;
using System.Linq;
using CoreLib.Helpers;
using Dapper;

namespace Presentation.App
{
    public class IFIN
    {
        public static IServiceProvider ServiceProvider { get; private set; }

        public static void Bootstrap()
        {
            setupSQLite();
        }

        private static void setupSQLite()
        {
            SQLiteHelper.CreateDbIfNotExist();

            SQLiteHelper.RunScript(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "App/Sql/CREATE_TABLE_IF_NOT_EXISTS.sql"));

            // INSERT DATA FOR LV2TYPE IF NOT EXISTS
            bool isTableLv2TypeHasData = false;
            using (var conn = SQLiteHelper.NewConnection())
                isTableLv2TypeHasData = conn.Query("SELECT * FROM LV2TYPE LIMIT 1").Count() > 0;

            if (!isTableLv2TypeHasData)
                SQLiteHelper.RunScript(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "App/Sql/INSERT_LV2TYPE.sql"));

#if DEBUG
            // INSERT DATA FOR TICKET IF NOT EXISTS (DEV ONLY)
            bool isTableTicketHasData = false;
            using (var conn = SQLiteHelper.NewConnection())
                isTableTicketHasData = conn.Query("SELECT * FROM TICKET LIMIT 1").Count() > 0;

            if (isTableTicketHasData)
                SQLiteHelper.RunScript(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "App/Sql/INSERT_TICKET.sql"));
#endif
        }
    }
}
