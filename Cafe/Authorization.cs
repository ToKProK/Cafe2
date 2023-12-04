using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Cafe
{
    internal class Authorization : DBConnection
    {
        static public string Role, Surname, Name, Patronymic;
        static public void Authoriz(string login, string password)
        {
            try
            {
                DBConnection.MsCommand.CommandText = $"SELECT sp_role.name_role, surname, name, patronymic FROM accounts " +
                                                     $"INNER JOIN sp_role ON sp_role.id_role = accounts.id_role " +
                                                     $"WHERE login = '{login}' AND password = '{password}'";
                                                     


                MySqlDataReader read = MsCommand.ExecuteReader();
                read.Read();
                if (read.HasRows)
                {
                    Role = read[0].ToString();
                    Surname = read[1].ToString();
                    Name = read[2].ToString();
                    Patronymic = read[3].ToString();
                }
                else
                {
                    Role = null;
                    Surname = null;
                    Name = null;
                    Patronymic = null;
                }
                read.Close();
            }
            catch
            {
                Role = null;
                Surname = null;
                Name = null;
                Patronymic = null;
                MessageBox.Show("Ошибка авторизации");
            }
        }
    }
}
