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

namespace Apteka
{
    /// <summary>
    /// Логика взаимодействия для LVPage.xaml
    /// </summary>
    public partial class LVPage : Page
    {
        public LVPage()
        {
            InitializeComponent();
            this.DataContext = this;

            Preparation.ItemsSource = DbConnection.db.Preparation.ToList();
        }

        private void BtAdd_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RedactPage());
        }

        private void BtDataG_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new DGPage());
        }
    }
}
