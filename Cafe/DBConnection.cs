using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Cafe
{
    internal class DBConnection
    {
        static string DBConnect = "server=localhost; user=root; password=1234; database=cafe2_db";
        static public MySqlDataAdapter MySqlDataAdapter;
        static MySqlConnection Connection;
        static public MySqlCommand MsCommand;
        

        public static bool ConnectorDB()
        {
            try
            {
                Connection = new MySqlConnection(DBConnect);
                Connection.Open();
                MsCommand = new MySqlCommand();
                MsCommand.Connection = Connection;
                MySqlDataAdapter = new MySqlDataAdapter();
                return true;
            }
            catch
            {
                MessageBox.Show("Не ужалось подключиться к серверу!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
                
            }
        }
        public static void Close_Open()
        {
            Connection.Close();
        }
        public MySqlConnection getConnection()
        {
            return Connection;
        }
    }
}
