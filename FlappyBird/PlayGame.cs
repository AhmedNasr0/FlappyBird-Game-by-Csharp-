using System.Media;
using System.Threading;
namespace FlappyBird
{
    public partial class PlayGame : Form
    {
        Start_Page startpage;
        public PlayGame(Start_Page spage)
        {

            this.startpage = spage;
            InitializeComponent();
            Bird.Image = startpage.My_bird.Image;
        }
        SoundPlayer gameover_soundPlayer = new SoundPlayer("C:\\Users\\Ahmed Nasr\\Downloads\\gameover_1.wav");     
        // start of variables
        int gravity = 5;
        int speed = 3;
        Random random = new Random();
        int Score = 0;
        bool Lose = false;
        // end of variables
        private void timer1_Tick(object sender, EventArgs e)    // what happen when game begin to start
        {
            Bird.Top += gravity;
            pipedown.Left -= speed;
            pipeup.Left -= speed;
            Score_txt.Text = "Score:" + Score.ToString();
            group_of_birds_move();
            cloud_movement();

            if (pipeup.Left < 0)
            {
                Respawn_pipes();
                Score++;
            }
            Increase_Difficulty();

            if (Bird_Collision())
            {
                endgame();
            }
        }
        private void Respawn_pipes()        // respawn pipes when it leave bounds of form by set random distance
        {
            pipeup.Left = random.Next(1000, 1200);
            pipedown.Left = random.Next(950, 1200);
        }
        private bool Bird_Collision()       // check if bird collision with pipes or ground 
        {
            if (Bird.Bounds.IntersectsWith(pipedown.Bounds)
                || Bird.Bounds.IntersectsWith(pipeup.Bounds)
                || Bird.Bounds.IntersectsWith(ground1.Bounds))
            {
                return true;
            }
            else return false;
        }
        public void group_of_birds_move()   // make group of birds move and appear random until fail or stop game
        {
            groupofbirds.Left -= speed;
            if (groupofbirds.Left < 0)
            {
                groupofbirds.Left = random.Next(1000, 1200);
            }

        }
        public void cloud_movement() // make cloud move and appeare when it disapear 
        {
            cloud1.Left -= 1;
            cloud2.Left -= 1;
            cloud3.Left -= 1;
            cloud4.Left -= 1;
            cloud5.Left -= 1;
            cloud6.Left -= 1;
            if (cloud1.Left < 0) { cloud1.Left = random.Next(1000, 1200); }
            if (cloud2.Left < 0) { cloud2.Left = random.Next(1000, 1200); }
            if (cloud3.Left < 0) { cloud3.Left = random.Next(1000, 1300); }
            if (cloud4.Left < 0) { cloud4.Left = random.Next(1000, 1300); }
            if (cloud5.Left < 0) { cloud5.Left = random.Next(1000, 1250); }
            if (cloud6.Left < 0) { cloud6.Left = random.Next(1000, 1300); }
        }

        private void Increase_Difficulty()  // icrease the speed when score get higher 
        {
            if (Score <= 5) { speed = 5; }
            if (Score > 5 && Score <= 10) speed = 10;
            

        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)        // When Player Click Enter Key => press_label And note_panel will disappear
            {
                press.Visible = false;
                Note_Panel.Visible = false;
                timer1.Start();
            }
            if (e.KeyCode == Keys.Up)           // When Player click Up Key => Gravity will decreaseing => bird go up 
            {

                gravity = -5;
            }
            if (Bird.Top < 40)
            {
                Bird.Top = 50;
            }
            if (e.KeyCode == Keys.Space)    // When Player Click space Key => Game Will Reset
            {
                reset();
            }


        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)           // When Player left Up Key => Gravity will Increase => bird go down 
            {
                gravity = 5;
            }
        }
        public void endgame()       // what happen when player lose 
        {
            Lose = true;
            timer1.Stop();
            Score_txt.Text += "\n" + "Game Over !!!";
            gameover_soundPlayer.Play();
            gameover.Visible = true;
            PlayAgain.Visible = true;
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        public void reset()         // reset all to start playing again
        {
            gameover.Visible = false;
            PlayAgain.Visible = false;
            Note_Panel.Visible = false;
            press.Visible = true;
            Bird.Location = new Point(100, 50);
            pipedown.Left = 1100;
            pipeup.Left = 1000;
            Score = 0;
            speed = 3;
            gravity = 5;
        }

        private void Bird_Click(object sender, EventArgs e)
        {

        }

        private void Bird_BackgroundImageChanged(object sender, EventArgs e)
        {

        }


    }
}