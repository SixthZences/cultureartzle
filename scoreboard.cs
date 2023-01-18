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
    public partial class scoreboard : Form
    {
        private static int sys_check = 0;
        public static string username, ign;
        public scoreboard(string username, string ign)
        {
            scoreboard.username = username;
            scoreboard.ign = ign;
            List<string> top = new List<string>();
            List<string> score = new List<string>();
            InitializeComponent();
            sys_check = 0;
            MySqlConnection con = new MySqlConnection("server=localhost;database=persons_cp214;uid=root;pwd='';");
            string sql = "SELECT ign,point FROM accounts ORDER BY point DESC LIMIT 5;";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandTimeout = 60;
            con.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            for (int i = 0; i < 5; i++)
            {
                reader.Read();
                top.Add(reader.GetString(0));
                score.Add(reader.GetString(1));
            }
            top1.Text = top[0];
            top2.Text = top[1];
            top3.Text = top[2];
            top4.Text = top[3];
            top5.Text = top[4];
            score1.Text = score[0];
            score2.Text = score[1];
            score3.Text = score[2];
            score4.Text = score[3];
            score5.Text = score[4];
            con.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mainmenu myNewForm = new Mainmenu(username,ign);
            sys_check = 1;
            this.Close();
            myNewForm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void scoreboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Console.Write(sys_check);
            if (e.CloseReason == System.Windows.Forms.CloseReason.UserClosing && scoreboard.sys_check == 0)
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

        private void scoreboard_Load(object sender, EventArgs e)
        {

        }
    }
}
