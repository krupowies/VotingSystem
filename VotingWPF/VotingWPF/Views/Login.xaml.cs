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
    /// Logika interakcji dla klasy Register.xaml
    /// </summary>
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
            Lists lists = Lists.Instance;
            Button roleCheck = sender as Button;
            if (roleCheck.Name == "GoVoteButton")
            {
                if (lists.UserService.loginVoter(logintxt.Text, passwordtxt.Text) == true)
                {
                    //tutaj idziemy do panelu glosowania
                }
                else
                {
                    MessageBox.Show("Incorrect login or password");
                    return;
                }
                
            }
            else
            {
                if(lists.UserService.loginCandidate(logintxt.Text, passwordtxt.Text) == true)
                {
                    //tutaj idziemy do panelu glosowania 
                }
                else
                {
                    MessageBox.Show("Incorrect login or password");
                    return;
                }
            }
        }
    }
}
