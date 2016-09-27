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

namespace BD
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

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService ns = NavigationService.GetNavigationService(this);
            ns.Navigate(new Uri("StartPage.xaml", UriKind.Relative));
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            if (nameTxtBox.Text == "" || textBoxSecondName.Text == "" || firstNameTxtBox.Text == "" || lastNameTxtBox.Text == "")
            {
                MessageBox.Show("Заполните полностью анкету");
            }

            else
            {
                NavigationService ns = NavigationService.GetNavigationService(this);
                ns.Navigate(new Uri("StartPage.xaml", UriKind.Relative));
            }
        }

        private void nameTxtBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

      
    }
}
