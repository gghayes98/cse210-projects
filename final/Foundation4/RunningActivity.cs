using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation4
{
    internal class RunningActivity : Activity
    {
        private float _distance;

        public RunningActivity(string date, int length, float distance) : base(date, length)
        {
            _distance = distance;
        }

        public override float CalculateSpeed()
        { return (_distance / _length) * 60; }

        public override float CalculatePace()
        { return 60 / CalculateSpeed(); }

        public override string GetSummary()
        { return $"{_date} Running ({_length:0.0} min) - Distance {_distance:0.0} miles, Speed: {CalculateSpeed():0.0} mph, Pace: {CalculatePace():0.0} min per mile"; }
    }
}
