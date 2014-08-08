using System;
using zconnect.Models;

namespace zconnect.SignComponents
{
    public class Definition
    {
        public Definition(MonthName fromMonth,int fromDay, MonthName toMonth, int toDay)
        {
            FromDate=new DateTime(CommonYear,(int)fromMonth,fromDay);
            ToDate = new DateTime(CommonYear, (int)toMonth, toDay);
        }

        public int CommonYear = 2000;

        public DateTime FromDate { set; get; }

        public DateTime ToDate { set; get; }
    }
}