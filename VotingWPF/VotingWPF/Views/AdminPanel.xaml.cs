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
using System.Windows.Shapes;
using VotingWPF.Views;

namespace VotingWPF
{
    /// <summary>
    /// Logika interakcji dla klasy AdminPanel.xaml
    /// </summary>
    public partial class AdminPanel : Window
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void GoBackButton_Click(object sender, RoutedEventArgs e)
        {
            Window startPanel = new MainWindow();
            this.Hide();
            startPanel.Show();
        }

        private void CreateEleButton_Click(object sender, RoutedEventArgs e)
        {
            AdminElections adminelection = new AdminElections();
            adminelection.Show();
            this.Close();
        }

        private void GoManageButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CheckResButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
