using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Cafe
{
    internal class AccountClass : DBConnection
    {
        public static DataTable dtAccount = new DataTable();

        static public string id, login, password, surname, name, patronymic, role, status;

        static public void GetAccount()
        {
            MsCommand.CommandText = $"SELECT id, login, password, surname, name, patronymic, sp_role.name_role, sp_status.name_status FROM accounts " +
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
    }
}
