using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.SqlServer.Storage.Internal;

namespace POC.Calc.API
{
    public class EntryRepository
    {

        public void AddEntry(DatabaseModel databaseModel)
        {
            using (SqlConnection connection = new SqlConnection(
                @"Data Source=192.168.137.11\PRVSQL14;Initial Catalog=db_wh;User ID=sa;Password=sql"))
            {
                SqlCommand command = new SqlCommand($"insert into tb_db_wh (ID, Dane) values ({databaseModel.ID}, {databaseModel.Dane});", connection);
                command.Connection.Open();
                command.ExecuteNonQuery();

            }
            
        }
        public List<DatabaseModel> GetAllEntry()
        {
            using (SqlConnection connection = new SqlConnection(
                @"Data Source=192.168.137.11\PRVSQL14;Initial Catalog=db_wh;User ID=sa;Password=sql"))
            {
                SqlCommand command = new SqlCommand("select * from tb_db_wh", connection);
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