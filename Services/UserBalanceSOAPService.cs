using System;
using System.Data.SqlClient;
using System.Configuration;
using LESI_ISI_TP2_26052_SOAP2;

namespace LESI_ISI_TP2_26052_SOAP2
{
    public class UserBalanceSOAPService : IUserBalanceSOAPService
    {
        public double GetTotalUnitsForUser(int idUser)
        {
            double totalUnits = 0;
            using (var connection = new BitcoinDatabase().GetConnection())
            {
                string query = "SELECT SUM(units) FROM [Transaction] WHERE idUser = @idUser";

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@idUser", idUser);

                    var result = command.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        totalUnits = Convert.ToDouble(result);
                    }
                }
            }
            return totalUnits;
        }
    }
}
