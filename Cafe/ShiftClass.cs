using System;
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
        static public void GetPeople() 
        {
            string sql2 = $"SELECT surname, name, patronymic, sp_role.name_role FROM accounts " +
                          $"INNER JOIN working_people ON working_people.id_shift = shifts.id_shift " +
                          $"INNER JOIN working_people ON accounts.id = working_people.id";
            MsCommand.CommandText = sql2;
            dtPeople.Clear();
            MySqlDataAdapter.SelectCommand = MsCommand;
            MySqlDataAdapter.Fill(dtPeople);
        }
    }
}
