using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Cafe
{
    internal class Authorization
    {
        static public string Role, Surname, User;

        static public void Authoriz(string login, string password)
        {
            try
            {
                DBConnection.MsCommand.CommandText = $"SELECT name_role FROM sp_role, account WHERE login = '{login}' and password = '{password}' and account.id_role=sp_role.id_role";
                Object result = DBConnection.MsCommand.ExecuteScalar();
                if(result != null)
                {
                    Role = result.ToString();
                    User = login;
                }
                else
                {
                    Role = null;
                    User = null;
                }
        }
            catch 
            {
                Role = null;
                User = null;
                MessageBox.Show("Ошибка авторизации");
            }
}
        static public string AuthorizationSurname(string login)
        {
            try
            {
                DBConnection.MsCommand.CommandText = $"SELECT surname FROM account WHERE login = '{login}'";
                Object result = DBConnection.MsCommand.ExecuteScalar();
                Surname = result.ToString();
                return Surname;
            }
            catch
            {
                MessageBox.Show("нет фамилии");
                return null;
            }

        }

    }
}
