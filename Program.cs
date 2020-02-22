using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace StorageManager
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

    static class DBConnect//класс подключения к БД
    {
        public static MySqlConnection Conn { get; set; }
    }

    static class ActiveUser//текющий пользователь в системе, разным пользователям разные доступы
    {
        //уровни доступа
        //1 - администратор, 2 - рабочий склада, 3 - проектировщик, 4 - бухгалтерия
        public static int UserPrevilegies { get; set; }
        public static int CurrentUser { get; set; }//ид текущего пользователя
       
    }

    public class ItemCats
        //типы компонентов, облегчает выбор и сортировку
    {
        public int Id { get; set; }//ид из БД
        public string Name { get; set; }//вводимое пользователями имя
    }

}
