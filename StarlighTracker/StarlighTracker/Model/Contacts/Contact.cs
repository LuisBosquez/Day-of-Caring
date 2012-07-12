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

namespace StarlighTracker.Model.Contacts
{
    public interface Contact
    {
        private string name
        {
            get;
            set;
        }
        private string phone
        {
            get;
            set;
        }
    }
}
