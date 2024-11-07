using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;
using SQLitePCL;

namespace PaperScissorRockGame
{
    internal class Connection
    {
        private string _connectionString;

        public Connection(string connectionString)
        {
            _connectionString = connectionString;
            SQLitePCL.raw.SetProvider(new SQLite3Provider_e_sqlite3());
        }

        public SqliteConnection GetConnection()
        {
            return new SqliteConnection(_connectionString);
        }
    }
}
