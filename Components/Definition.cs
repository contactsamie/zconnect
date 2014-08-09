using System;
using zconnect.Models;

namespace zconnect.Components
{
    public class Definition
    {
        public int CommonYear = 2000;

        public Definition(MonthName fromMonth, int fromDay, MonthName toMonth, int toDay)
        {
            FromDate = new DateTime(CommonYear, (int) fromMonth, fromDay);
            ToDate = new DateTime(CommonYear, (int) toMonth, toDay);
        }

        public DateTime FromDate { set; get; }

        public DateTime ToDate { set; get; }
    }
}