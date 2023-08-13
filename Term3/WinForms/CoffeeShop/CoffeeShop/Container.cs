using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShop
{
    public partial class Container : UserControl
    {
        List<UserControl> UserControlList;
        private int coffeeCount = 0;
        private int donutCount = 0;
        private int yAxis = 0;

        public Container()
        {
            InitializeComponent();
        }

        private void Container_Load(object sender, EventArgs e)
        {
            pnlControl.AutoScroll = true;
            UserControlList = new List<UserControl>();
        }

        public void AddCoffee()
        {
            coffeeCount++;
            CoffeeSelection coffee = new CoffeeSelection();
            coffee.LabelName = "Coffee " + coffeeCount.ToString();
            coffee.Name = "Coffee " + coffeeCount.ToString();
            coffee.Location = new Point(0, yAxis - pnlControl.VerticalScroll.Value);
            yAxis += coffee.Size.Height + 5;
            UserControlList.Add(coffee);
            pnlControl.Controls.Add(coffee);
        }

        public void AddDonut()
        {
            donutCount++;
            DonutSelection donut = new DonutSelection();
            donut.LabelName = "Donut " + donutCount.ToString();
            donut.Name = "Donut " + donutCount.ToString();
            donut.Location = new Point(0, yAxis - pnlControl.VerticalScroll.Value);
            yAxis += donut.Size.Height + 5;
            UserControlList.Add(donut);
            pnlControl.Controls.Add(donut);
        }

        public void Clear()
        {
            //pnlControl.Controls.Clear();
            while (pnlControl.Controls.Count > 0)
            {
                pnlControl.Controls.RemoveAt(0);
            }
            UserControlList = new List<UserControl>();

            yAxis = coffeeCount = donutCount = 0;
        }

        public override string ToString()
        {
            string message = string.Empty;
            foreach (UserControl userControl in UserControlList)
            {
                message += userControl.ToString();
            }
            return message;
        }
    }
}
