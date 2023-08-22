using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBird
{
    public partial class Choose_Bird : Form
    {
        Start_Page startpage;
        public Choose_Bird(Start_Page startpage)
        {
            InitializeComponent();
            this.startpage = startpage;
        }
        Image selected_bird;        //to save what we selected
        private void select_brown_bird_btn_Click(object sender, EventArgs e)        // save our selected bird (Brown)
        {
            selected_bird = brown_bird.Image;
        }

        private void Done_btn_Click(object sender, EventArgs e)                 // Apply our selected bird to Main Page To Play With
        {
            startpage.My_bird.Image = selected_bird;
            this.Dispose();
        }

        private void select_blue_bird_btn_Click(object sender, EventArgs e)         // save our selected bird (Blue)
        {
            selected_bird = blue_bird.Image;
        }

        private void select_green_bird_btn_Click(object sender, EventArgs e)        // save our selected bird (Green)
        {
            selected_bird = green_bird.Image;
        }

        private void select_yellow_bird_btn_Click(object sender, EventArgs e)       // save our selected bird (Yellow)
        {
            selected_bird = yellow_bird.Image;
        }

        private void Close_btn_Click(object sender, EventArgs e)        // Close all resourse of form
        {
            this.Dispose();
        }
    }
}
