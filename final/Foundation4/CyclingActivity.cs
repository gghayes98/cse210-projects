using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation4
{
    internal class CyclingActivity : Activity
    {
        private float _speed;

        public CyclingActivity(string date, int length, float speed) : base(date, length)
        {
            _speed = speed;
        }

        public override float CalculateDistance()
        { return _speed * ((float) _length/60); }

        public override float CalculatePace()
        { return _length / CalculateDistance(); }

        public override string GetSummary()
        { return $"{_date} Cycling ({_length:0.0} min)- Distance {CalculateDistance():0.0} miles, Speed: {_speed:0.0} mph, Pace: {CalculatePace():0.0} min per mile"; }
    }
}
