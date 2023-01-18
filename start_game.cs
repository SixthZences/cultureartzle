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
    public partial class start_game : Form
    {
        private static int sys_check=0;
        public List<Image> bref = new List<Image>();
        private int counter,point;
        private int timer =0,timer_s=0,timer_m=0;
        public static string username, ign;
        public start_game(string username, string ign)
        {
            start_game.username = username;
            start_game.ign = ign;
            InitializeComponent();
            sys_check = 0;
            counter = timer = timer_m = timer_s = 0;
            label2.Text = timer_m.ToString() + ":" + timer_s.ToString();

        }
        public void movedChecker(Button Butt1,Button Butt2)
        {
            if (Butt2.Text == "")
            {
                Butt2.Text = Butt1.Text;
                Butt2.Image = Butt1.Image;
                Butt1.Text = "";
                Butt1.Image = UI_Design.Properties.Resources._0;
                counter++;
            }
        }
        public void solutionChecker()
        {
            Boolean winner = false;
            if (puzzle1.Text =="1" && puzzle2.Text == "2" && puzzle3.Text == "3" && puzzle4.Text == "4" && puzzle5.Text == "5" && puzzle6.Text == "6" && puzzle7.Text == "7" && puzzle8.Text == "8" && puzzle9.Text == "")
            {
                MessageBox.Show("Congratulations","Cultures Artzles",MessageBoxButtons.OK,MessageBoxIcon.Information);
                winner= true;
            }
            if (winner)
            {
                    timer1.Enabled = false;
                    if (timer < 60 && counter < 50)
                    {
                        point = (((60 - timer) * (100 - counter)) * 2)+2000;
                    }
                    else if (timer < 60)
                    {
                        point = (60 - timer)+2000;
                    }
                    else if (counter < 50)
                    {
                        point = (50 - counter)+2000;
                    }
                    else
                    {
                        point = 2000;
                    }
                    score myNewForm = new score(username, ign,point);
                sys_check=1;
                this.Close();
                myNewForm.Show();
            }
        }

        public void Shuffle()
        {
            counter = timer = timer_m = timer_s = 0;
            int[] bnum = new int[9];
            int i, j, rowcheck,pic;
            Image im0, im1, im2, im3, im4, im5, im6, im7, im8, im9, im10;
            Boolean flag = false;
            Random r = new Random();
            pic = Convert.ToInt32(r.Next(0, 8));
            pic = pic % 2;
            bref.Clear();
            i = 1;
            do
            {
                Random random = new Random();
                rowcheck = Convert.ToInt32((random.Next(0, 8)) + 1);
                for (j = 1; j <= i; j++)
                {
                    if (bnum[j] == rowcheck)
                    {
                        flag = true;
                        break;
                    }

                }
                if (flag == true)
                {
                    flag = false;
                }
                else
                {
                    bnum[i] = rowcheck;
                    i = i + 1;
                }
            } while (i <= 8);
            if (pic== 0)
            {
                im0 = UI_Design.Properties.Resources.ref_songpra;
                im1 = UI_Design.Properties.Resources.songpra_01;
                im2 = UI_Design.Properties.Resources.songpra_02;
                im3 = UI_Design.Properties.Resources.songpra_03;
                im4 = UI_Design.Properties.Resources.songpra_04;
                im5 = UI_Design.Properties.Resources.songpra_05;
                im6 = UI_Design.Properties.Resources.songpra_06;
                im7 = UI_Design.Properties.Resources.songpra_07;
                im8 = UI_Design.Properties.Resources.songpra_08;
                im9 = UI_Design.Properties.Resources.songpra_09;
                im10 = UI_Design.Properties.Resources._0;
            }
            else
            {
                im0 = UI_Design.Properties.Resources.ref_TaaChone;
                im1 = UI_Design.Properties.Resources.Untitled_1_01;
                im2 = UI_Design.Properties.Resources.Untitled_1_02;
                im3 = UI_Design.Properties.Resources.Untitled_1_03;
                im4 = UI_Design.Properties.Resources.Untitled_1_04;
                im5 = UI_Design.Properties.Resources.Untitled_1_05;
                im6 = UI_Design.Properties.Resources.Untitled_1_06;
                im7 = UI_Design.Properties.Resources.Untitled_1_07;
                im8 = UI_Design.Properties.Resources.Untitled_1_08;
                im9 = UI_Design.Properties.Resources.Untitled_1_09;
                im10 = UI_Design.Properties.Resources._0;
            }
            bref.Add(im0);
            bref.Add(im1);
            bref.Add(im2);
            bref.Add(im3);
            bref.Add(im4);
            bref.Add(im5);
            bref.Add(im6);
            bref.Add(im7);
            bref.Add(im8);
            bref.Add(im9);
            bref.Add(im10);
            puzzle1.Text = Convert.ToString(bnum[1]);
            puzzle2.Text = Convert.ToString(bnum[2]);
            puzzle3.Text = Convert.ToString(bnum[3]);
            puzzle4.Text = Convert.ToString(bnum[4]);
            puzzle5.Text = Convert.ToString(bnum[5]);
            puzzle6.Text = Convert.ToString(bnum[6]);
            puzzle7.Text = Convert.ToString(bnum[7]);
            puzzle8.Text = Convert.ToString(bnum[8]);
            puzzle9.Text = "";
            pictureBox1.Image = bref[0];
            puzzle1.Image = bref[bnum[1]];
            puzzle2.Image = bref[bnum[2]];
            puzzle3.Image = bref[bnum[3]];
            puzzle4.Image = bref[bnum[4]];
            puzzle5.Image = bref[bnum[5]];
            puzzle6.Image = bref[bnum[6]];
            puzzle7.Image = bref[bnum[7]];
            puzzle8.Image = bref[bnum[8]];
            puzzle9.Image = bref[10];
        }
        private void button1_Click(object sender, EventArgs e)
        {
            select_lv myNewForm = new select_lv(username, ign);
            sys_check = 1;
            this.Close();
            myNewForm.Show();
        }

        private void start_game_Load(object sender, EventArgs e)
        {
            Shuffle();
            timer1.Enabled = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void start_game_FormClosing(object sender, FormClosingEventArgs e)
        {
            Console.Write(sys_check);
            if (e.CloseReason == System.Windows.Forms.CloseReason.UserClosing && start_game.sys_check == 0)
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

        private void button2_Click_1(object sender, EventArgs e)
        {
            puzzle1.Text = Convert.ToString(1);
            puzzle2.Text = Convert.ToString(2);
            puzzle3.Text = Convert.ToString(3);
            puzzle4.Text = Convert.ToString(4);
            puzzle5.Text = Convert.ToString(5);
            puzzle6.Text = Convert.ToString(6);
            puzzle7.Text = Convert.ToString(7);
            puzzle8.Text = Convert.ToString(8);
            puzzle9.Text = "";
            puzzle1.Image = bref[1];
            puzzle2.Image = bref[2];
            puzzle3.Image = bref[3];
            puzzle4.Image = bref[4];
            puzzle5.Image = bref[5];
            puzzle6.Image = bref[6];
            puzzle7.Image = bref[7];
            puzzle8.Image = bref[8];
            puzzle9.Image = bref[9];
            DialogResult sol = MessageBox.Show("This is solution","Cultures Artzle", MessageBoxButtons.OK);
            if(sol == DialogResult.OK)
            {
                Shuffle();
                label2.Text = timer_m.ToString() + ":" + timer_s.ToString();
            }
        }

        private void puzzle1_Click(object sender, EventArgs e)
        {
            movedChecker(puzzle1, puzzle2);
            movedChecker(puzzle1, puzzle4);
            solutionChecker();
        }

        private void puzzle2_Click(object sender, EventArgs e)
        {
            movedChecker(puzzle2, puzzle1);
            movedChecker(puzzle2, puzzle3);
            movedChecker(puzzle2, puzzle5);
            solutionChecker();
        }

        private void puzzle3_Click(object sender, EventArgs e)
        {
            movedChecker(puzzle3, puzzle2);
            movedChecker(puzzle3, puzzle6);
            solutionChecker();
        }

        private void puzzle4_Click(object sender, EventArgs e)
        {
            movedChecker(puzzle4, puzzle1);
            movedChecker(puzzle4, puzzle5);
            movedChecker(puzzle4, puzzle7);
            solutionChecker();
        }

        private void puzzle5_Click(object sender, EventArgs e)
        {
            movedChecker(puzzle5, puzzle2);
            movedChecker(puzzle5, puzzle4);
            movedChecker(puzzle5, puzzle6);
            movedChecker(puzzle5, puzzle8);
            solutionChecker();
        }

        private void puzzle6_Click(object sender, EventArgs e)
        {
            movedChecker(puzzle6, puzzle3);
            movedChecker(puzzle6, puzzle5);
            movedChecker(puzzle6, puzzle9);
            solutionChecker();
        }

        private void puzzle7_Click(object sender, EventArgs e)
        {
            movedChecker(puzzle7, puzzle4);
            movedChecker(puzzle7, puzzle8);
            solutionChecker();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void puzzle8_Click(object sender, EventArgs e)
        {
            movedChecker(puzzle8, puzzle7);
            movedChecker(puzzle8, puzzle5);
            movedChecker(puzzle8, puzzle9);
            solutionChecker();
        }

        private void puzzle9_Click(object sender, EventArgs e)
        {
            movedChecker(puzzle9, puzzle8);
            movedChecker(puzzle9, puzzle6);
            solutionChecker();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Shuffle();
            counter=timer=timer_m=timer_s=0;
            label2.Text = timer_m.ToString() + ":" + timer_s.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer++;
            timer_s++;
            if (timer_s == 60)
            {
                timer_m++;
                timer_s= 0;
            }
            label2.Text = timer_m.ToString() + ":" + timer_s.ToString();
        }
    }
}
