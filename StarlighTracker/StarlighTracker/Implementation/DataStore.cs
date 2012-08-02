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
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace StarlighTracker.Implementation
{
    public class DataStore : INotifyPropertyChanged
    {
        private DatabaseContext databaseContext;

        private ObservableCollection<Medicine> _medicines;
        public ObservableCollection<Medicine> Medicines;

        private ObservableCollection<Appointment> _appointments;
        public ObservableCollection<Appointment> Appointments;

        public DataStore()
        {
            databaseContext = new DatabaseContext(DatabaseContext.DBConnectionString);
        }

        public static DataStore Instance
        {
            get {
                return new DataStore();
            }
        }

        public int AddEntry(int table)
        {
            switch (table)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                default:
                    return -1;
            }

            return 1;
        }

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        // Used to notify Silverlight that a property has changed.
        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion
    }

    [Table (Name = "Medicine")]

    public class Medicine : INotifyPropertyChanged, INotifyPropertyChanging
    {
        private int _medicineId;

        [Column(IsPrimaryKey = true, IsDbGenerated = true, DbType = "INT NOT NULL Identity", CanBeNull = false, AutoSync = AutoSync.OnInsert)]

        public int MedicineId
        {
            get
            {
                return _medicineId;
            }
            set
            {
                if (_medicineId != value)
                {
                    NotifyPropertyChanging("Updating!");
                    _medicineId = value;
                    NotifyPropertyChanged("Updated!");
                }
            }
        }

        private string _medicineName;

        [Column]

        public string MedicineName
        {
            get
            {
                return _medicineName;
            }
            set
            {
                if (_medicineName != value)
                {
                    NotifyPropertyChanging("Updating!");
                    _medicineName = value;
                    NotifyPropertyChanged("Updated!");
                }
            }
        }

        private string _medicineDescription;

        [Column]

        public string MedicineDescription
        {
            get
            {
                return _medicineDescription;
            }
            set
            {
                if (_medicineDescription != value)
                {
                    NotifyPropertyChanging("Updating!");
                    _medicineDescription = value;
                    NotifyPropertyChanged("Updated!");
                }
            }
        }

        private TimeSpan _dosage;

        [Column]

        public TimeSpan Dosage
        {
            get 
            {
                return _dosage;
            }
            set
            {
                if (_dosage != value)
                {
                    NotifyPropertyChanging("Updating!");
                    _dosage = value;
                    NotifyPropertyChanged("Updated");
                }
            }
        }

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        // Used to notify the page that a data context property changed
        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion

        #region INotifyPropertyChanging Members

        public event PropertyChangingEventHandler PropertyChanging;

        // Used to notify the data context that a data context property is about to change
        private void NotifyPropertyChanging(string propertyName)
        {
            if (PropertyChanging != null)
            {
                PropertyChanging(this, new PropertyChangingEventArgs(propertyName));
            }
        }

        #endregion

    }

    [Table (Name = "Appointments")]

    public class Appointment : INotifyPropertyChanged, INotifyPropertyChanging
    {
        private int _appointmentId;

        [Column(IsPrimaryKey = true, IsDbGenerated = true, DbType = "INT NOT NULL Identity", CanBeNull = false, AutoSync = AutoSync.OnInsert)]
        public int AppointmentId
        {
            get
            {
                return _appointmentId;
            }
            set
            {
                if (_appointmentId != value)
                {
                    NotifyPropertyChanging("Updating!");
                    _appointmentId = value;
                    NotifyPropertyChanged("Updated!");
                }
            }
        }

        private DateTime _dueDate;

        [Column(DbType = "DATE NOT NULL")]
        public DateTime DueDate
        {
            get
            {
                return _dueDate;
            }
            set
            {
                if (_dueDate != value)
                {
                    NotifyPropertyChanging("Updating!");
                    _dueDate = value;
                    NotifyPropertyChanged("Updated!");
                }
            }
        }

        private string _appointmentTitle;

        [Column]

        public string AppointmentTitle
        {
            get
            {
                return _appointmentTitle;
            }
            set
            {
                if (_appointmentTitle != value)
                {
                    NotifyPropertyChanging("Updating!");
                    _appointmentTitle = value;
                    NotifyPropertyChanged("Updated!");
                }
            } 
        }

        private string _appointmentDescription;

        [Column]
        public string AppointmentDescription
        {
            get
            {
                return _appointmentDescription;
            }
            set
            {
                if (_appointmentDescription != value)
                {
                    NotifyPropertyChanging("Updating!");
                    _appointmentDescription = value;
                    NotifyPropertyChanged("Updated!");
                }
            }
        }

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion

        #region INotifyPropertyChanging Members

        public event PropertyChangingEventHandler PropertyChanging;

        private void NotifyPropertyChanging(string propertyName)
        {
            if (PropertyChanging != null)
            {
                PropertyChanging(this, new PropertyChangingEventArgs(propertyName));
            }
        }
        #endregion

    }

    public class DatabaseContext : DataContext
    {
        public static string DBConnectionString = "Data Source=isostore:/ToDo.sdf";
        public DatabaseContext(string connectionString)
            : base(connectionString) { }
        public Table<Appointment> Appointments;
        public Table<Medicine> Medicines;
    }

}
