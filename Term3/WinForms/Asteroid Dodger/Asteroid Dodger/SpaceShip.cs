using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asteroid_Dodger
{
    class SpaceShip : Asset
    {
        public SpaceShip(Point center)
        {
            Center = center;
        }

        public override void Draw(PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Point[] nose = new Point[3];
            nose[0] = new Point(Center.X, Center.Y-30);
            nose[1] = new Point(Center.X - 10, Center.Y-20);
            nose[2] = new Point(Center.X + 10, Center.Y - 20);

            Pen shipNose = new Pen(Color.Orange, 3);

            g.DrawPolygon(shipNose, nose);

            Pen shipBody = new Pen(Color.Green, 3);

            g.DrawRectangle(shipBody, Center.X - 10, Center.Y-17, 20, 35);

            Pen shipCenter = new Pen(Color.Purple, 3);

            g.DrawEllipse(shipCenter, Center.X - 6, Center.Y+1, 12, 12);

            Point[] leftWing = new Point[5];
            leftWing[0] = new Point(Center.X - 10, Center.Y + 3);
            leftWing[1] = new Point(Center.X - 40, Center.Y + 3);
            leftWing[2] = new Point(Center.X - 40, Center.Y - 17);
            leftWing[3] = new Point(Center.X - 40, Center.Y + 15);
            leftWing[4] = new Point(Center.X - 10, Center.Y + 15);

            Point[] rightWing = new Point[5];
            rightWing[0] = new Point(Center.X + 10, Center.Y + 3);
            rightWing[1] = new Point(Center.X + 40, Center.Y + 3);
            rightWing[2] = new Point(Center.X + 40, Center.Y - 17);
            rightWing[3] = new Point(Center.X + 40, Center.Y + 15);
            rightWing[4] = new Point(Center.X + 10, Center.Y + 15);

            Pen shipWings = new Pen(Color.Blue, 3);

            g.DrawPolygon(shipWings, leftWing);
            g.DrawPolygon(shipWings, rightWing);

            Rect = new Rectangle(Center.X - 40, Center.Y - 30, 80, 48);
        }

        public override void Move(int X1, int X2, int Y1, int Y2)
        {
            int newX = Center.X + MoveX;
            if(newX < X1)
            {
                newX = X2;
            }
            else if (newX > X2)
            {
                newX = X1;
            }


            int newY = Center.Y + MoveY;
            if (newY < Y1)
            {
                newY = Y2;
            }
            else if (newY > Y2)
            {
                newY = Y1;
            }

            Center = new Point(newX, newY);
        }
    }
}
