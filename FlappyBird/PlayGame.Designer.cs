namespace FlappyBird
{
    partial class PlayGame
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayGame));
            pipedown = new PictureBox();
            pipeup = new PictureBox();
            Bird = new PictureBox();
            ground1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            Score_txt = new Label();
            gameover = new PictureBox();
            press = new Label();
            PlayAgain = new Label();
            sun = new PictureBox();
            groupofbirds = new PictureBox();
            cloud1 = new PictureBox();
            cloud2 = new PictureBox();
            cloud3 = new PictureBox();
            cloud4 = new PictureBox();
            cloud5 = new PictureBox();
            cloud6 = new PictureBox();
            Note_Panel = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            Back_label = new Label();
            ((System.ComponentModel.ISupportInitialize)pipedown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipeup).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Bird).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ground1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gameover).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sun).BeginInit();
            ((System.ComponentModel.ISupportInitialize)groupofbirds).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cloud1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cloud2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cloud3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cloud4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cloud5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cloud6).BeginInit();
            Note_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pipedown
            // 
            pipedown.Image = Properties.Resources.anbob;
            pipedown.Location = new Point(542, 284);
            pipedown.Name = "pipedown";
            pipedown.Size = new Size(60, 175);
            pipedown.SizeMode = PictureBoxSizeMode.StretchImage;
            pipedown.TabIndex = 0;
            pipedown.TabStop = false;
            // 
            // pipeup
            // 
            pipeup.Image = Properties.Resources._2;
            pipeup.Location = new Point(666, -10);
            pipeup.Name = "pipeup";
            pipeup.Size = new Size(61, 182);
            pipeup.SizeMode = PictureBoxSizeMode.StretchImage;
            pipeup.TabIndex = 1;
            pipeup.TabStop = false;
            // 
            // Bird
            // 
            Bird.BackColor = Color.Transparent;
            Bird.Image = (Image)resources.GetObject("Bird.Image");
            Bird.Location = new Point(130, 200);
            Bird.Name = "Bird";
            Bird.Size = new Size(51, 52);
            Bird.SizeMode = PictureBoxSizeMode.StretchImage;
            Bird.TabIndex = 2;
            Bird.TabStop = false;
            Bird.BackgroundImageChanged += Bird_BackgroundImageChanged;
            Bird.Click += Bird_Click;
            // 
            // ground1
            // 
            ground1.Image = Properties.Resources.ground2;
            ground1.Location = new Point(0, 450);
            ground1.Name = "ground1";
            ground1.Size = new Size(1001, 113);
            ground1.SizeMode = PictureBoxSizeMode.StretchImage;
            ground1.TabIndex = 3;
            ground1.TabStop = false;
            // 
            // timer1
            // 
            timer1.Interval = 15;
            timer1.Tick += timer1_Tick;
            // 
            // Score_txt
            // 
            Score_txt.AutoSize = true;
            Score_txt.BackColor = Color.PaleGoldenrod;
            Score_txt.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Score_txt.Location = new Point(426, 491);
            Score_txt.Name = "Score_txt";
            Score_txt.Size = new Size(108, 31);
            Score_txt.TabIndex = 4;
            Score_txt.Text = "Score : 0";
            // 
            // gameover
            // 
            gameover.BackColor = Color.Transparent;
            gameover.Image = Properties.Resources.game_over_PNG55;
            gameover.Location = new Point(278, 120);
            gameover.Name = "gameover";
            gameover.Size = new Size(431, 158);
            gameover.SizeMode = PictureBoxSizeMode.StretchImage;
            gameover.TabIndex = 6;
            gameover.TabStop = false;
            gameover.Visible = false;
            gameover.Click += pictureBox2_Click;
            // 
            // press
            // 
            press.AutoSize = true;
            press.BackColor = Color.PaleGoldenrod;
            press.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point);
            press.Location = new Point(383, 366);
            press.Name = "press";
            press.Size = new Size(304, 27);
            press.TabIndex = 8;
            press.Text = "press (enter) to start game >>";
            // 
            // PlayAgain
            // 
            PlayAgain.AutoSize = true;
            PlayAgain.BackColor = Color.PaleGoldenrod;
            PlayAgain.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point);
            PlayAgain.Location = new Point(383, 316);
            PlayAgain.Name = "PlayAgain";
            PlayAgain.Size = new Size(304, 27);
            PlayAgain.TabIndex = 9;
            PlayAgain.Text = "press (Space) to Play Again>>";
            PlayAgain.Visible = false;
            // 
            // sun
            // 
            sun.Image = Properties.Resources.sun;
            sun.Location = new Point(-16, -15);
            sun.Name = "sun";
            sun.Size = new Size(187, 173);
            sun.SizeMode = PictureBoxSizeMode.StretchImage;
            sun.TabIndex = 10;
            sun.TabStop = false;
            // 
            // groupofbirds
            // 
            groupofbirds.Image = Properties.Resources.birds;
            groupofbirds.Location = new Point(876, 12);
            groupofbirds.Name = "groupofbirds";
            groupofbirds.Size = new Size(142, 103);
            groupofbirds.SizeMode = PictureBoxSizeMode.StretchImage;
            groupofbirds.TabIndex = 11;
            groupofbirds.TabStop = false;
            // 
            // cloud1
            // 
            cloud1.Image = Properties.Resources.cloud;
            cloud1.Location = new Point(239, -35);
            cloud1.Name = "cloud1";
            cloud1.Size = new Size(152, 90);
            cloud1.SizeMode = PictureBoxSizeMode.StretchImage;
            cloud1.TabIndex = 12;
            cloud1.TabStop = false;
            // 
            // cloud2
            // 
            cloud2.Image = Properties.Resources.cloud;
            cloud2.Location = new Point(130, 12);
            cloud2.Name = "cloud2";
            cloud2.Size = new Size(92, 63);
            cloud2.SizeMode = PictureBoxSizeMode.StretchImage;
            cloud2.TabIndex = 13;
            cloud2.TabStop = false;
            // 
            // cloud3
            // 
            cloud3.Image = Properties.Resources.cloud;
            cloud3.Location = new Point(727, -7);
            cloud3.Name = "cloud3";
            cloud3.Size = new Size(125, 71);
            cloud3.SizeMode = PictureBoxSizeMode.StretchImage;
            cloud3.TabIndex = 14;
            cloud3.TabStop = false;
            // 
            // cloud4
            // 
            cloud4.Image = Properties.Resources.cloud;
            cloud4.Location = new Point(397, -7);
            cloud4.Name = "cloud4";
            cloud4.Size = new Size(152, 90);
            cloud4.SizeMode = PictureBoxSizeMode.StretchImage;
            cloud4.TabIndex = 15;
            cloud4.TabStop = false;
            // 
            // cloud5
            // 
            cloud5.Image = Properties.Resources.cloud;
            cloud5.Location = new Point(600, 24);
            cloud5.Name = "cloud5";
            cloud5.Size = new Size(127, 77);
            cloud5.SizeMode = PictureBoxSizeMode.StretchImage;
            cloud5.TabIndex = 16;
            cloud5.TabStop = false;
            // 
            // cloud6
            // 
            cloud6.Image = Properties.Resources.cloud;
            cloud6.Location = new Point(858, 30);
            cloud6.Name = "cloud6";
            cloud6.Size = new Size(125, 71);
            cloud6.SizeMode = PictureBoxSizeMode.StretchImage;
            cloud6.TabIndex = 17;
            cloud6.TabStop = false;
            // 
            // Note_Panel
            // 
            Note_Panel.BackColor = SystemColors.ButtonHighlight;
            Note_Panel.Controls.Add(label1);
            Note_Panel.Controls.Add(pictureBox1);
            Note_Panel.Location = new Point(748, 200);
            Note_Panel.Name = "Note_Panel";
            Note_Panel.Size = new Size(222, 143);
            Note_Panel.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 115);
            label1.Name = "label1";
            label1.Size = new Size(150, 20);
            label1.TabIndex = 1;
            label1.Text = "Use KeyUp To Go Up \r\n";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Arrow_keys_UP_DOWN;
            pictureBox1.Location = new Point(54, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(114, 109);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Back_label
            // 
            Back_label.AutoSize = true;
            Back_label.BackColor = Color.PaleGoldenrod;
            Back_label.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Back_label.Location = new Point(368, 420);
            Back_label.Name = "Back_label";
            Back_label.Size = new Size(330, 27);
            Back_label.TabIndex = 19;
            Back_label.Text = "press (B) To Go To Start Page >>";
            // 
            // PlayGame
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 553);
            Controls.Add(Back_label);
            Controls.Add(Note_Panel);
            Controls.Add(Bird);
            Controls.Add(sun);
            Controls.Add(PlayAgain);
            Controls.Add(press);
            Controls.Add(gameover);
            Controls.Add(Score_txt);
            Controls.Add(pipeup);
            Controls.Add(pipedown);
            Controls.Add(cloud1);
            Controls.Add(cloud2);
            Controls.Add(groupofbirds);
            Controls.Add(cloud3);
            Controls.Add(cloud5);
            Controls.Add(cloud4);
            Controls.Add(cloud6);
            Controls.Add(ground1);
            Name = "PlayGame";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            KeyDown += Form1_KeyDown;
            KeyUp += Form1_KeyUp;
            ((System.ComponentModel.ISupportInitialize)pipedown).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipeup).EndInit();
            ((System.ComponentModel.ISupportInitialize)Bird).EndInit();
            ((System.ComponentModel.ISupportInitialize)ground1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gameover).EndInit();
            ((System.ComponentModel.ISupportInitialize)sun).EndInit();
            ((System.ComponentModel.ISupportInitialize)groupofbirds).EndInit();
            ((System.ComponentModel.ISupportInitialize)cloud1).EndInit();
            ((System.ComponentModel.ISupportInitialize)cloud2).EndInit();
            ((System.ComponentModel.ISupportInitialize)cloud3).EndInit();
            ((System.ComponentModel.ISupportInitialize)cloud4).EndInit();
            ((System.ComponentModel.ISupportInitialize)cloud5).EndInit();
            ((System.ComponentModel.ISupportInitialize)cloud6).EndInit();
            Note_Panel.ResumeLayout(false);
            Note_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pipedown;
        private PictureBox pipeup;
        private PictureBox ground1;
        private System.Windows.Forms.Timer timer1;
        private Label Score_txt;
        private PictureBox gameover;
        public PictureBox Bird;
        private Label press;
        private Label PlayAgain;
        private PictureBox sun;
        private PictureBox groupofbirds;
        private PictureBox cloud1;
        private PictureBox cloud2;
        private PictureBox cloud3;
        private PictureBox cloud4;
        private PictureBox cloud5;
        private PictureBox cloud6;
        private Panel Note_Panel;
        private Label label1;
        private PictureBox pictureBox1;
        private Label Back_label;
    }
}