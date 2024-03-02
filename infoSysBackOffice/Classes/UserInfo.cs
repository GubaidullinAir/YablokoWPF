using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace infoSysBackOffice
{
    public class AdmissionViewModel : INotifyPropertyChanged
    {
        private int _id;
        public int Id
        {
            get { return _id; }
            set
            {
                _id = value;
                OnPropertyChanged(nameof(Id));
            }
        }

        private string _firstName;
        public string FirstName
        {
            get { return _firstName; }
            set
            {
                _firstName = value;
                OnPropertyChanged(nameof(FirstName));
            }
        }

        private string _lastName;
        public string LastName
        {
            get { return _lastName; }
            set
            {
                _lastName = value;
                OnPropertyChanged(nameof(LastName));
            }
        }

        private DateTime _birthday;
        public DateTime Birthday
        {
            get { return _birthday; }
            set
            {
                _birthday = value;
                OnPropertyChanged(nameof(Birthday));
            }
        }

        public AdmissionViewModel()
        {

        }

        public AdmissionViewModel(int id, string firstName, string lastName, DateTime birthday)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Birthday = birthday;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public class YourViewModel : INotifyPropertyChanged
    {
        private string _selectedRegion;
        public string SelectedRegion
        {
            get { return _selectedRegion; }
            set
            {
                _selectedRegion = value;
                OnPropertyChanged(nameof(SelectedRegion));
            }
        }

        private string _selectedLocalBranch;
        public string SelectedLocalBranch
        {
            get { return _selectedLocalBranch; }
            set
            {
                _selectedLocalBranch = value;
                OnPropertyChanged(nameof(SelectedLocalBranch));
            }
        }

        private string _fullName;
        public string FullName
        {
            get { return _fullName; }
            set
            {
                _fullName = value;
                OnPropertyChanged(nameof(FullName));
            }
        }

        private string _phone;
        public string Phone
        {
            get { return _phone; }
            set
            {
                _phone = value;
                OnPropertyChanged(nameof(Phone));
            }
        }

        private string _gender;
        public string Gender
        {
            get { return _gender; }
            set
            {
                _gender = value;
                OnPropertyChanged(nameof(Gender));
            }
        }

        private DateTime _birthdate;
        public DateTime Birthdate
        {
            get { return _birthdate; }
            set
            {
                _birthdate = value;
                OnPropertyChanged(nameof(Birthdate));
            }
        }

        private string _citizenship;
        public string Citizenship
        {
            get { return _citizenship; }
            set
            {
                _citizenship = value;
                OnPropertyChanged(nameof(Citizenship));
            }
        }

        public ObservableCollection<string> Regions { get; set; }
        public ObservableCollection<string> LocalBranches { get; set; }

        public YourViewModel()
        {
            Regions = new ObservableCollection<string>
            {
                "Республика Татарстан"
                // Другие регионы...
            };

            LocalBranches = new ObservableCollection<string>
            {
                "не выбрано",
                "МО г. Казань"
                // Другие местные отделения...
            };

            // Установка значений по умолчанию
            SelectedRegion = Regions[0];
            SelectedLocalBranch = LocalBranches[0];
            FullName = "Утеев Тимур Сергеевич";
            Phone = "+7 965 628 49 35";
            Gender = "Мужской";
            Birthdate = new DateTime(2003, 10, 6);
            Citizenship = "Русский";
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

//    public class AdmissionViewModel
//    {
//        public int Id { get; set; }
//        public string FirstName { get; set; }
//        public string LastName { get; set; }
//        public DateTime Birthday { get; set; }

//        public AdmissionViewModel()
//        {   

//        }

//        public AdmissionViewModel(int id, string FirstName, string LastName, DateTime Birthday)
//        {
//            this.Id = id;
//            this.FirstName = FirstName;
//            this.LastName = LastName;
//            this.Birthday = Birthday;
//        }
//    }
//}
