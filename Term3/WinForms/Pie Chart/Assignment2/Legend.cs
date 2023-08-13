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
    public partial class Legend : UserControl
    {
        private float totalPie;
        public Legend()
        {
            InitializeComponent();
        }

        // Clear the legend and add the necessary items
        public void EditLegend(List<PieChartItem> pieChartItems)
        {
            // Get the total of all the values added up in order to give percentages of the pie chart
            totalPie = 0;
            foreach (var item in pieChartItems)
            {
                totalPie += item.Value;
            }

            listBoxLegend.Items.Clear();
            foreach (var item in pieChartItems)
            {
                listBoxLegend.Items.Add(item);
            }
        }

        // Draw all the items in the list as they are added
        private void listBoxLegend_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index > -1)
            {
                var item = listBoxLegend.Items[e.Index] as PieChartItem;
                if (item != null)
                {
                    // Create the string and add a square box of the color in front
                    e.Graphics.FillRectangle(new SolidBrush(item.Color), new Rectangle(e.Bounds.X, e.Bounds.Y, 20, 20));
                    e.Graphics.DrawString("    " + item.Value + " " + item.Name + "(" + Math.Round((item.Value / totalPie * 100), 2) + "%)", e.Font, new SolidBrush(Color.Black), e.Bounds);
                    
                    // Add a horizontal scroll bar for large inputs
                    listBoxLegend.HorizontalScrollbar = true;
                    int horizontalExtent = (int)e.Graphics.MeasureString("    " + item.Value + " " + item.Name + "(" + Math.Round((item.Value / totalPie * 100), 2) + "%)", listBoxLegend.Font).Width + 10;

                    if (horizontalExtent > listBoxLegend.HorizontalExtent) // Ensure we always have the largest value needed
                        listBoxLegend.HorizontalExtent = horizontalExtent;
                }
                else // Upon first load it will show this instead
                    e.Graphics.DrawString("Can hold up to 15 items...", e.Font, new SolidBrush(Color.Black), e.Bounds);
            }
        }

        // To allow drawing in the legend
        private void Legend_Load(object sender, EventArgs e)
        {
            listBoxLegend.DrawMode = DrawMode.OwnerDrawFixed;
        }
    }
}
