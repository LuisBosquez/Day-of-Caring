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
    public abstract class BloodPressure
    {
        private int sys;
        private int dia;

        public BloodPressure(int _sys, int _dia)
        {
            sys = _sys;
            dia = _dia;
        }

        public string getBP()
        {
            return (sys + "/" + dia);
        }
    }
}
