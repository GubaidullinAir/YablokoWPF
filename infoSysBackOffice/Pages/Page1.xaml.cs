//using System;
//using System.Collections.Generic;
//using System.Collections.ObjectModel;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows;
//using System.Windows.Controls;
//using System.Windows.Data;
//using System.Windows.Documents;
//using System.Windows.Input;
//using System.Windows.Media;
//using System.Windows.Media.Imaging;
//using System.Windows.Navigation;
//using System.Windows.Shapes;

//namespace infoSysBackOffice.Pages
//{
//    /// <summary>
//    /// Логика взаимодействия для Users.xaml
//    /// </summary>
//    public partial class Users : Page
//    {
//        public ObservableCollection<AdmissionViewModel> User { get; set; }

//        public Users()
//        {
//            DateTime rozhdenie = new DateTime(2004, 06, 16);
//            AdmissionViewModel admission = new AdmissionViewModel(1, "Timur", "Uteev", rozhdenie);

//            AdmissionViewModel admision = new AdmissionViewModel(2, "Airat", "Gubaidullin", rozhdenie);

//            AdmissionViewModel admisn = new AdmissionViewModel(3, "Arslan", "Galiev", rozhdenie);


//            User = new ObservableCollection<AdmissionViewModel>();
//            User.Add(admission);
//            User.Add(admision);
//            User.Add(admisn);


//            InitializeComponent();
//            DataContext = User;

//        }

//        private void Button_Click(object sender, RoutedEventArgs e)
//        {
//            Button button = (Button)sender;
//            Grid userDetailsGrid = this.FindName("userDetailsGrid") as Grid;

//            if (button != null && userDetailsGrid != null)
//            {
//                userDetailsGrid.Visibility = Visibility.Visible;

//                // Получите соответствующего пользователя из выбранного элемента ListBox
//                AdmissionViewModel selectedUser = button.DataContext as AdmissionViewModel;

//                // Отобразите подробную информацию о пользователе в элементах Grid
//                if (selectedUser != null)
//                {
//                    Label region = userDetailsGrid.Children[0] as Label;
//                    Label local = userDetailsGrid.Children[1] as Label;
//                    Label fullname = userDetailsGrid.Children[2] as Label;
//                    Label phone = userDetailsGrid.Children[3] as Label;
//                    Label gender = userDetailsGrid.Children[4] as Label;
//                    Label birthday = userDetailsGrid.Children[5] as Label;

//                    region.Content = $"Региональное отделение: {selectedUser.Region}";
//                    local.Content = $"Местное отделение: {selectedUser.Local}";
//                    fullname.Content = $"ФИО: {selectedUser.FirstName} {selectedUser.LastName}";
//                    phone.Content = $"Телефон: {selectedUser.Phone}";
//                    gender.Content = $"Пол: {selectedUser.Gender}";
//                    birthday.Content = $"Дата рождения: {selectedUser.Birthday.ToString("dd.MM.yyyy")}";
//                }
//            }
//        }

//        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
//        {

//        }
//    }
//}
