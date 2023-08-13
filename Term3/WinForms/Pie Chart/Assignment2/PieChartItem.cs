using System.Drawing;

namespace Assignment2
{
    // Creating our pie chart pieces/items
    public class PieChartItem
    {
        private string _name;
        private float _value;
        private Color _color;

        public PieChartItem(string name, float value, Color color)
        {
            _name = name;
            _value = value;
            _color = color;
        }
        public string Name { get { return _name; } }
        public float Value { get { return _value; } }
        public Color Color { get { return _color; } }
    }
}
