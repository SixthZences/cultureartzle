using System;
using System.Windows.Forms;

namespace CulturesArtzle
{
    public partial class Mainmenu : Form
    {
        private static int sys_check=0;
        public static string username, ign;
        public Mainmenu(string username,string ign)
        {
            Mainmenu.username = username;
            Mainmenu.ign = ign;
            InitializeComponent();
            sys_check = 0;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            h2p myNewForm = new h2p(username,ign);
            sys_check = 1;
            this.Close();
            myNewForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sys_check = 1;
            this.Close();
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            scoreboard myNewForm = new scoreboard(username,ign);
            sys_check = 1;
            this.Close();
            myNewForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sign_in myNewForm = new sign_in();
            sys_check = 1;
            this.Close();
            myNewForm.Show();
        }

        private void Mainmenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Console.Write(sys_check);
            if (e.CloseReason == System.Windows.Forms.CloseReason.UserClosing && Mainmenu.sys_check==0)
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

        private void startbtn_Click(object sender, EventArgs e)
        {
            select_lv myNewForm = new select_lv(username,ign);
            sys_check = 1;
            this.Close();
            myNewForm.Show();
        }

        private void Mainmenu_Load(object sender, EventArgs e)
        {
        }
    }
}
