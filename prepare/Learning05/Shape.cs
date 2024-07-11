using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning05
{
    internal class Shape
    {
        private string _color;

        public Shape(string color)
        { _color = color; }

        public string GetColor()
        { return _color; }
        public void SetColor(string color) 
        { _color = color; }

        public virtual double GetArea() { return 0; }

    }
}
