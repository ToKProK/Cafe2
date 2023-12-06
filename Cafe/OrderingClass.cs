using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe
{
    internal class OrderingClass : DBConnection
    {
        public static DataTable dtOrdering = new DataTable();
        public static void GetOrfering()
        {
            MsCommand.CommandText = $"SELECT id_ordering, name_ordering, summa, waiter, table, count_of_guests, " +
                                    $"dish_status.name_dish_status, id_dish_status FROM ordering " +
                                    $"INNER JOIN dish_status ON dish_status.id_dish_status = ordering.id_dish_status ";


            MySqlDataReader read = MsCommand.ExecuteReader();
            read.Read();
            if (read.HasRows)
            {
                string id = read[0].ToString();
                string surname = read[1].ToString();
                string name = read[2].ToString();
                string patronymic = read[3].ToString();
                string name_role = read[4].ToString();
            }
            read.Close();

            dtOrdering.Clear();
            MySqlDataAdapter.SelectCommand = MsCommand;
            MySqlDataAdapter.Fill(dtOrdering);
        }
    }
}
