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
using System.Collections.Generic;
using StarlighTracker.Model.HealthInfo;

namespace StarlighTracker.Model
{
    public abstract class HealthInformation
    {
        private List<BloodPressure> userBP;
        private List<Weight> userWeight;
    }
}
