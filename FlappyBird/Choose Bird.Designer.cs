namespace FlappyBird
{
    partial class Choose_Bird
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Choose_Bird));
            label1 = new Label();
            yellow_bird = new PictureBox();
            Done_btn = new Button();
            panel1 = new Panel();
            select_yellow_bird_btn = new Button();
            panel2 = new Panel();
            select_green_bird_btn = new Button();
            green_bird = new PictureBox();
            panel3 = new Panel();
            select_blue_bird_btn = new Button();
            blue_bird = new PictureBox();
            panel4 = new Panel();
            select_brown_bird_btn = new Button();
            brown_bird = new PictureBox();
            Close_btn = new Button();
            ((System.ComponentModel.ISupportInitialize)yellow_bird).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)green_bird).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)blue_bird).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)brown_bird).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(143, 42);
            label1.Name = "label1";
            label1.Size = new Size(193, 31);
            label1.TabIndex = 0;
            label1.Text = "Choose Your Bird";
            // 
            // yellow_bird
            // 
            yellow_bird.Dock = DockStyle.Top;
            yellow_bird.Image = (Image)resources.GetObject("yellow_bird.Image");
            yellow_bird.Location = new Point(0, 0);
            yellow_bird.Name = "yellow_bird";
            yellow_bird.Size = new Size(59, 50);
            yellow_bird.TabIndex = 2;
            yellow_bird.TabStop = false;
            // 
            // Done_btn
            // 
            Done_btn.BackColor = Color.LimeGreen;
            Done_btn.FlatStyle = FlatStyle.Flat;
            Done_btn.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Done_btn.ForeColor = SystemColors.ButtonHighlight;
            Done_btn.Location = new Point(164, 210);
            Done_btn.Name = "Done_btn";
            Done_btn.Size = new Size(154, 34);
            Done_btn.TabIndex = 6;
            Done_btn.Text = "Done";
            Done_btn.UseVisualStyleBackColor = false;
            Done_btn.Click += Done_btn_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(select_yellow_bird_btn);
            panel1.Controls.Add(yellow_bird);
            panel1.Location = new Point(348, 106);
            panel1.Name = "panel1";
            panel1.Size = new Size(59, 86);
            panel1.TabIndex = 7;
            // 
            // select_yellow_bird_btn
            // 
            select_yellow_bird_btn.BackColor = Color.Gold;
            select_yellow_bird_btn.Dock = DockStyle.Top;
            select_yellow_bird_btn.FlatAppearance.BorderSize = 0;
            select_yellow_bird_btn.FlatStyle = FlatStyle.Flat;
            select_yellow_bird_btn.ForeColor = Color.Black;
            select_yellow_bird_btn.Location = new Point(0, 50);
            select_yellow_bird_btn.Name = "select_yellow_bird_btn";
            select_yellow_bird_btn.Size = new Size(59, 36);
            select_yellow_bird_btn.TabIndex = 8;
            select_yellow_bird_btn.Text = "select ";
            select_yellow_bird_btn.UseVisualStyleBackColor = false;
            select_yellow_bird_btn.Click += select_yellow_bird_btn_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(select_green_bird_btn);
            panel2.Controls.Add(green_bird);
            panel2.Location = new Point(259, 106);
            panel2.Name = "panel2";
            panel2.Size = new Size(59, 86);
            panel2.TabIndex = 8;
            // 
            // select_green_bird_btn
            // 
            select_green_bird_btn.BackColor = Color.LimeGreen;
            select_green_bird_btn.Dock = DockStyle.Top;
            select_green_bird_btn.FlatAppearance.BorderSize = 0;
            select_green_bird_btn.FlatStyle = FlatStyle.Flat;
            select_green_bird_btn.ForeColor = Color.Black;
            select_green_bird_btn.Location = new Point(0, 50);
            select_green_bird_btn.Name = "select_green_bird_btn";
            select_green_bird_btn.Size = new Size(59, 36);
            select_green_bird_btn.TabIndex = 8;
            select_green_bird_btn.Text = "select ";
            select_green_bird_btn.UseVisualStyleBackColor = false;
            select_green_bird_btn.Click += select_green_bird_btn_Click;
            // 
            // green_bird
            // 
            green_bird.Dock = DockStyle.Top;
            green_bird.Image = (Image)resources.GetObject("green_bird.Image");
            green_bird.Location = new Point(0, 0);
            green_bird.Name = "green_bird";
            green_bird.Size = new Size(59, 50);
            green_bird.TabIndex = 2;
            green_bird.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(select_blue_bird_btn);
            panel3.Controls.Add(blue_bird);
            panel3.Location = new Point(164, 106);
            panel3.Name = "panel3";
            panel3.Size = new Size(59, 86);
            panel3.TabIndex = 9;
            // 
            // select_blue_bird_btn
            // 
            select_blue_bird_btn.BackColor = Color.DarkTurquoise;
            select_blue_bird_btn.Dock = DockStyle.Top;
            select_blue_bird_btn.FlatAppearance.BorderSize = 0;
            select_blue_bird_btn.FlatStyle = FlatStyle.Flat;
            select_blue_bird_btn.ForeColor = Color.Black;
            select_blue_bird_btn.Location = new Point(0, 50);
            select_blue_bird_btn.Name = "select_blue_bird_btn";
            select_blue_bird_btn.Size = new Size(59, 36);
            select_blue_bird_btn.TabIndex = 8;
            select_blue_bird_btn.Text = "select ";
            select_blue_bird_btn.UseVisualStyleBackColor = false;
            select_blue_bird_btn.Click += select_blue_bird_btn_Click;
            // 
            // blue_bird
            // 
            blue_bird.Dock = DockStyle.Top;
            blue_bird.Image = (Image)resources.GetObject("blue_bird.Image");
            blue_bird.Location = new Point(0, 0);
            blue_bird.Name = "blue_bird";
            blue_bird.Size = new Size(59, 50);
            blue_bird.TabIndex = 2;
            blue_bird.TabStop = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(select_brown_bird_btn);
            panel4.Controls.Add(brown_bird);
            panel4.Location = new Point(71, 106);
            panel4.Name = "panel4";
            panel4.Size = new Size(59, 86);
            panel4.TabIndex = 10;
            // 
            // select_brown_bird_btn
            // 
            select_brown_bird_btn.BackColor = Color.Tan;
            select_brown_bird_btn.Dock = DockStyle.Top;
            select_brown_bird_btn.FlatAppearance.BorderSize = 0;
            select_brown_bird_btn.FlatStyle = FlatStyle.Flat;
            select_brown_bird_btn.ForeColor = Color.Black;
            select_brown_bird_btn.Location = new Point(0, 50);
            select_brown_bird_btn.Name = "select_brown_bird_btn";
            select_brown_bird_btn.Size = new Size(59, 36);
            select_brown_bird_btn.TabIndex = 8;
            select_brown_bird_btn.Text = "select ";
            select_brown_bird_btn.UseVisualStyleBackColor = false;
            select_brown_bird_btn.Click += select_brown_bird_btn_Click;
            // 
            // brown_bird
            // 
            brown_bird.Dock = DockStyle.Top;
            brown_bird.Image = (Image)resources.GetObject("brown_bird.Image");
            brown_bird.Location = new Point(0, 0);
            brown_bird.Name = "brown_bird";
            brown_bird.Size = new Size(59, 50);
            brown_bird.TabIndex = 2;
            brown_bird.TabStop = false;
            // 
            // Close_btn
            // 
            Close_btn.BackColor = Color.Red;
            Close_btn.FlatStyle = FlatStyle.Flat;
            Close_btn.ForeColor = SystemColors.ButtonHighlight;
            Close_btn.Location = new Point(462, 3);
            Close_btn.Name = "Close_btn";
            Close_btn.Size = new Size(35, 36);
            Close_btn.TabIndex = 11;
            Close_btn.Text = "X";
            Close_btn.UseVisualStyleBackColor = false;
            Close_btn.Click += Close_btn_Click;
            // 
            // Choose_Bird
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Olive;
            ClientSize = new Size(500, 268);
            Controls.Add(Close_btn);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(Done_btn);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Choose_Bird";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Choose_Bird";
            ((System.ComponentModel.ISupportInitialize)yellow_bird).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)green_bird).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)blue_bird).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)brown_bird).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox yellow_bird;
        private Button Done_btn;
        private Panel panel1;
        private Button select_yellow_bird_btn;
        private Panel panel2;
        private Button select_green_bird_btn;
        private PictureBox green_bird;
        private Panel panel3;
        private Button select_blue_bird_btn;
        private PictureBox blue_bird;
        private Panel panel4;
        private Button select_brown_bird_btn;
        private PictureBox brown_bird;
        private Button Close_btn;
    }
}