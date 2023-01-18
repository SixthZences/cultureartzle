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
    public partial class sign_up : Form
    {
        private static int sys_check = 0;
        public sign_up()
        {
            InitializeComponent();
            sys_check = 0;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void sign_up_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            sign_in myNewForm = new sign_in();
            sys_check = 1;
            this.Close();
            myNewForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string ign = textBox2.Text;
            string password = textBox3.Text;
            string confirm_pwd = textBox4.Text;
            int register = 0;
            if (username.Length==0 || ign.Length==0 || password.Length==0 || confirm_pwd.Length==0)
            {
                MessageBox.Show("Please input all information.", "Cultures Artzle", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MySqlConnection con = new MySqlConnection("server=localhost;database=persons_cp214;uid=root;pwd='';");
                string sql = "SELECT username,ign FROM accounts;";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                con.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    while (reader.Read()) 
                    { 
                        string username_DB = reader.GetString(0);
                        string ign_DB = reader.GetString(1);
                        Console.WriteLine(username_DB+ign_DB);
                        if (username == username_DB)
                            {
                                MessageBox.Show("Username already exists", "Cultures Artzle", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                            }
                        else if (ign == ign_DB)
                            {
                                MessageBox.Show("In-game name already exists", "Cultures Artzle", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                            }
                        
                    }
                    reader.Close();
                }
                else
                {

                    if (password == confirm_pwd)
                    {
                        reader.Close();
                        sql = "INSERT INTO accounts (username,password,ign) VALUES ('"+username+"','"+password+"','"+ign+"');";
                        cmd = new MySqlCommand(sql, con);
                        cmd.CommandTimeout = 60;
                        try 
                            {
                        
                                MySqlDataReader adapter = cmd.ExecuteReader();
                                MessageBox.Show("Register successfully.","Cultures Artzle",MessageBoxButtons.OK,MessageBoxIcon.Information);
                                register = 1;
                                con.Close();
                            } 
                        catch (Exception ex)
                            {
                                MessageBox.Show("Query error"+ex.Message);
                            }
                }
                else
                {
                    MessageBox.Show("Confirm-password must be the same as password", "Cultures Artzle", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                }
               

            }
            if (register==1)
            {
            sign_in myNewForm = new sign_in();
            sys_check = 1;
            this.Close();
            myNewForm.Show();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void sign_up_FormClosing(object sender, FormClosingEventArgs e)
        {
            Console.Write(sys_check);
            if (e.CloseReason == System.Windows.Forms.CloseReason.UserClosing && sign_up.sys_check == 0)
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
    }
}
