using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CulturesArtzle
{
    public partial class select_lv : Form
    {
        private static int sys_check = 0;
        public static string username, ign;
        public select_lv(string username,string ign)
        {
            select_lv.username = username;
            select_lv.ign = ign;
            InitializeComponent();
            sys_check = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            start_game myNewForm = new start_game(username, ign);
            sys_check = 1;
            this.Close();
            myNewForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            start_game_n myNewForm = new start_game_n(username, ign);
            sys_check = 1;
            this.Close();
            myNewForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            start_game_h myNewForm = new start_game_h(username, ign);
            sys_check = 1;
            this.Close();
            myNewForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Mainmenu myNewForm = new Mainmenu(username,ign);
            sys_check = 1;
            this.Close();
            myNewForm.Show();
        }

        private void select_lv_FormClosing(object sender, FormClosingEventArgs e)
        {
            Console.Write(sys_check);
            if (e.CloseReason == System.Windows.Forms.CloseReason.UserClosing && select_lv.sys_check == 0)
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

        private void select_lv_Load(object sender, EventArgs e)
        {

        }
    }
}
