using System;
using System.Drawing;

namespace SnakeSpel2
{
    public class Mat
    {
        //Public and private variables
        private int x, y, width, height;
        public static Random rand = new Random();
        private SolidBrush brush;
        public Rectangle matRek;
        bool notOnHead = false;

        //Constructor for food
        public Mat(Random rand)
        {
            x = rand.Next(0, 29) * 10;
            y = rand.Next(0, 29) * 10;

            brush = new SolidBrush(Color.Magenta);
            width = 10;
            height = 10;
            matRek = new Rectangle(x, y, width, height);
        }

        //Makes sure we don't randomize on top of or right next to the snake
        public bool CheckRands(int x, int y)
        {
            bool yIsOk = false;
            bool xIsOk = false;
            if (y < Snake.snakeRek[0].Y - 20 || y > Snake.snakeRek[0].Y + 20)
            {
                yIsOk = true;
            }
            if (x < Snake.snakeRek[0].X - 20 || x > Snake.snakeRek[0].X + 20)
            {
                xIsOk = true;
            }

            if (xIsOk && yIsOk)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Randomizes the food's position until it's an acceptable value, not on or next to
        public void MatPos(Random rand, int width, int height)
        {
            notOnHead = false;
            x = rand.Next(0, width / 10) * 10;
            y = rand.Next(0, height / 10) * 10;

            while (notOnHead == false)
            {
                if (CheckRands(x, y) == false)
                {
                    x = rand.Next(0, width / 10) * 10;
                    y = rand.Next(0, height / 10) * 10;
                }
                else
                {
                    notOnHead = true;
                }
            }
        }

        //Draws our food
        public void RitaMat(Graphics paper)
        {
            matRek.X = x;
            matRek.Y = y;

            paper.FillRectangle(brush, matRek);
        }
    }
}