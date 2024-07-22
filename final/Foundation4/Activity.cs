using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation4
{
    internal class Activity
    {
        protected string _date;
        protected int _length; // In minutes

        public Activity(string date, int length)
        {
            _date = date;
            _length = length;
        }

        public virtual float CalculateDistance()
        { return 0f; }

        public virtual float CalculateSpeed()
        { return 0f; }

        public virtual float CalculatePace()
        { return 0f; }

        public virtual string GetSummary()
        { return "ERROR"; }
    }
}
