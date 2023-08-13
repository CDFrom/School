using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asteroid_Dodger
{
    public partial class MainForm : Form
    {
        List<Asteroid> asteroids;
        SpaceShip spaceShip;

        int collisions = 0;
        int score = 0;
        int counter = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        private void InitializeObjects()
        {
            int[] movement = { -5, -4, -3, -3, -2, -2, -2, -1, -1, -1, 1, 1, 1, 2, 2, 2, 3, 3, 4, 5 };

            Random rand = new Random();
            asteroids = new List<Asteroid>();
            spaceShip = new SpaceShip(new Point(315, 300));

            int totalAsteroids = 40;
            int asteroidCount = 0;
            while (asteroidCount < totalAsteroids)
            {
                int x = rand.Next(100, 1000);
                int y = rand.Next(100, 400);
                int radius = rand.Next(20, 70);
                Asteroid asteroid = new Asteroid(new Point(x, y), radius);
                asteroid.MoveX = movement[rand.Next(0, movement.Length - 1)];
                asteroid.MoveY = movement[rand.Next(0, movement.Length - 1)];

                asteroids.Add(asteroid);
                asteroidCount++;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            asteroidTimer.Interval = 16;
            asteroidTimer.Start();
            InitializeObjects();

            this.Size = new Size(1000, 700);
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.BackColor = Color.MidnightBlue;
            this.Paint += new PaintEventHandler(this.PaintObjects);
        }

        private void PaintObjects(Object sender, PaintEventArgs e)
        {
            Rectangle rec = new Rectangle(100, 100, 800, 500);
            e.Graphics.DrawRectangle(Pens.WhiteSmoke, rec);

            Region clippingRegion = new Region(rec);
            e.Graphics.Clip = clippingRegion;

            spaceShip.Draw(e);

            int asteroidIndex = asteroids.Count() - 1;
            while (asteroidIndex > 0)
            {
                if (asteroids[asteroidIndex].Collision(spaceShip))
                {
                    asteroids.RemoveAt(asteroidIndex);
                    collisions++;
                }
                else
                {
                    asteroids[asteroidIndex].Draw(e);
                }
                asteroidIndex--;
            }
            e.Graphics.ResetClip();
            e.Graphics.DrawString("Score: " + score.ToString(), new Font("Arial",30,FontStyle.Regular), Brushes.Gold, 100,20);
            e.Graphics.DrawString("Collision: " + collisions.ToString(), new Font("Arial", 30, FontStyle.Italic), Brushes.Red, 700, 20);
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainForm_KeyUp(object sender, KeyEventArgs e)
        {
            spaceShip.MoveX = 0;
            spaceShip.MoveY = 0;
        }

        private void MainForm_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                spaceShip.MoveX = -5;
            }
            if (e.KeyCode == Keys.Right)
            {
                spaceShip.MoveX = 5;
            }
            if (e.KeyCode == Keys.Up)
            {
                spaceShip.MoveY = -5;
            }
            if (e.KeyCode == Keys.Down)
            {
                spaceShip.MoveY = 5;
            }

        }

        private void asteroidTimer_Tick(object sender, EventArgs e)
        {
            spaceShip.Move(100, 1100, 100, 800);
            foreach (Asset asteroid in asteroids)
            {
                asteroid.Move(0, this.Size.Width, 0, this.Size.Height);
            }
            counter++;
            if (counter >= 60)
            {
                score++;
                counter = 0;
            }
            this.Refresh();
        }

        /****EVERYTHING BELOW DONE BEFORE IN CLASS LEARNING****/
        //Created before beginning LA in class
        private void CreateAsteroidField(Graphics g)
        {
            Pen p = new Pen(Color.SaddleBrown, 2);
            Random r = new Random();

            int meteorDiameter;
            Rectangle shape;

            for (int count = 0; count < 10; count++)
            {
                meteorDiameter = r.Next(15, 50);
                shape = new Rectangle(r.Next(600), r.Next(400), meteorDiameter, meteorDiameter);
                g.DrawEllipse(p, shape);
            }
        }

        //Created before beginning LA in class
        private void CreateSpaceShip1(Graphics g)
        {
            Point[] nose = new Point[3];
            nose[0] = new Point(300, 300);
            nose[1] = new Point(290, 310);
            nose[2] = new Point(310, 310);

            Pen shipNose = new Pen(Color.Orange, 3);

            g.DrawPolygon(shipNose, nose);

            Pen shipBody= new Pen(Color.Green, 3);

            g.DrawRectangle(shipBody, 290, 313, 20, 35);

            Pen shipCenter = new Pen(Color.Purple, 3);

            g.DrawEllipse(shipCenter, 294, 331, 12, 12);

            Point[] leftWing = new Point[5];
            leftWing[0] = new Point(290, 333);
            leftWing[1] = new Point(260, 333);
            leftWing[2] = new Point(260, 313);
            leftWing[3] = new Point(260, 345);
            leftWing[4] = new Point(290, 345);

            Point[] rightWing = new Point[5];
            rightWing[0] = new Point(310, 333);
            rightWing[1] = new Point(340, 333);
            rightWing[2] = new Point(340, 313);
            rightWing[3] = new Point(340, 345);
            rightWing[4] = new Point(310, 345);

            Pen shipWings = new Pen(Color.Blue, 3);

            g.DrawPolygon(shipWings, leftWing);
            g.DrawPolygon(shipWings, rightWing);
        }

        //Created before beginning LA in class
        private void CreateSpaceShip2(Graphics g)
        {
            Pen shipCenter = new Pen(Color.Gray, 3);

            g.DrawEllipse(shipCenter, 294, 391, 25, 25);

            Pen wings = new Pen(Color.Black, 3);

            g.DrawLine(wings, new Point(291, 386), new Point(291, 421));
            g.DrawLine(wings, new Point(322, 386), new Point(322, 421));
        }
    }
}
