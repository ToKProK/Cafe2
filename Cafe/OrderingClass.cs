using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe
{
    internal class OrderingClass : DBConnection
    {
        public static DataTable dtOrdering = new DataTable();
        public static DataTable dtOrderingFull = new DataTable();
        public static void GetOrfering()
        {
            MsCommand.CommandText = $"SELECT id_ordering, name_ordering, summa, id_waiter, accounts.surname, ordering.table, count_of_guests, ordering.id_dish_status, " +
                                    $"dish_status.name_dish_status FROM ordering " +
                                    $"INNER JOIN dish_status ON ordering.id_dish_status = dish_status.id_dish_status " +
                                    $"INNER JOIN accounts ON accounts.id = id_waiter";


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
        public static void GetOrferingFull(int id_select_ordering)
        {
            MsCommand.CommandText = $"SELECT menu.id_dish, menu.name_dish, menu.price, menu_and_ordering.count , menu_and_ordering.summa_dish FROM menu, ordering, menu_and_ordering WHERE menu_and_ordering.id_ordering = ordering.id_ordering AND menu.id_dish = menu_and_ordering.id_dish AND menu_and_ordering.id_ordering = '{id_select_ordering}';";



            //Почему-то выдаёт ошибку(из-зи ссылки на таблицу в конце menu.id_dish, почему незнаю.)
            //$"SELECT menu.id_dish, menu.name_dish, menu.price, menu_and_ordering.count, menu_and_ordering.summa_dish FROM menu, ordering " +
            //"INNER JOIN menu_and_ordering ON menu_and_ordering.id_ordering = ordering.id_ordering AND menu.id_dish = menu_and_ordering.id_dish";

            //ordering.id_dish_status, dish_status.name_dish_status,
            dtOrderingFull.Clear();
            MySqlDataAdapter.SelectCommand = MsCommand;
            MySqlDataAdapter.Fill(dtOrderingFull);
        }
        public static void AddOrfering(string name_ordering, int count_of_guests, int id_waiter, string table, int summa, int id_dish_status,int id_ordering, ArrayList id_dish, ArrayList count, ArrayList summa_dish)
        {
            string sql = $"INSERT INTO ordering VALUES(null, '{name_ordering}', '{summa}', '{id_waiter}', '{table}', '{count_of_guests}', '{id_dish_status}'); ";
            
            for (int i = 0; i < id_dish.Count; i++)
            {
                string sql2 = $"INSERT INTO menu_and_ordering VALUES(null, '{id_ordering}', '{id_dish[i]}', '{count[i]}', '{summa_dish[i]}'); ";
                sql = sql + sql2 ;
            }
            MsCommand.CommandText = sql;
            if (MsCommand.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Успех");
            }
            else
            {
                MessageBox.Show("Провал");
            }
        }


        public static DataTable dtRoleForWaiter = new DataTable();
        public static DataTable dtShiftStatus = new DataTable();
        public static void GetDataWaiter()
        {
            MsCommand.CommandText = $"SELECT surname, id FROM accounts " +
                                    $"WHERE accounts.id_role = 3 ";
            dtRoleForWaiter.Clear();
            MySqlDataAdapter.SelectCommand = MsCommand;
            MySqlDataAdapter.Fill(dtRoleForWaiter);

        }
        public static void GetDataShiftStatus()
        {
            if (Authorization.Role == "Официант")
            {
                MsCommand.CommandText = $"SELECT id_dish_status, name_dish_status FROM dish_status " +
                                        $"WHERE dish_status.id_dish_status = 1 OR dish_status.id_dish_status = 4";
                dtShiftStatus.Clear();
                MySqlDataAdapter.SelectCommand = MsCommand;
                MySqlDataAdapter.Fill(dtShiftStatus);
            }
            if (Authorization.Role == "Повар") 
            {
                MsCommand.CommandText = $"SELECT id_dish_status, name_dish_status FROM dish_status " +
                        $"WHERE dish_status.id_dish_status = 2 OR dish_status.id_dish_status = 3";
                dtShiftStatus.Clear();
                MySqlDataAdapter.SelectCommand = MsCommand;
                MySqlDataAdapter.Fill(dtShiftStatus);
            }
        }
        /////////////////////////////////////////////////////////
        public static DataTable dtMenu = new DataTable();
        public static void GetMenu()
        {
            MsCommand.CommandText = $"SELECT id_dish, name_dish, price FROM menu";
            dtMenu.Clear();
            MySqlDataAdapter.SelectCommand = MsCommand;
            MySqlDataAdapter.Fill(dtMenu);
        }
        /////////////////////////////////////////////////////////
    }
}
