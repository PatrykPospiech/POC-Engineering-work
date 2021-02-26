using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.SqlServer.Storage.Internal;

namespace POC.Calc.API
{
    public class EntryRepository
    {
        public List<DatabaseModel> GetAllEntry()
        {
            using (SqlConnection connection = new SqlConnection(
                "Data Source=127.0.0.1,1401;Initial Catalog=tb_db_wh;User ID=sa;Password=Warehouse!"))
            {
                SqlCommand command = new SqlCommand("select * from db_wh", connection);
                command.Connection.Open();
                var read = command.ExecuteReader();

                List<DatabaseModel> dane = new List<DatabaseModel>();
                
                while (read.Read())
                {
                    dane.Add(new DatabaseModel()
                    {
                        ID = read.GetInt32(0),
                        Dane = read.GetString(1)
                    });
                }

                return dane;
            }

            return null;
        }
    }
}