using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Web;

namespace LESI_ISI_TP2_26052_SOAP2
{
    public class BitcoinDatabase
    {
        private readonly string _connectionString;

        public BitcoinDatabase()
        {
            _connectionString = "Server=tcp:bitcoin-server.database.windows.net,1433;Initial Catalog=bitcoinApp-database;Persist Security Info=False;User ID=satoshi;Password=a26052LESI;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        }

        public SqlConnection GetConnection()
        {
            var connection = new SqlConnection(_connectionString);
            connection.Open();
            return connection;
        }
    }
}