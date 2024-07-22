using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation4
{
    internal class SwimmingActivity : Activity
    {
        private int _laps;

        public SwimmingActivity(string date, int length, int laps) : base(date, length)
        {
            _laps = laps;
        }

        public override float CalculateDistance()
        { return _laps * 50 / 1000; }

        public override float CalculateSpeed()
        { return (CalculateDistance() / _length) * 60; }

        public override float CalculatePace()
        { return _length / CalculateDistance(); }

        public override string GetSummary()
        { return $"{_date} Swimming ({_length:0.0} min)- Distance: {CalculateDistance():0.0} miles, Speed: {CalculateSpeed():0.0} mph, Pace: {CalculatePace():0.0} min per mile"; }
    }
}
