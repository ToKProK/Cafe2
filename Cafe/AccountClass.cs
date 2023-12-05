using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Cafe
{
    internal class AccountClass : DBConnection
    {
        static public DataTable dtStatus = new DataTable();
        static public DataTable dtRole = new DataTable();
        public static DataTable dtAccount = new DataTable();

        static public string id, login, password, surname, name, patronymic, role, status;

        static public void GetAccount()
        {
            MsCommand.CommandText = $"SELECT id, login, password, surname, name, patronymic, sp_role.name_role,sp_role.id_role," +
                                    $" sp_status.name_status, sp_status.id_status FROM accounts " +
                                    $"INNER JOIN sp_role ON sp_role.id_role = accounts.id_role " +
                                    $"INNER JOIN sp_status ON sp_status.id_status=accounts.id_status ";

            //MySqlDataReader read = MsCommand.ExecuteReader();
            //read.Read();
            //if (read.HasRows)
            //{
            //    id = read[0].ToString();
            //    login = read[1].ToString();
            //    password = read[2].ToString();
            //    surname = read[3].ToString();
            //    name = read[4].ToString();
            //    patronymic = read[5].ToString();
            //    role = read[6].ToString();
            //    status = read[7].ToString();
            //}
            dtAccount.Clear();
            MySqlDataAdapter.SelectCommand = MsCommand;
            MySqlDataAdapter.Fill(dtAccount);
        }

        static public bool AddAccount(string login, string password, string surname, string name, string patronymic, int id_role, int id_status)
        {
            try
            {
                MsCommand.CommandText = $"INSERT INTO accounts VALUES(null, '{login}', '{password}', '{surname}', '{name}', '{patronymic}', '{id_role}', '{id_status}')";
                if (MsCommand.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка добавления пользователя в базу данных" + ex);
                return false;
            } 

        }
        static public bool EditAccount(int id,string login, string password, string surname, string name, string patronymic, int id_role, int id_status)
        {
            try
            {
                MsCommand.CommandText = $"UPDATE accounts SET login = '{login}', password = '{password}', " +
                                        $"surname = '{surname}', name = '{name}', patronymic = '{patronymic}', " +
                                        $"id_role = '{id_role}', id_status = '{id_status}' " +
                                        $"WHERE id = '{id}'";
                if (MsCommand.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch 
            {
                MessageBox.Show("Ошибка редактирования");
                return false;
            }
            
        }
        static public void DeleteAccount(int id)
        {
            try
            {
                MsCommand.CommandText = $"DELETE FROM accounts WHERE id = {id}";
                MsCommand.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Ошибка при удалении!");
            }
        }










        static public void GetStatus()
        {
            MsCommand.CommandText = $"SELECT * FROM sp_status";
            dtStatus.Clear();
            MySqlDataAdapter.SelectCommand = MsCommand;
            MySqlDataAdapter.Fill(dtStatus);
        }
        static public void GetRole()
        {
            MsCommand.CommandText = $"SELECT * FROM sp_role";
            dtRole.Clear();
            MySqlDataAdapter.SelectCommand = MsCommand;
            MySqlDataAdapter.Fill(dtRole);
            }
    }
}
