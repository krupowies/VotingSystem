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
using VotingWPF.Classes;
using VotingWPF.Service;
using VotingWPF.Views;

namespace VotingWPF
{
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void GoBackButton_Click(object sender, RoutedEventArgs e)
        {
            Window startPanel = new MainWindow();
            this.Close();
            startPanel.Show();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            DataBase lists = DataBase.Instance;
            Button roleCheck = sender as Button;
            if (roleCheck.Name == "LoginButton")
            {
                Voter voter = lists.VoterService.Login(logintxt.Text, passwordtxt.Text);
                if (voter != null)
                {
                    ElectionsPanel electionsPanel = new ElectionsPanel();
                    electionsPanel.Voter = voter;
                    electionsPanel.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Incorrect login or password");
                    return;
                }
                
            }
            else
            {
            }
        }
    }
}
