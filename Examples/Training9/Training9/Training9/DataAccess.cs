using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training9
{
    public static class DataAccess
    {
        private const string connectionString = "Data Source=logolsdb.database.windows.net;Initial Catalog=LogolsLearning;Integrated Security=False;User Id=JimiH68;Password=Hendri3h;MultipleActiveResultSets=True";

        public static IList<T> GetData<T>(SqlCommand command, Func<SqlDataReader, T> mapFunction)
        {
            IList<T> records = new List<T>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                command.Connection = connection;
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    records.Add(mapFunction(reader));
                }
            }

            return records;
        }

        public static void ExecuteCommand(SqlCommand command)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                command.Connection = connection;
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
