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
    public class Emergency:Contact
    {
        private string name
        {
            get
            {
                return name;
            }
            set 
            {
                this.name = name;
            }
        }

        private string phone
        {
            get
            {
                return phone;
            }
            set
            {
                this.phone = phone;
            }
        }
    }
}
