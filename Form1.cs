using System;
using System.Drawing;
using System.Windows.Forms;

namespace SnakeSpel2
{
    public partial class startLabel : Form
    {
        Graphics paper;
        Snake snake = new Snake();
        Mat mat;
        DateTime start;

        public startLabel()
        {
            InitializeComponent();
            mat = new Mat(Mat.rand);
        }

        //This allows us to draw on form1
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            paper = e.Graphics;
            mat.RitaMat(paper);
            snake.RitaSnake(paper);
        }

        //Variables for snake movement
        bool left = false;
        bool right = false;
        bool down = false;
        bool up = false;
        bool firstStart = true;
        bool styrningDisabled = true;

        int score = 0;

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //Movement
            //If Down is pressed, we aren't already moving up and steering isn't disabled
            if (e.KeyData == Keys.Down && up == false && styrningDisabled == false)
            {
                //Set us to moving down
                down = true;
                up = false;
                right = false;
                left = false;
            }
            else if (e.KeyData == Keys.Up && down == false && styrningDisabled == false)
            {
                down = false;
                up = true;
                right = false;
                left = false;
            }
            else if (e.KeyData == Keys.Left && right == false && styrningDisabled == false)
            {
                down = false;
                up = false;
                right = false;
                left = true;
            }
            else if (e.KeyData == Keys.Right && left == false && styrningDisabled == false)
            {
                down = false;
                up = false;
                right = true;
                left = false;
            }

            //Spacebar starts the game when it isn't started already and sets initial values
            if (firstStart == true && e.KeyData == Keys.Space)
            {
                //Timers to keep track of playing time and the game logic
                start = DateTime.Now;
                KlockaTimer.Enabled = true;
                spelTimer.Enabled = true;

                //Remove all our information labels visible by default when game starts
                label1.Text = "";
                insLabel.Text = "";
                uppLabel.Text = "";
                nerLabel.Text = "";
                högerLabel.Text = "";
                vänsterLabel.Text = "";
                vgmLabel.Text = "";
                matenLabel.Text = "";
                redoLabel.Text = "";

                //Sets the snake movement direction and control
                down = false;
                up = false;
                right = true;
                left = false;
                styrningDisabled = false;

                //We have now started the game so we no longer want to run this function
                firstStart = false;
            }
        }

        //Constantly updates the game
        private void SpelTimer_Tick(object sender, EventArgs e)
        {
            scoreLabel.Text = Convert.ToString(score);

            if (down) { snake.moveDown(); }
            if (up) { snake.moveUp(); }
            if (left) { snake.moveLeft(); }
            if (right) { snake.moveRight(); }


            //Check if snake intersects with food
            if (snake.SnakeRek[0].IntersectsWith(mat.matRek))
            {
                //Increase score
                score += 1;

                //Call snake tail function
                snake.Svans();

                //Create new piece of food
                mat.MatPos(Mat.rand, this.Width - 20, this.Height - 60);

                //Levels, just speeds up the game to make it harder
                if (score == 5)
                {
                    spelTimer.Interval = 150;
                }
                if (score == 10)
                {
                    spelTimer.Interval = 100;
                }
                if (score == 20)
                {
                    spelTimer.Interval = 50;
                }
            }

            //Check collision between snake head, snake body and wall
            CheckSnakeCollision();

            //Redraw
            this.Invalidate();
        }

        public void CheckSnakeCollision()
        {
            //Loops through snake making sure none of the coordinates of the snake body and the head are the same
            for (int i = 1; i < snake.SnakeRek.Length; i++)
            {
                if (snake.SnakeRek[0].IntersectsWith(snake.SnakeRek[i]))
                {
                    Restart();
                }
            }

            //If the snake head hits the wall we lose
            if (snake.SnakeRek[0].X < 0 || snake.SnakeRek[0].X > this.Width - 20)
            {
                Restart();
            }

            if (snake.SnakeRek[0].Y < 0 || snake.SnakeRek[0].Y > this.Height - 60)
            {
                Restart();
            }
        }

        //Restarts the game on
        public void Restart()
        {
            //Disable our timers
            KlockaTimer.Enabled = false;
            spelTimer.Enabled = false;

            //Ask player if they want to restart and if they do, reset the game
            DialogResult dialogResult = MessageBox.Show("Your score was: " + score + ". Want to restart? (Selecting No will exit)", "Restart?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                score = 0;
                scoreLabel.Text = "0";
                timerLabel.Text = "00:00";
                label1.Text = "Tryck mellanslag för att starta!";
                insLabel.Text = "Instruktioner:";
                uppLabel.Text = "Pil Upp = Upp";
                nerLabel.Text = "Pil Ner =  Ner";
                högerLabel.Text = "Pil Höger = Höger";
                vänsterLabel.Text = "Pil Vänster = Vänster";
                vgmLabel.Text = "Vad gör man?";
                matenLabel.Text = "Ät upp maten och bli större";
                redoLabel.Text = "Redo?!";
                snake = new Snake();
                spelTimer.Interval = 200;
                firstStart = true;
            }
            else if (dialogResult == DialogResult.No) { Application.Exit(); }
        }

        //Tells player how long they have been playing
        private void KlockaTimer_Tick(object sender, EventArgs e)
        {
            TimeSpan tid = DateTime.Now - start;
            timerLabel.Text = tid.Minutes.ToString().PadLeft(2, '0') + ":" + tid.Seconds.ToString().PadLeft(2, '0');
        }
    }
}
