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
    public partial class h2p : Form
    {
        private static int sys_check = 0;
        public static string username, ign;
        public h2p(string username, string ign)
        {
            h2p.username = username;
            h2p.ign = ign;
            InitializeComponent();
            sys_check = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mainmenu myNewForm = new Mainmenu(username,ign);
            sys_check = 1;
            this.Close();
            myNewForm.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void h2p_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void h2p_FormClosing(object sender, FormClosingEventArgs e)
        {
            Console.Write(sys_check);
            if (e.CloseReason == System.Windows.Forms.CloseReason.UserClosing && h2p.sys_check == 0)
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

        private void h2p_Load(object sender, EventArgs e)
        {

        }
    }
}
