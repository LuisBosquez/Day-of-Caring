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
    private enum WeightUnits
    {
        Pound,
        Kilograms
    }

    public abstract class Weight
    {
        private int weight;
        private WeightUnits units;
        private DateTime timestamp;

        public Weight(int _weight, WeightUnits _units)
        {
            weight = _weight;
            units = _units;
            timestamp = DateTime.Today;
        }

        public string getWeight()
        {
            return (weight + " " + units.ToString());
        }
    }
}
