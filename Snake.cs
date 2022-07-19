using System.Drawing;

namespace SnakeSpel2
{
    public class Snake
    {
        //Variables
        public static Rectangle[] snakeRek;
        private SolidBrush brush;
        private int x, y, width, height;

        public Rectangle[] SnakeRek
        {
            get { return snakeRek; }
        }

        //Properties and values of our snake character
        public Snake()
        {
            snakeRek = new Rectangle[3];
            brush = new SolidBrush(Color.White);

            x = 20;
            y = 0;
            width = 10;
            height = 10;

            for (int i = 0; i < snakeRek.Length; i++)
            {
                snakeRek[i] = new Rectangle(x, y, width, height);
                x -= 10;
            }
        }

        //Draws our snake using our graphics
        public void RitaSnake(Graphics Paper)
        {
            foreach (Rectangle rec in snakeRek)
            {
                Paper.FillRectangle(brush, rec);
            }
        }

        //Passes values down through the snake so it can move
        public void SlutetAvArrayen()
        {
            for (int i = snakeRek.Length - 1; i > 0; i--)
            {
                snakeRek[i] = snakeRek[i - 1];
            }
        }

        //These functions move our snake
        public void moveDown()
        {
            SlutetAvArrayen();
            snakeRek[0].Y += 10;
        }
        public void moveUp()
        {
            SlutetAvArrayen();
            snakeRek[0].Y -= 10;
        }
        public void moveRight()
        {
            SlutetAvArrayen();
            snakeRek[0].X += 10;
        }
        public void moveLeft()
        {
            SlutetAvArrayen();
            snakeRek[0].X -= 10;
        }

        //Adds length to our snake's tail
        public void Svans()
        {
            Rectangle[] rek = new Rectangle[snakeRek.Length + 1];
            for (int i = 0; i < snakeRek.Length - 1; i += 1)
            {
                rek[i] = snakeRek[i];
            }
            rek[rek.Length - 1] = new Rectangle(snakeRek[snakeRek.Length - 1].X, snakeRek[snakeRek.Length - 1].Y, width, height);
            snakeRek = rek;
        }
    }
}