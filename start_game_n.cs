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
    public partial class start_game_n : Form
    {
        private static int sys_check = 0;
        private List<Image> bref = new List<Image>();
        Image im0, im1, im2, im3, im4, im5, im6, im7, im8, im9, im10, im11, im12, im13, im14, im15, im16, im17;
        private static int counter, point;
        private static int timer = 0, timer_s = 0, timer_m = 0;
        public static string username, ign;
        public void movedChecker(Button Butt1, Button Butt2)
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
            if (puzzle1.Text == "1" && puzzle2.Text == "2" && puzzle3.Text == "3" && puzzle4.Text == "4" && puzzle5.Text == "5" && puzzle6.Text == "6" && puzzle7.Text == "7" && puzzle8.Text == "8" && puzzle9.Text == "9" && puzzle10.Text == "10" && puzzle11.Text == "11" && puzzle12.Text == "12" && puzzle13.Text == "13" && puzzle14.Text == "14" && puzzle15.Text == "15" && puzzle16.Text=="")
            {
                MessageBox.Show("Congratulations", "Cultures Artzles", MessageBoxButtons.OK, MessageBoxIcon.Information);
                winner = true;
            }
            if (winner)
            {
                timer1.Enabled = false;
                if (timer < 120 && counter < 100)
                {
                    point = (((120 - timer) * (100 - counter)) * 4)+5000;
                }
                else if (timer < 120)
                {
                    point = ((120 - timer) * 2)+5000;
                }
                else if (counter < 100)
                {
                    point = ((100 - counter) * 2)+5000;
                }
                else
                {
                    point = 5000;
                }
                score myNewForm = new score(username, ign,point);
                sys_check = 1;
                this.Close();
                myNewForm.Show();
            }
        }
        public void Shuffle()
        {
            counter = timer = timer_m = timer_s = 0;
            int[] bnum = new int[16];
            int i, j, rowcheck,pic;
            Boolean flag = false;
            Random r = new Random();
            pic = Convert.ToInt32(r.Next(0,15));
            pic = pic % 2;
            bref.Clear();
            i = 1;
            do
            {
                Random random = new Random();
                rowcheck = Convert.ToInt32((random.Next(0, 15)) + 1);
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
            } while (i <= 15);
            
            if (pic == 0)
            {
                im0 = UI_Design.Properties.Resources._ref;
                im1 = UI_Design.Properties.Resources.loy_01;
                im2 = UI_Design.Properties.Resources.loy_02;
                im3 = UI_Design.Properties.Resources.loy_03;
                im4 = UI_Design.Properties.Resources.loy_04;
                im5 = UI_Design.Properties.Resources.loy_05;
                im6 = UI_Design.Properties.Resources.loy_06;
                im7 = UI_Design.Properties.Resources.loy_07;
                im8 = UI_Design.Properties.Resources.loy_08;
                im9 = UI_Design.Properties.Resources.loy_09;
                im10 = UI_Design.Properties.Resources.loy_10;
                im11 = UI_Design.Properties.Resources.loy_11;
                im12 = UI_Design.Properties.Resources.loy_12;
                im13 = UI_Design.Properties.Resources.loy_13;
                im14 = UI_Design.Properties.Resources.loy_14;
                im15 = UI_Design.Properties.Resources.loy_15;
                im16 = UI_Design.Properties.Resources.loy_16;
            }
            else
            {
                im0 = UI_Design.Properties.Resources.ref_khon;
                im1 = UI_Design.Properties.Resources.Khon_01;
                im2 = UI_Design.Properties.Resources.Khon_02;
                im3 = UI_Design.Properties.Resources.Khon_03;
                im4 = UI_Design.Properties.Resources.Khon_04;
                im5 = UI_Design.Properties.Resources.Khon_05;
                im6 = UI_Design.Properties.Resources.Khon_06;
                im7 = UI_Design.Properties.Resources.Khon_07;
                im8 = UI_Design.Properties.Resources.Khon_08;
                im9 = UI_Design.Properties.Resources.Khon_09;
                im10 = UI_Design.Properties.Resources.Khon_10;
                im11 = UI_Design.Properties.Resources.Khon_11;
                im12 = UI_Design.Properties.Resources.Khon_12;
                im13 = UI_Design.Properties.Resources.Khon_13;
                im14 = UI_Design.Properties.Resources.Khon_14;
                im15 = UI_Design.Properties.Resources.Khon_15;
                im16 = UI_Design.Properties.Resources.Khon_16;
                im17 = UI_Design.Properties.Resources._0;
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
            bref.Add(im11);
            bref.Add(im12);
            bref.Add(im13);
            bref.Add(im14);
            bref.Add(im15);
            bref.Add(im16);
            bref.Add(im17);
            puzzle1.Text = Convert.ToString(bnum[1]);
            puzzle2.Text = Convert.ToString(bnum[2]);
            puzzle3.Text = Convert.ToString(bnum[3]);
            puzzle4.Text = Convert.ToString(bnum[4]);
            puzzle5.Text = Convert.ToString(bnum[5]);
            puzzle6.Text = Convert.ToString(bnum[6]);
            puzzle7.Text = Convert.ToString(bnum[7]);
            puzzle8.Text = Convert.ToString(bnum[8]);
            puzzle9.Text = Convert.ToString(bnum[9]);
            puzzle10.Text = Convert.ToString(bnum[10]);
            puzzle11.Text = Convert.ToString(bnum[11]);
            puzzle12.Text = Convert.ToString(bnum[12]);
            puzzle13.Text = Convert.ToString(bnum[13]);
            puzzle14.Text = Convert.ToString(bnum[14]);
            puzzle15.Text = Convert.ToString(bnum[15]);
            puzzle16.Text = "";
            pictureBox1.Image = bref[0];
            puzzle1.Image = bref[bnum[1]];
            puzzle2.Image = bref[bnum[2]];
            puzzle3.Image = bref[bnum[3]];
            puzzle4.Image = bref[bnum[4]];
            puzzle5.Image = bref[bnum[5]];
            puzzle6.Image = bref[bnum[6]];
            puzzle7.Image = bref[bnum[7]];
            puzzle8.Image = bref[bnum[8]];
            puzzle9.Image = bref[bnum[9]];
            puzzle10.Image = bref[bnum[10]];
            puzzle11.Image = bref[bnum[11]];
            puzzle12.Image = bref[bnum[12]];
            puzzle13.Image = bref[bnum[13]];
            puzzle14.Image = bref[bnum[14]];
            puzzle15.Image = bref[bnum[15]];
            puzzle16.Image = bref[17];
        }
        private void button2_Click(object sender, EventArgs e)
        {
            puzzle1.Text = Convert.ToString(1);
            puzzle2.Text = Convert.ToString(2);
            puzzle3.Text = Convert.ToString(3);
            puzzle4.Text = Convert.ToString(4);
            puzzle5.Text = Convert.ToString(5);
            puzzle6.Text = Convert.ToString(6);
            puzzle7.Text = Convert.ToString(7);
            puzzle8.Text = Convert.ToString(8);
            puzzle9.Text = Convert.ToString(9);
            puzzle10.Text = Convert.ToString(10);
            puzzle11.Text = Convert.ToString(11);
            puzzle12.Text = Convert.ToString(12);
            puzzle13.Text = Convert.ToString(13);
            puzzle14.Text = Convert.ToString(14);
            puzzle15.Text = Convert.ToString(15);
            puzzle16.Text = "";
            puzzle1.Image = bref[1];
            puzzle2.Image = bref[2];
            puzzle3.Image = bref[3];
            puzzle4.Image = bref[4];
            puzzle5.Image = bref[5];
            puzzle6.Image = bref[6];
            puzzle7.Image = bref[7];
            puzzle8.Image = bref[8];
            puzzle9.Image = bref[9];
            puzzle10.Image = bref[10];
            puzzle11.Image = bref[11];
            puzzle12.Image = bref[12];
            puzzle13.Image = bref[13];
            puzzle14.Image = bref[14];
            puzzle15.Image = bref[15];
            puzzle16.Image = bref[16];
            DialogResult sol = MessageBox.Show("This is solution", "Cultures Artzle", MessageBoxButtons.OK);
            if (sol == DialogResult.OK)
            {
                Shuffle();
                label2.Text = timer_m.ToString() + ":" + timer_s.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Shuffle();
            counter = timer = timer_m = timer_s = 0;
            label2.Text = timer_m.ToString() + ":" + timer_s.ToString();
        }

        private void start_game_n_FormClosing(object sender, FormClosingEventArgs e)
        {
            Console.Write(sys_check);
            if (start_game_n.sys_check == 0)
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void puzzle1_Click(object sender, EventArgs e)
        {
            movedChecker(puzzle1, puzzle2);
            movedChecker(puzzle1, puzzle5);
            solutionChecker();
        }

        private void puzzle2_Click(object sender, EventArgs e)
        {
            movedChecker(puzzle2, puzzle1);
            movedChecker(puzzle2, puzzle3);
            movedChecker(puzzle2, puzzle6);
            solutionChecker();
        }

        private void puzzle3_Click(object sender, EventArgs e)
        {
            movedChecker(puzzle3, puzzle2);
            movedChecker(puzzle3, puzzle4);
            movedChecker(puzzle3, puzzle7);
            solutionChecker();
        }

        private void puzzle4_Click(object sender, EventArgs e)
        {
            movedChecker(puzzle4, puzzle8);
            movedChecker(puzzle4, puzzle3);
            solutionChecker();
        }

        private void puzzle5_Click(object sender, EventArgs e)
        {
            movedChecker(puzzle5, puzzle1);
            movedChecker(puzzle5, puzzle6);
            movedChecker(puzzle5, puzzle9);
            solutionChecker();
        }

        private void puzzle6_Click(object sender, EventArgs e)
        {
            movedChecker(puzzle6, puzzle2);
            movedChecker(puzzle6, puzzle5);
            movedChecker(puzzle6, puzzle7);
            movedChecker(puzzle6, puzzle10);
            solutionChecker();
        }

        private void puzzle7_Click(object sender, EventArgs e)
        {
            movedChecker(puzzle7, puzzle8);
            movedChecker(puzzle7, puzzle3);
            movedChecker(puzzle7, puzzle6);
            movedChecker(puzzle7, puzzle11);
            solutionChecker();
        }

        private void puzzle8_Click(object sender, EventArgs e)
        {
            movedChecker(puzzle8, puzzle4);
            movedChecker(puzzle8, puzzle7);
            movedChecker(puzzle8, puzzle12);
            solutionChecker();
        }

        private void puzzle9_Click(object sender, EventArgs e)
        {
            movedChecker(puzzle9, puzzle5);
            movedChecker(puzzle9, puzzle10);
            movedChecker(puzzle9, puzzle13);
            solutionChecker();
        }

        private void puzzle10_Click(object sender, EventArgs e)
        {
            movedChecker(puzzle10, puzzle9);
            movedChecker(puzzle10, puzzle11);
            movedChecker(puzzle10, puzzle6);
            movedChecker(puzzle10, puzzle14);
            solutionChecker();
        }

        private void puzzle11_Click(object sender, EventArgs e)
        {

            movedChecker(puzzle11, puzzle7);
            movedChecker(puzzle11, puzzle10);
            movedChecker(puzzle11, puzzle12);
            movedChecker(puzzle11, puzzle15);
            solutionChecker();
        }

        private void puzzle12_Click(object sender, EventArgs e)
        {
            movedChecker(puzzle12, puzzle8);
            movedChecker(puzzle12, puzzle11);
            movedChecker(puzzle12, puzzle16);
            solutionChecker();
        }

        private void puzzle13_Click(object sender, EventArgs e)
        {
            movedChecker(puzzle13, puzzle9);
            movedChecker(puzzle13, puzzle14);
            solutionChecker();
        }

        private void puzzle14_Click(object sender, EventArgs e)
        {
            movedChecker(puzzle14, puzzle10);
            movedChecker(puzzle14, puzzle13);
            movedChecker(puzzle14, puzzle15);
            solutionChecker();
        }

        private void puzzle15_Click(object sender, EventArgs e)
        {
            movedChecker(puzzle15, puzzle16);
            movedChecker(puzzle15, puzzle11);
            movedChecker(puzzle15, puzzle14);
            solutionChecker();
        }

        private void puzzle16_Click(object sender, EventArgs e)
        {
            movedChecker(puzzle16, puzzle12);
            movedChecker(puzzle16, puzzle15);
            solutionChecker();
        }



        private void timer1_Tick_1(object sender, EventArgs e)
        {
            timer++;
            timer_s++;
            if (timer_s == 60)
            {
                timer_m++;
                timer_s = 0;
            }
            label2.Text = timer_m.ToString() + ":" + timer_s.ToString();
        }

        public start_game_n(string username, string ign)
        {
            start_game_n.username = username;
            start_game_n.ign = ign;
            InitializeComponent();
            sys_check = 0;
            counter = timer = timer_m = timer_s = 0;
            label2.Text = timer_m.ToString() + ":" + timer_s.ToString();
        }

        private void start_game_n_Load(object sender, EventArgs e)
        {
            Shuffle();
            timer1.Enabled = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            select_lv myNewForm = new select_lv(username, ign);
            sys_check = 1;
            this.Close();
            myNewForm.Show();
        }
    }
}
