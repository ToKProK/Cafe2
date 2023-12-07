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
        public static DataTable dtOrderingFull = new DataTable();
        public static void GetOrfering()
        {
            MsCommand.CommandText = $"SELECT id_ordering, name_ordering, summa, waiter, ordering.table, count_of_guests, ordering.id_dish_status, " +
                                    $"dish_status.name_dish_status FROM ordering " +
                                    $"INNER JOIN dish_status ON ordering.id_dish_status = dish_status.id_dish_status";


            //MySqlDataReader read = MsCommand.ExecuteReader();
            //read.Read();
            //if (read.HasRows)
            //{
            //    string id = read[0].ToString();
            //    string surname = read[1].ToString();
            //    string name = read[2].ToString();
            //    string patronymic = read[3].ToString();
            //    string name_role = read[4].ToString();
            //}
            //read.Close();

            dtOrdering.Clear();
            MySqlDataAdapter.SelectCommand = MsCommand;
            MySqlDataAdapter.Fill(dtOrdering);
        }
        public static void GetOrferingFull()
        {   
            MsCommand.CommandText = $"SELECT menu.id_dish, menu.name_dish, menu.price, menu_and_ordering.count, menu_and_ordering.summa_dish FROM menu, ordering " +
                                    "INNER JOIN menu_and_ordering ON menu_and_ordering.id_ordering = ordering.id_ordering AND id_dish = menu_and_ordering.id_dish";


            //Почему-то выдаёт ошибку(из-зи ссылки на таблицу в конце menu.id_dish, почему незнаю.)
                                    //$"SELECT menu.id_dish, menu.name_dish, menu.price, menu_and_ordering.count, menu_and_ordering.summa_dish FROM menu, ordering " +
                                    //"INNER JOIN menu_and_ordering ON menu_and_ordering.id_ordering = ordering.id_ordering AND menu.id_dish = menu_and_ordering.id_dish";


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
            //ordering.id_dish_status, dish_status.name_dish_status,
            dtOrderingFull.Clear();
            MySqlDataAdapter.SelectCommand= MsCommand;
            MySqlDataAdapter.Fill(dtOrderingFull);
        }
        public static void AddOrfering()
        {
            string sql = $"INSERT INTO ";
        }
    }
}
