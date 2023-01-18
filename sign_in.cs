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
    public partial class sign_in : Form
    {
        
        private static int sys_check = 0;
        public string username, password, ign; 
        public sign_in()
        {
            username = "";
            password = "";
            ign = "";
            InitializeComponent();
            sys_check = 0;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            sys_check = 1;
            this.Close();
            Application.Exit();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input_username = textBox1.Text;
            string input_password = textBox2.Text;
            int login;
            login = 0;
            if (input_username.Length == 0 ||input_password.Length == 0)
            {
                MessageBox.Show("Please input username and password.", "Cultures Artzle", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
               
                  MySqlConnection con = new MySqlConnection("server=localhost;database=persons_cp214;uid=root;pwd='';");
                  string sql = "SELECT username,password,ign FROM accounts WHERE username='"+ input_username+"';";
                  MySqlCommand cmd = new MySqlCommand(sql, con);
                  cmd.CommandTimeout = 60;

                    con.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                try 
                    { 
                    username = reader.GetString(0);
                    password = reader.GetString(1);
                    ign = reader.GetString(2);
                    if (input_password == password)
                    {
                        login = 1;
                    }
                    else
                    {
                        MessageBox.Show("Invalid password !", "Cultures Artzle", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    }
                  catch (Exception ex)
                  {
                    if (reader.ToString() == "MySql.Data.MySqlClient.MySqlDataReader")
                    {
                        MessageBox.Show("Invalid username", "Cultures Artzle",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Query error "+ex.Message);
                    }
                  }
                    con.Close();


            }
            if (login == 1)
            {
                Mainmenu myNewForm = new Mainmenu(username,ign);
                sys_check = 1;

                this.Close();
                myNewForm.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sign_up myNewForm = new sign_up();
            sys_check = 1;
            this.Close();
            myNewForm.Show();
        }

        private void sign_in_Load(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void sign_in_FormClosing(object sender, FormClosingEventArgs e)
        {
            Console.Write(sys_check);
            if (e.CloseReason == System.Windows.Forms.CloseReason.UserClosing && sign_in.sys_check == 0)
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
