using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Media.Imaging;

namespace infoSysBackOffice.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool gridmen = false;

        public MainWindow()
        {
            //session session = new session();
            InitializeComponent();

            frame.Source = new Uri("pack://application:,,,/Pages/MainPage.xaml");

            DataContext = new AdmissionViewModel();
            //DoubleAnimation doubleAnimation = new DoubleAnimation();
            //doubleAnimation.From = 0; 
            //doubleAnimation.To = 800;
            //doubleAnimation.Duration = TimeSpan.FromMilliseconds(500);
            //wind.BeginAnimation(Window.WidthProperty, doubleAnimation);

            //using (partYablokoEntities1 db = new partYablokoEntities1())
            //{
            //    var user = db.users.Find(session.userId);
            //    var userLinkId = db.profilesLinks.Find(session.userId);

            //    profilesPhoto.Source = new BitmapImage(new Uri(userLinkId.link));


            //    labelName.Content = user.surname + " " + user.name+" "+user.otchestvo;
            //    labelCity.Content = user.city;
            //    labelEmail.Content = user.email;
            //    labelTelephone.Content= user.telephone;
            //    labelDolz.Content = user.dolz;




            //}
        }

        private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e)
        {

            if (!isGridClosed)
            {
                DoubleAnimation doubleAnimation = new DoubleAnimation();
                doubleAnimation.From = 70;
                doubleAnimation.To = 215;
                doubleAnimation.Duration = TimeSpan.FromMilliseconds(350);
                grid.BeginAnimation(Grid.WidthProperty, doubleAnimation);
                isGridClosed = true;
            }
            else
            {
                DoubleAnimation doubleAnimation = new DoubleAnimation();
                doubleAnimation.From = 215;
                doubleAnimation.To = 70;
                doubleAnimation.Duration = TimeSpan.FromMilliseconds(350);
                grid.BeginAnimation(Grid.WidthProperty, doubleAnimation);
                isGridClosed = false;
            }
        }


       
        public bool isGridClosed
        {
            get { return gridmen; }
            set { gridmen = value; }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            session session = new session();
            session.sessionId = 0;
            this.Hide();
            login.Show();
        }

        private void ItemCreate_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Uri uri = new Uri("pack://application:,,,/Pages/Users.xaml");
            frame.Source = uri;
        }

        private void ListViewItem_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Uri uri = new Uri("pack://application:,,,/Pages/Users.xaml");
            frame.Source = uri;
        }

        private void Settings_Click(object sender, RoutedEventArgs e)
        {
            Uri uri = new Uri("pack://application:,,,/Pages/Settings.xaml");
            frame.Source = uri;
        }

        private void ListViewItem_MouseDoubleClick_2(object sender, MouseButtonEventArgs e)
        {
            Uri uri = new Uri("pack://application:,,,/Pages/Materials.xaml");
            frame.Source = uri;
        }

        private void Create_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Uri uri = new Uri("pack://application:,,,/Pages/Users.xaml");
            frame.Source = uri;
        }

        private void ListViewItem_MouseDoubleClick_1(object sender, MouseButtonEventArgs e)
        {
            Uri uri = new Uri("pack://application:,,,/Pages/Admission.xaml");
            frame.Source = uri;
        }
    }
}

