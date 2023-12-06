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
    internal class ShiftClass : DBConnection
    {
        int id_shift;
        //(Дневная/Ночная)
        string Shift;
        DateTime startShift = new DateTime(); //YYYY-MM-DD HH:MI:SS
        DateTime endShift = new DateTime();
        //ФИО
        //Должность



        static public DataTable dtVShift = new DataTable();
        static public DataTable dtShift = new DataTable();
        static public DataTable dtPeople = new DataTable();
        static public void GetShift()
        {
            try
            {
                string sql = $"SELECT id_shift, data_start, data_end, view_shift.name_vshift FROM shifts " +
                             $"INNER JOIN view_shift ON view_shift.id_vshift=shifts.id_vshift";
                MsCommand.CommandText = sql;
                dtShift.Clear();
                MySqlDataAdapter.SelectCommand = MsCommand;
                MySqlDataAdapter.Fill(dtShift);
            }
            catch 
            {
                MessageBox.Show("Ошибка при получении Смен");
            }
        }
        static public void GetPeople(int id_shift) 
        {
            string sql2 = $"SELECT accounts.id, surname, name, patronymic, sp_role.name_role FROM accounts " +
                          $"INNER JOIN sp_role ON sp_role.id_role = accounts.id_role " +
                          $"INNER JOIN working_people ON working_people.id = accounts.id " +
                          $"INNER JOIN shifts ON working_people.id_shift = shifts.id_shift " +
                          $"WHERE shifts.id_shift = '{id_shift}'";
            MsCommand.CommandText = sql2;


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

            MsCommand.CommandText = sql2;
            dtPeople.Clear();
            MySqlDataAdapter.SelectCommand = MsCommand;
            MySqlDataAdapter.Fill(dtPeople);


        }
        static public void AddShift(string data_start, string data_end, int id_vshift, ArrayList array_id, ArrayList array_id_shift)
        {
            string sql = $"INSERT INTO shifts VALUES(null, '{data_start}', '{data_end}', '{id_vshift}');";
            if (array_id.Count == array_id_shift.Count) //количество id смены и количество id сотрудников должно быть одинаково.
            {
                for (int i = 0; i < array_id.Count; i++)
                {
                    string sql_insert_personal = $"INSERT INTO working_people VALUES(null, '{array_id[i]}', '{array_id_shift[i]}');";
                    sql = sql + sql_insert_personal;
                }
            }
            else
            {
                MessageBox.Show("Ошибка в содрудниках смены.");
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
        //Тут будет всё для добавления пользователя.
        public static int id_add_user;
        public static string surname_add_user;
        public static string name_add_user;
        public static string patronymic_add_user;
        public static string name_role_add_user;
        public static string id_role_add_user;

        static public DataTable dt_add_user = new DataTable();
        static public void GetPeople_ForAddForm()
        {
            try
            {
                string sql3 = $"SELECT accounts.id, surname, name, patronymic, sp_role.name_role, sp_role.id_role FROM accounts " +
                          $"INNER JOIN sp_role ON sp_role.id_role = accounts.id_role " +
                          $"WHERE accounts.id_role <> 1";
                MsCommand.CommandText = sql3;


                MsCommand.CommandText = sql3;
                dt_add_user.Clear();
                MySqlDataAdapter.SelectCommand = MsCommand;
                MySqlDataAdapter.Fill(dt_add_user);
            }
            catch 
            {
                MessageBox.Show("Ошибка");
            }
            


        }

        ////////////////////////////////////////////////////////////////////////////////
        static public void GetView_shift()
        {
            MsCommand.CommandText = $"SELECT * FROM view_shift";
            dtVShift.Clear();
            MySqlDataAdapter.SelectCommand = MsCommand;
            MySqlDataAdapter.Fill(dtVShift);
        }
    }
}
