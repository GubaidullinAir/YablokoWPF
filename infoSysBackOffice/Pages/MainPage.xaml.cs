using System;
using System.Collections.Generic;
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

namespace infoSysBackOffice.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
            ShowsNavigationUI = false;
            session session = new session();
            //using (partYablokoEntities1 db = new partYablokoEntities1())
            //{
            //    session.sessionId = 0;
            //    user user = db.users.Find(session.sessionId);
            //    labelName.Content = user.surname + " " + user.name+ " "+ user.otchestvo;
            //    labelCity.Content = user.city;
            //    labelDolz.Content = user.dolz;
            //    labelEmail.Content = user.email;
            //    labelTelephone.Content = user.telephone;

            //    session.sessionId = 1;
            //    profilesLink link = db.profilesLinks.Find(session.sessionId);
            //    Uri uri = new Uri(link.link, UriKind.Absolute);
            //    ImageSource imageSource = new BitmapImage(uri);
            //    profilesPhoto.Source = imageSource;
            //}
        }

        
    }
}
