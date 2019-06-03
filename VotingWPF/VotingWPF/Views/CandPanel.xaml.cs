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

namespace VotingWPF
{
    /// <summary>
    /// Logika interakcji dla klasy CandPanel.xaml
    /// </summary>
    public partial class CandPanel : Window
    {
        public CandPanel()
        {
            InitializeComponent();
        }

        private void GoLogButton_Click(object sender, RoutedEventArgs e)
        {
            Window logPanel = new Login();
            this.Hide();
            logPanel.Show();
        }
        private void GoRegButton_Click(object sender, RoutedEventArgs e)
        {
            Window regPanel = new Register();
            this.Hide();
            regPanel.Show();
        }

        private void GoBackButton_Click(object sender, RoutedEventArgs e)
        {
            Window startPanel = new MainWindow();
            this.Hide();
            startPanel.Show();
        }

    }
}
