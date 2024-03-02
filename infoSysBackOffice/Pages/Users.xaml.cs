using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using infoSysBackOffice.Views;

namespace infoSysBackOffice.Pages
{
    /// <summary>
    /// Логика взаимодействия для Users.xaml
    /// </summary>
    public partial class Users : Page
    {
        public ObservableCollection<AdmissionViewModel> User { get; set; }

        public Users()
        {
            DateTime rozhdenie = new DateTime(2004, 06, 16);
            AdmissionViewModel admission = new AdmissionViewModel(1, "Timur", "Uteev", rozhdenie);

            AdmissionViewModel admision = new AdmissionViewModel(2, "Airat", "Gubaidullin", rozhdenie);

            AdmissionViewModel admisn = new AdmissionViewModel(3, "Arslan", "Galiev", rozhdenie);


            User = new ObservableCollection<AdmissionViewModel>();
            User.Add(admission);
            User.Add(admision);
            User.Add(admisn);


            InitializeComponent();
            DataContext = User;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AdmissionViewModel selectedUser = listik.SelectedItem as AdmissionViewModel;

            if (selectedUser != null)
            {
                // Здесь выполняется ваш код для удаления пользователя
                // Например, вызов метода удаления или обработка события удаления пользователя

                // Удаляем пользователя из коллекции
                User.Remove(selectedUser);
            }
            //// Получаем выбранный элемент

            // Проверяем, что элемент выбран
            if (selectedUser != null)
            {

                // Выводим выбранный элемент в MessageBox
                MessageBox.Show($"Удален пользователь: {selectedUser.FirstName} {selectedUser.LastName}");
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox searchTextBox = (TextBox)sender;
            string searchText = searchTextBox.Text.ToLower();

            // Фильтруем коллекцию пользователей
            var filteredUsers = User.Where(u => u.FirstName.ToLower().Contains(searchText) || u.LastName.ToLower().Contains(searchText));

            // Обновляем источник данных для отображения результатов поиска
            listik.ItemsSource = new ObservableCollection<AdmissionViewModel>(filteredUsers);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
