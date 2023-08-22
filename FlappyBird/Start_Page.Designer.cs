namespace FlappyBird
{
    partial class Start_Page
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
            components = new System.ComponentModel.Container();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            My_bird = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            imageList1 = new ImageList(components);
            Quit = new Button();
            Play_btn = new Button();
            choosebird_btn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)My_bird).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.background;
            pictureBox1.Location = new Point(-8, -123);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(752, 583);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.PaleTurquoise;
            pictureBox2.Image = Properties.Resources.flappybird;
            pictureBox2.Location = new Point(132, 27);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(461, 80);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // My_bird
            // 
            My_bird.BackColor = Color.PaleTurquoise;
            My_bird.Image = Properties.Resources.bird1;
            My_bird.Location = new Point(343, 135);
            My_bird.Name = "My_bird";
            My_bird.Size = new Size(65, 61);
            My_bird.SizeMode = PictureBoxSizeMode.StretchImage;
            My_bird.TabIndex = 2;
            My_bird.TabStop = false;
            My_bird.Click += pictureBox3_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 50;
            timer1.Tick += timer1_Tick;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // Quit
            // 
            Quit.BackColor = Color.Red;
            Quit.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Quit.ForeColor = SystemColors.ButtonHighlight;
            Quit.Location = new Point(132, 268);
            Quit.Name = "Quit";
            Quit.Size = new Size(147, 49);
            Quit.TabIndex = 3;
            Quit.Text = "Quit";
            Quit.UseVisualStyleBackColor = false;
            Quit.Click += button1_Click;
            // 
            // Play_btn
            // 
            Play_btn.BackColor = Color.MediumSeaGreen;
            Play_btn.FlatStyle = FlatStyle.Flat;
            Play_btn.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Play_btn.ForeColor = SystemColors.ButtonHighlight;
            Play_btn.ImageKey = "(none)";
            Play_btn.Location = new Point(466, 268);
            Play_btn.Name = "Play_btn";
            Play_btn.Size = new Size(127, 49);
            Play_btn.TabIndex = 4;
            Play_btn.Text = "Play Game";
            Play_btn.UseVisualStyleBackColor = false;
            Play_btn.Click += button2_Click;
            // 
            // choosebird_btn
            // 
            choosebird_btn.BackColor = Color.MediumSeaGreen;
            choosebird_btn.FlatStyle = FlatStyle.Flat;
            choosebird_btn.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point);
            choosebird_btn.ForeColor = SystemColors.ButtonHighlight;
            choosebird_btn.Location = new Point(304, 268);
            choosebird_btn.Name = "choosebird_btn";
            choosebird_btn.Size = new Size(132, 49);
            choosebird_btn.TabIndex = 5;
            choosebird_btn.Text = "Chooce Bird";
            choosebird_btn.UseVisualStyleBackColor = false;
            choosebird_btn.Click += choosebird_btn_Click;
            // 
            // Start_Page
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(735, 450);
            Controls.Add(choosebird_btn);
            Controls.Add(Play_btn);
            Controls.Add(Quit);
            Controls.Add(My_bird);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Start_Page";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Start_Page";
            Load += Start_Page_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)My_bird).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer1;
        private ImageList imageList1;
        private Button Quit;
        private Button Play_btn;
        private Button choosebird_btn;
        public PictureBox My_bird;
    }
}