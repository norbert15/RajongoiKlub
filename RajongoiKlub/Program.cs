using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace RajongoiKlub
{
    static class Program
    {

        public static TagFelvetel tagFelvetel = null;
        public static TagBefizetesFelvetele tagBefizetes = null;
        public static TagKilistazas tagKilistazas = null;
        public static TagKreditKiszamitas tagKreditKiszamitas = null;
        public static TagTorlese tagTorlese = null;
        public static MySqlConnection conn = null;
        public static MySqlCommand sql = null;
        public static Form_Nyito nyito = null;

        [STAThread]
        static void Main()
        {

            MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder();
            sb.Server = "localhost";
            sb.UserID = "root";
            sb.Password = "";
            sb.Database = "rajongoi_ab";

            conn = new MySqlConnection(sb.ToString());

            try
            {
                conn.Open();
                sql = conn.CreateCommand();
            }
            catch (MySqlException me)
            {
                Console.WriteLine(me.Message);
                Console.ReadKey();
                Environment.Exit(0);
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            tagFelvetel = new TagFelvetel();
            tagBefizetes = new TagBefizetesFelvetele();
            tagKilistazas = new TagKilistazas();
            tagKreditKiszamitas = new TagKreditKiszamitas();
            tagTorlese = new TagTorlese();
            nyito = new Form_Nyito();

            Application.Run(nyito);
        }
    }
}
