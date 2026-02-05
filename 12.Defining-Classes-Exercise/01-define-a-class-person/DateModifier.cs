using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class DateModifier
    {
        public DateModifier(string date1AsText, string date2AsText)
        {
            date1 = DateTime.Parse(date1AsText);
            date2 = DateTime.Parse(date2AsText);
        }

        private DateTime date1;
        private DateTime date2;

        public int CalculateDayDiff()
        {
            int diff = (int)Math.Abs((date2 - date1).TotalDays);
            return diff;
        }
    }
}
