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
    public partial class start_game_h : Form
    {   
        private static int counter, point;
        private static int timer = 0, timer_s = 0, timer_m = 0;
        private static int sys_check = 0;
        public static string username, ign;
        private List<Image> bref = new List<Image>();
        Image im0, im1, im2, im3, im4, im5, im6, im7, im8, im9, im10, im11, im12, im13, im14, im15, im16, im17, im18, im19, im20, im21, im22, im23, im24, im25,im26;

        private void puzzle16_Click(object sender, EventArgs e)
        {
            movedChecker(puzzle16, puzzle11);
            movedChecker(puzzle16, puzzle17);
            movedChecker(puzzle16, puzzle21);
            solutionChecker();
        }

        private void puzzle17_Click(object sender, EventArgs e)
        {
            movedChecker(puzzle17, puzzle22);
            movedChecker(puzzle17, puzzle16);
            movedChecker(puzzle17, puzzle18);
            movedChecker(puzzle17, puzzle12);
            solutionChecker();
        }

        private void puzzle18_Click(object sender, EventArgs e)
        {
            movedChecker(puzzle18, puzzle13);
            movedChecker(puzzle18, puzzle17);
            movedChecker(puzzle18, puzzle19);
            movedChecker(puzzle18, puzzle23);
            solutionChecker();
        }

        private void puzzle19_Click(object sender, EventArgs e)
        {
            movedChecker(puzzle19, puzzle14);
            movedChecker(puzzle19, puzzle18);
            movedChecker(puzzle19, puzzle20);
            movedChecker(puzzle19, puzzle24);
            solutionChecker();
        }

        private void timer1_Tick(object sender, EventArgs e)
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

        private void puzzle20_Click(object sender, EventArgs e)
        {
            movedChecker(puzzle20, puzzle15);
            movedChecker(puzzle20, puzzle25);
            movedChecker(puzzle20, puzzle19);
            solutionChecker();
        }

        private void puzzle21_Click(object sender, EventArgs e)
        {
            movedChecker(puzzle21, puzzle16);
            movedChecker(puzzle21, puzzle22);
            solutionChecker();
        }

        private void puzzle22_Click(object sender, EventArgs e)
        {
            movedChecker(puzzle22, puzzle21);
            movedChecker(puzzle22, puzzle17);
            movedChecker(puzzle22, puzzle23);
            solutionChecker();
        }

        private void puzzle23_Click(object sender, EventArgs e)
        {
            movedChecker(puzzle23, puzzle18);
            movedChecker(puzzle23, puzzle22);
            movedChecker(puzzle23, puzzle24);
            solutionChecker();
        }

        private void puzzle24_Click(object sender, EventArgs e)
        {
            movedChecker(puzzle24, puzzle23);
            movedChecker(puzzle24, puzzle25);
            movedChecker(puzzle24, puzzle19);
            solutionChecker();
        }

        private void puzzle25_Click(object sender, EventArgs e)
        {
            movedChecker(puzzle25, puzzle20);
            movedChecker(puzzle25, puzzle24);
            solutionChecker();
        }

        private void puzzle15_Click(object sender, EventArgs e)
        {
            movedChecker(puzzle15, puzzle10);
            movedChecker(puzzle15, puzzle14);
            movedChecker(puzzle15, puzzle20);
            solutionChecker();
        }

        private void puzzle14_Click(object sender, EventArgs e)
        {
            movedChecker(puzzle14, puzzle9);
            movedChecker(puzzle14, puzzle13);
            movedChecker(puzzle14, puzzle15);
            movedChecker(puzzle14, puzzle19);
            solutionChecker();
        }

        private void puzzle13_Click(object sender, EventArgs e)
        {
            movedChecker(puzzle13, puzzle14);
            movedChecker(puzzle13, puzzle18);
            movedChecker(puzzle13, puzzle8);
            movedChecker(puzzle13, puzzle12);
            solutionChecker();
        }

        private void puzzle12_Click(object sender, EventArgs e)
        {
            movedChecker(puzzle12, puzzle7);
            movedChecker(puzzle12, puzzle11);
            movedChecker(puzzle12, puzzle13);
            movedChecker(puzzle12, puzzle17);
            solutionChecker();
        }

        private void puzzle11_Click(object sender, EventArgs e)
        {
            movedChecker(puzzle11, puzzle16);
            movedChecker(puzzle11, puzzle6);
            movedChecker(puzzle11, puzzle12);
            solutionChecker();
        }

        private void puzzle10_Click(object sender, EventArgs e)
        {
            movedChecker(puzzle10, puzzle5);
            movedChecker(puzzle10, puzzle9);
            movedChecker(puzzle10, puzzle15);
            solutionChecker();
        }

        private void puzzle9_Click(object sender, EventArgs e)
        {
            movedChecker(puzzle9, puzzle4);
            movedChecker(puzzle9, puzzle8);
            movedChecker(puzzle9, puzzle10);
            movedChecker(puzzle9, puzzle14);
            solutionChecker();
        }

        private void puzzle8_Click(object sender, EventArgs e)
        {
            movedChecker(puzzle8, puzzle2);
            movedChecker(puzzle8, puzzle6);
            movedChecker(puzzle8, puzzle8);
            movedChecker(puzzle8, puzzle12);
            solutionChecker();
        }

        private void puzzle7_Click(object sender, EventArgs e)
        {
            movedChecker(puzzle7, puzzle2);
            movedChecker(puzzle7, puzzle6);
            movedChecker(puzzle7, puzzle8);
            movedChecker(puzzle7, puzzle12);
            solutionChecker();
        }

        private void puzzle6_Click(object sender, EventArgs e)
        {
            movedChecker(puzzle6, puzzle1);
            movedChecker(puzzle6, puzzle7);
            movedChecker(puzzle6, puzzle11);
            solutionChecker();
        }

        private void puzzle5_Click(object sender, EventArgs e)
        {
            movedChecker(puzzle5, puzzle4);
            movedChecker(puzzle5, puzzle10);
            solutionChecker();
        }

        private void puzzle4_Click(object sender, EventArgs e)
        {
            movedChecker(puzzle4, puzzle3);
            movedChecker(puzzle4, puzzle5);
            movedChecker(puzzle4, puzzle9);
            solutionChecker();
        }

        private void puzzle3_Click(object sender, EventArgs e)
        {
            movedChecker(puzzle3, puzzle2);
            movedChecker(puzzle3, puzzle4);
            movedChecker(puzzle3, puzzle8);
            solutionChecker();
        }

        private void puzzle2_Click(object sender, EventArgs e)
        {
            movedChecker(puzzle2, puzzle1);
            movedChecker(puzzle2, puzzle3);
            movedChecker(puzzle2, puzzle7);
            solutionChecker();
        }

        private void puzzle1_Click(object sender, EventArgs e)
        {
            movedChecker(puzzle1, puzzle2);
            movedChecker(puzzle1, puzzle6);
            solutionChecker();
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
            puzzle16.Text = Convert.ToString(16);
            puzzle17.Text = Convert.ToString(17);
            puzzle18.Text = Convert.ToString(18);
            puzzle19.Text = Convert.ToString(19);
            puzzle20.Text = Convert.ToString(20);
            puzzle21.Text = Convert.ToString(21);
            puzzle22.Text = Convert.ToString(22);
            puzzle23.Text = Convert.ToString(23);
            puzzle24.Text = Convert.ToString(24);
            puzzle25.Text = Convert.ToString(25);
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
            puzzle17.Image = bref[17];
            puzzle18.Image = bref[18];
            puzzle19.Image = bref[19];
            puzzle20.Image = bref[20];
            puzzle21.Image = bref[21];
            puzzle22.Image = bref[22];
            puzzle23.Image = bref[23];
            puzzle24.Image = bref[24];
            puzzle25.Image = bref[25];
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
            if (puzzle1.Text == "1" && puzzle2.Text == "2" && puzzle3.Text == "3" && puzzle4.Text == "4" && puzzle5.Text == "5" && puzzle6.Text == "6" && puzzle7.Text == "7" && puzzle8.Text == "8" && puzzle9.Text == "9" && puzzle10.Text == "10" && puzzle11.Text == "11" && puzzle12.Text == "12" && puzzle13.Text == "13" && puzzle14.Text == "14" && puzzle15.Text == "15" && puzzle16.Text == "16" && puzzle17.Text == "17" && puzzle18.Text == "18" && puzzle19.Text == "19" && puzzle20.Text == "20" && puzzle21.Text == "21" && puzzle22.Text == "22" && puzzle23.Text == "23" && puzzle24.Text == "24" && puzzle25.Text == "")
            {
                MessageBox.Show("Congratulations", "Cultures Artzles", MessageBoxButtons.OK, MessageBoxIcon.Information);
                winner = true;
            }
            if (winner)
            {
                timer1.Enabled = false;
                if (timer < 180 && counter < 200)
                {
                    point = (((180 - timer) * (200 - counter)) * 9)+10000;
                }
                else if (timer < 180)
                {
                    point = ((180 - timer) * 3)+10000;
                }
                else if (counter < 200)
                {
                    point = ((200 - counter) * 3)+10000;
                }
                else
                {
                    point = 10000;
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
            int[] bnum = new int[25];
            int i, j, rowcheck, pic;
            Boolean flag = false;
            Random r = new Random();
            pic = Convert.ToInt32(r.Next(0, 24));
            pic = pic % 2;
            bref.Clear();
            i = 1;
            do
            {
                Random random = new Random();
                rowcheck = Convert.ToInt32((random.Next(0, 24)) + 1);
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
            } while (i <= 24);

            if (pic == 0)
            {
                im0 = UI_Design.Properties.Resources.ref_food;
                im1 = UI_Design.Properties.Resources.food_01;
                im2 = UI_Design.Properties.Resources.food_02;
                im3 = UI_Design.Properties.Resources.food_03;
                im4 = UI_Design.Properties.Resources.food_04;
                im5 = UI_Design.Properties.Resources.food_05;
                im6 = UI_Design.Properties.Resources.food_06;
                im7 = UI_Design.Properties.Resources.food_07;
                im8 = UI_Design.Properties.Resources.food_08;
                im9 = UI_Design.Properties.Resources.food_09;
                im10 = UI_Design.Properties.Resources.food_10;
                im11 = UI_Design.Properties.Resources.food_11;
                im12 = UI_Design.Properties.Resources.food_12;
                im13 = UI_Design.Properties.Resources.food_13;
                im14 = UI_Design.Properties.Resources.food_14;
                im15 = UI_Design.Properties.Resources.food_15;
                im16 = UI_Design.Properties.Resources.food_16;
                im17 = UI_Design.Properties.Resources.food_17;
                im18 = UI_Design.Properties.Resources.food_18;
                im19 = UI_Design.Properties.Resources.food_19;
                im20 = UI_Design.Properties.Resources.food_20;
                im21 = UI_Design.Properties.Resources.food_21;
                im22 = UI_Design.Properties.Resources.food_22;
                im23 = UI_Design.Properties.Resources.food_23;
                im24 = UI_Design.Properties.Resources.food_24;
                im25 = UI_Design.Properties.Resources.food_25;
                im26 = UI_Design.Properties.Resources._0;
            }
            else
            {
                im0 = UI_Design.Properties.Resources.ref_Chome;
                im1 = UI_Design.Properties.Resources.Chome_01;
                im2 = UI_Design.Properties.Resources.Chome_02;
                im3 = UI_Design.Properties.Resources.Chome_03;
                im4 = UI_Design.Properties.Resources.Chome_04;
                im5 = UI_Design.Properties.Resources.Chome_05;
                im6 = UI_Design.Properties.Resources.Chome_06;
                im7 = UI_Design.Properties.Resources.Chome_07;
                im8 = UI_Design.Properties.Resources.Chome_08;
                im9 = UI_Design.Properties.Resources.Chome_09;
                im10 = UI_Design.Properties.Resources.Chome_10;
                im11 = UI_Design.Properties.Resources.Chome_11;
                im12 = UI_Design.Properties.Resources.Chome_12;
                im13 = UI_Design.Properties.Resources.Chome_13;
                im14 = UI_Design.Properties.Resources.Chome_14;
                im15 = UI_Design.Properties.Resources.Chome_15;
                im16 = UI_Design.Properties.Resources.Chome_16;
                im17 = UI_Design.Properties.Resources.Chome_17;
                im18 = UI_Design.Properties.Resources.Chome_18;
                im19 = UI_Design.Properties.Resources.Chome_19;
                im20 = UI_Design.Properties.Resources.Chome_20;
                im21 = UI_Design.Properties.Resources.Chome_21;
                im22 = UI_Design.Properties.Resources.Chome_22;
                im23 = UI_Design.Properties.Resources.Chome_23;
                im24 = UI_Design.Properties.Resources.Chome_24;
                im25 = UI_Design.Properties.Resources.Chome_25;
                im26 = UI_Design.Properties.Resources._0;
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
            bref.Add(im18);
            bref.Add(im19);
            bref.Add(im20);
            bref.Add(im21);
            bref.Add(im22);
            bref.Add(im23);
            bref.Add(im24);
            bref.Add(im25);
            bref.Add(im26);
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
            puzzle16.Text = Convert.ToString(bnum[16]);
            puzzle17.Text = Convert.ToString(bnum[17]);
            puzzle18.Text = Convert.ToString(bnum[18]);
            puzzle19.Text = Convert.ToString(bnum[19]);
            puzzle20.Text = Convert.ToString(bnum[20]);
            puzzle21.Text = Convert.ToString(bnum[21]);
            puzzle22.Text = Convert.ToString(bnum[22]);
            puzzle23.Text = Convert.ToString(bnum[23]);
            puzzle24.Text = Convert.ToString(bnum[24]);
            puzzle25.Text = "";
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
            puzzle16.Image = bref[bnum[16]];
            puzzle17.Image = bref[bnum[17]];
            puzzle18.Image = bref[bnum[18]];
            puzzle19.Image = bref[bnum[19]];
            puzzle20.Image = bref[bnum[20]];
            puzzle21.Image = bref[bnum[21]];
            puzzle22.Image = bref[bnum[22]];
            puzzle23.Image = bref[bnum[23]];
            puzzle24.Image = bref[bnum[24]];
            puzzle25.Image = bref[26];
        }
        private void button1_Click(object sender, EventArgs e)
        {
            select_lv myNewForm = new select_lv(username, ign);
            sys_check = 1;
            this.Close();
            myNewForm.Show();
        }

        public start_game_h(string username, string ign)
        {
            start_game_h.username = username;
            start_game_h.ign = ign;
            InitializeComponent();
            sys_check = 0;
            counter = timer = timer_m = timer_s = 0;
            label2.Text = timer_m.ToString() + ":" + timer_s.ToString();
        }

        private void start_game_h_Load(object sender, EventArgs e)
        {
            Shuffle();
            timer1.Enabled=true;
        }

        private void start_game_h_FormClosing(object sender, FormClosingEventArgs e)
        {
            Console.Write(sys_check);
            if (start_game_h.sys_check == 0)
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
