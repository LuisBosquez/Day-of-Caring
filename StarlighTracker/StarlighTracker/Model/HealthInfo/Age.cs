using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace StarlighTracker.Model.HealthInfo
{
    public class Age
    {
        private DateTime birthDay;

        public Age(DateTime _birthDay)
        {
            birthDay = _birthDay;
        }

        public Age(int _month, int _day, int _year)
        {
            birthDay = new DateTime(_year, _month, _day);
        }

        public int getAge()
        {
            TimeSpan span = DateTime.Now.Subtract(birthDay);           
            return (int)(span.Days/365.25);
        }
    }
}
