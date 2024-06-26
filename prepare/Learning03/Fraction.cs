using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning03
{
    public class Fraction
    {
        private int _top;
        private int _bottom;

        // Constructors
        public Fraction() { _top = 1; _bottom = 1; }
        public Fraction(int wholeNumber) { _top = wholeNumber; _bottom = 1; }
        public Fraction(int top, int bottom) { _top = top; _bottom = bottom; }

        // Getters & Setters
        public int GetTop()
        {
            return _top;
        }

        private void setTop(int top)
        {
            _top = top;
        }

        public int GetBottom() 
        {
            return _bottom;
        }

        private void SetBottom(int bottom)
        {
            _bottom = bottom;
        }

        // Methods
        public string GetFractionString()
        {
            return $"{_top}/{_bottom}";
        }

        public double GetDecimalValue()
        {
            return (double)_top/(double)_bottom;
        }
    }
}
