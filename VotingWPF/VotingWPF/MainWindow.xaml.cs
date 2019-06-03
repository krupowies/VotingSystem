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

namespace VotingWPF
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void GoVoteButton_Click(object sender, RoutedEventArgs e)
        {
            Window votePanel = new VoterPanel();
            this.Hide();
            votePanel.Show();
        }

        private void GoCandButton_Click(object sender, RoutedEventArgs e)
        {
            Window candPanel = new CandPanel();
            this.Hide();
            candPanel.Show();
        }


        private void GoAdminButton_Click(object sender, RoutedEventArgs e)
        {
            Window adminEnter = new AdminEnter();
            this.Hide();
            adminEnter.Show();
        }
    }
}
