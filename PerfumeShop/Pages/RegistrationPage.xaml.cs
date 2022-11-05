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
using PerfumeShop.DataBase;
using PerfumeShop.Classes;

namespace PerfumeShop.Pages
{
    /// <summary>
    /// Логика взаимодействия для RegistrationPage.xaml
    /// </summary>
    public partial class RegistrationPage : Page
    {
        public RegistrationPage()
        {
            InitializeComponent();
        }

        private void Autorization_Click(object sender, RoutedEventArgs e)
        {
            string login = TBLogin.Text;
            string password = TBPassword.Text;
            List<Users> listUsers = PerfumeShopEntities.GetContext().Users.ToList();
            foreach(Users user in listUsers)
            {
                if (user.Login == login && user.Password == password)
                {
                    if (user.Role == "Администратор")
                    {
                        Manager.MainFrame.Navigate(new ProductsPage());
                    }
                }
            }
        }

        private void Registration_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
