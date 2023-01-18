namespace CulturesArtzle
{
    partial class start_game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.puzzle9 = new System.Windows.Forms.Button();
            this.puzzle8 = new System.Windows.Forms.Button();
            this.puzzle7 = new System.Windows.Forms.Button();
            this.puzzle6 = new System.Windows.Forms.Button();
            this.puzzle5 = new System.Windows.Forms.Button();
            this.puzzle4 = new System.Windows.Forms.Button();
            this.puzzle3 = new System.Windows.Forms.Button();
            this.puzzle2 = new System.Windows.Forms.Button();
            this.puzzle1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(401, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 106);
            this.label1.TabIndex = 9;
            this.label1.Text = "Time ";
            this.label1.UseWaitCursor = true;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(33, 647);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 57);
            this.button1.TabIndex = 10;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.UseWaitCursor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1214, 647);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 57);
            this.button2.TabIndex = 11;
            this.button2.Text = "Solution";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.UseWaitCursor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(1214, 566);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(131, 57);
            this.button3.TabIndex = 22;
            this.button3.Text = "Restart";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.UseWaitCursor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(693, -1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 106);
            this.label2.TabIndex = 23;
            this.label2.Text = "timer";
            this.label2.UseWaitCursor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(72, 120);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 195);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            // 
            // puzzle9
            // 
            this.puzzle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.puzzle9.Image = global::UI_Design.Properties.Resources._0;
            this.puzzle9.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.puzzle9.Location = new System.Drawing.Point(809, 448);
            this.puzzle9.Name = "puzzle9";
            this.puzzle9.Size = new System.Drawing.Size(147, 124);
            this.puzzle9.TabIndex = 20;
            this.puzzle9.Text = "9";
            this.puzzle9.UseVisualStyleBackColor = true;
            this.puzzle9.UseWaitCursor = true;
            this.puzzle9.Click += new System.EventHandler(this.puzzle9_Click);
            // 
            // puzzle8
            // 
            this.puzzle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.puzzle8.Image = global::UI_Design.Properties.Resources._8;
            this.puzzle8.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.puzzle8.Location = new System.Drawing.Point(611, 448);
            this.puzzle8.Name = "puzzle8";
            this.puzzle8.Size = new System.Drawing.Size(147, 124);
            this.puzzle8.TabIndex = 19;
            this.puzzle8.Text = "8";
            this.puzzle8.UseVisualStyleBackColor = true;
            this.puzzle8.UseWaitCursor = true;
            this.puzzle8.Click += new System.EventHandler(this.puzzle8_Click);
            // 
            // puzzle7
            // 
            this.puzzle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.puzzle7.Image = global::UI_Design.Properties.Resources._7;
            this.puzzle7.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.puzzle7.Location = new System.Drawing.Point(419, 448);
            this.puzzle7.Name = "puzzle7";
            this.puzzle7.Size = new System.Drawing.Size(147, 124);
            this.puzzle7.TabIndex = 18;
            this.puzzle7.Text = "7";
            this.puzzle7.UseVisualStyleBackColor = true;
            this.puzzle7.UseWaitCursor = true;
            this.puzzle7.Click += new System.EventHandler(this.puzzle7_Click);
            // 
            // puzzle6
            // 
            this.puzzle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.puzzle6.Image = global::UI_Design.Properties.Resources._6;
            this.puzzle6.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.puzzle6.Location = new System.Drawing.Point(809, 287);
            this.puzzle6.Name = "puzzle6";
            this.puzzle6.Size = new System.Drawing.Size(147, 124);
            this.puzzle6.TabIndex = 17;
            this.puzzle6.Text = "6";
            this.puzzle6.UseVisualStyleBackColor = true;
            this.puzzle6.UseWaitCursor = true;
            this.puzzle6.Click += new System.EventHandler(this.puzzle6_Click);
            // 
            // puzzle5
            // 
            this.puzzle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.puzzle5.Image = global::UI_Design.Properties.Resources._5;
            this.puzzle5.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.puzzle5.Location = new System.Drawing.Point(611, 287);
            this.puzzle5.Name = "puzzle5";
            this.puzzle5.Size = new System.Drawing.Size(147, 124);
            this.puzzle5.TabIndex = 16;
            this.puzzle5.Text = "5";
            this.puzzle5.UseVisualStyleBackColor = true;
            this.puzzle5.UseWaitCursor = true;
            this.puzzle5.Click += new System.EventHandler(this.puzzle5_Click);
            // 
            // puzzle4
            // 
            this.puzzle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.puzzle4.Image = global::UI_Design.Properties.Resources._4;
            this.puzzle4.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.puzzle4.Location = new System.Drawing.Point(419, 287);
            this.puzzle4.Name = "puzzle4";
            this.puzzle4.Size = new System.Drawing.Size(147, 124);
            this.puzzle4.TabIndex = 15;
            this.puzzle4.Text = "4";
            this.puzzle4.UseVisualStyleBackColor = true;
            this.puzzle4.UseWaitCursor = true;
            this.puzzle4.Click += new System.EventHandler(this.puzzle4_Click);
            // 
            // puzzle3
            // 
            this.puzzle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.puzzle3.Image = global::UI_Design.Properties.Resources._3;
            this.puzzle3.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.puzzle3.Location = new System.Drawing.Point(809, 120);
            this.puzzle3.Name = "puzzle3";
            this.puzzle3.Size = new System.Drawing.Size(147, 124);
            this.puzzle3.TabIndex = 14;
            this.puzzle3.Text = "3";
            this.puzzle3.UseVisualStyleBackColor = true;
            this.puzzle3.UseWaitCursor = true;
            this.puzzle3.Click += new System.EventHandler(this.puzzle3_Click);
            // 
            // puzzle2
            // 
            this.puzzle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.puzzle2.Image = global::UI_Design.Properties.Resources._2;
            this.puzzle2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.puzzle2.Location = new System.Drawing.Point(611, 120);
            this.puzzle2.Name = "puzzle2";
            this.puzzle2.Size = new System.Drawing.Size(147, 124);
            this.puzzle2.TabIndex = 13;
            this.puzzle2.Text = "2";
            this.puzzle2.UseVisualStyleBackColor = true;
            this.puzzle2.UseWaitCursor = true;
            this.puzzle2.Click += new System.EventHandler(this.puzzle2_Click);
            // 
            // puzzle1
            // 
            this.puzzle1.BackColor = System.Drawing.SystemColors.Control;
            this.puzzle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 1E-05F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(222)));
            this.puzzle1.Image = global::UI_Design.Properties.Resources._1;
            this.puzzle1.Location = new System.Drawing.Point(419, 120);
            this.puzzle1.Name = "puzzle1";
            this.puzzle1.Size = new System.Drawing.Size(147, 124);
            this.puzzle1.TabIndex = 12;
            this.puzzle1.Text = "1";
            this.puzzle1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.puzzle1.UseVisualStyleBackColor = false;
            this.puzzle1.UseWaitCursor = true;
            this.puzzle1.Click += new System.EventHandler(this.puzzle1_Click);
            // 
            // start_game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1396, 730);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.puzzle9);
            this.Controls.Add(this.puzzle8);
            this.Controls.Add(this.puzzle7);
            this.Controls.Add(this.puzzle6);
            this.Controls.Add(this.puzzle5);
            this.Controls.Add(this.puzzle4);
            this.Controls.Add(this.puzzle3);
            this.Controls.Add(this.puzzle2);
            this.Controls.Add(this.puzzle1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "start_game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cultures Artzle";
            this.UseWaitCursor = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.start_game_FormClosing);
            this.Load += new System.EventHandler(this.start_game_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button puzzle1;
        private System.Windows.Forms.Button puzzle2;
        private System.Windows.Forms.Button puzzle3;
        private System.Windows.Forms.Button puzzle4;
        private System.Windows.Forms.Button puzzle5;
        private System.Windows.Forms.Button puzzle6;
        private System.Windows.Forms.Button puzzle7;
        private System.Windows.Forms.Button puzzle8;
        private System.Windows.Forms.Button puzzle9;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}