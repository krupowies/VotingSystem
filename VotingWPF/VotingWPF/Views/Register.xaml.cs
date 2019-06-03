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

namespace VotingWPF
{
    /// <summary>
    /// Logika interakcji dla klasy Registert.xaml
    /// </summary>
    public partial class Register : Window
    {
        public Register()
        {
            InitializeComponent();
        }

        private void GoBackButton_Click(object sender, RoutedEventArgs e)
        {
            Window startPanel = new MainWindow();
            this.Hide();
            startPanel.Show();
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            Lists lists = Lists.Instance;
            Role role;
            Gender gender;
            Button roleCheck = sender as Button;
            if(roleCheck.Name == "GoVoteButton")
            {
                role = Role.VOTER;
            }
            else
            {
                role = Role.CANDIDATE;
            } 

            if (male.IsChecked == true)
            {
                gender = Gender.MALE;
                MessageBox.Show("MALE");
            }
            else if(female.IsChecked == true)
            {
                gender = Gender.FEMALE;
                MessageBox.Show("FEMALE");

            }
            else if(other.IsChecked == true)
            {
                gender = Gender.OTHER;
                MessageBox.Show("OTHER");
            }
            else
            {
                 MessageBox.Show("Choose gender");
                return;
               
            }
            string description = "";
            int age = 0;
            Int32.TryParse(agetxt.Text, out age);
            lists.UserService.addUser(role, usernametxt.Text, passwordtxt.Text, nametxt.Text, lastnametxt.Text, age, gender,description);

            Window startPanel = new MainWindow();
            this.Hide();
            startPanel.Show();
        }
    }
}