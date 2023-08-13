using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asteroid_Dodger
{
    public class Asteroid : Asset
    {
        public int Radius { get; set; }
        
        public Asteroid(Point center, int radius)
        {
            Center = center;
            Radius = radius;
        }

        public override void Draw(PaintEventArgs e)
        {
            Pen pen = new Pen(Color.GhostWhite, 2);

            Rect = new Rectangle(Center.X, Center.Y, Radius, Radius);
            e.Graphics.DrawEllipse(pen, Rect);
        }

        public bool Collision(Asset spaceShip)
        {
            if (Rect.IntersectsWith(spaceShip.Rect)) return true;
            else return false;
        }
    }
}
