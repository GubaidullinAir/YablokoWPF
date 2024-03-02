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
using infoSysBackOffice.Views;

namespace infoSysBackOffice
{

    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using (partYablokoEntities1 db = new partYablokoEntities1())
            {
                foreach (var entity in db.users)
                {
                    if (true)//txtUsername.Text==entity.email && txtpassword.Password == entity.password)
                    {
                        DoubleAnimation doubleAnimation = new DoubleAnimation();
                        doubleAnimation.From = 400; // height
                        doubleAnimation.To = 0;
                        doubleAnimation.Duration = TimeSpan.FromMilliseconds(500);
                        doubleAnimation.Completed += changing;
                        wind.BeginAnimation(Window.HeightProperty, doubleAnimation);

                    }
                }
            }
        }


        private void changing(object sender, EventArgs e)
        {
            this.Hide();
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();

        }

    }
}
