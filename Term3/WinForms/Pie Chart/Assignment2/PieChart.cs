using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class PieChart : UserControl
    {
        public PieChart()
        {
            InitializeComponent();
        }

        private void PieChart_Load(object sender, EventArgs e)
        {

        }

        // Paint our pie chart
        private void PieChart_Paint(object sender, PaintEventArgs e)
        {
            var parent = this.Parent as MainForm; //Allows us to pass variables
            if (parent != null) //Results in errors without this
            {
                var pieChartItems = parent.PieChartItems;

                // Get the total of all the values added up in order to divide the pie chart
                float totalPie = 0;
                foreach (var item in pieChartItems)
                {
                    totalPie += item.Value;
                }

                float startingAngle = 0; // Set starting angle at 0 each time this is run

                // Draw our pie charts pieces
                foreach (var item in pieChartItems)
                {
                    float distanceAngle = item.Value / totalPie * 360; //Set the size based on the value of the piece divided by the total, multiply by 360 degrees
                    e.Graphics.DrawPie(new Pen(new SolidBrush(item.Color)), new Rectangle(100, 10, 400, 400), startingAngle, distanceAngle); // Draw the outline
                    e.Graphics.FillPie(new SolidBrush(item.Color), new Rectangle(100, 10, 400, 400), startingAngle, distanceAngle); // Fill it in
                    startingAngle += distanceAngle; //Set our starting angle to where we ended
                }
            }
        }

        // Update/refresh the pie chart drawing
        public void UpdatePieChart()
        {
            Invalidate();
        }
    }
}
