using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CulturesArtzle
{
    public partial class score : Form
    {
        public static int point;
        private static int sys_check = 0;
        public static string username, ign;
        public score(string username, string ign, int point)
        {
            score.username = username;
            score.ign = ign;
            score.point = point;
            InitializeComponent();
            sys_check = 0;
            label2.Text = "Score : "+score.point.ToString();
            MySqlConnection con = new MySqlConnection("server=localhost;database=persons_cp214;uid=root;pwd='';");
            string sql = "SELECT point FROM accounts WHERE username='" + username + "' and ign ='"+ign+"';";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandTimeout = 60;
            con.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            if (point >= Convert.ToInt32(reader.GetString(0)))
            {
                try
                {

                reader.Close();
                con.Close();
                con.Open();
                sql = "UPDATE accounts SET point = " + point.ToString() + " WHERE username='" + username + "' and ign ='" + ign + "';";
                cmd = new MySqlCommand(sql, con);
                reader = cmd.ExecuteReader();
                reader.Read();
                label3.Visible = true;
                reader.Close();
                con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(sql+"   "+ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mainmenu myNewForm = new Mainmenu(username, ign);
            sys_check = 1;
            this.Close();
            myNewForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            select_lv myNewForm = new select_lv(username,ign);
            sys_check = 1;
            this.Close();
            myNewForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sys_check = 1;
            this.Close();
            Application.Exit();
        }

        private void score_FormClosing(object sender, FormClosingEventArgs e)
        {
            Console.Write(sys_check);
            if (e.CloseReason == System.Windows.Forms.CloseReason.UserClosing && score.sys_check == 0)
            {
                DialogResult iExit = MessageBox.Show("Are you sure to exit the game ?", "Cultures Artzle", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (iExit == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    Application.ExitThread();
                }
            }
        }

        private void score_Load(object sender, EventArgs e)
        {

        }
    }
}
