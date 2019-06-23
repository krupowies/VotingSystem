using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            this.Close();
            startPanel.Show();
        }

        private void RegisterButtonVoter_Click(object sender, RoutedEventArgs e)
        {
            DataBase lists = DataBase.Instance;
            int age = 0;
            Gender gender;
            string message = "ERROR";

            if(agetxt.Text != "" && Regex.IsMatch(agetxt.Text, "^[1-9][0-9][0-9]?$"))
            {
                Int32.TryParse(agetxt.Text, out age);
                if (age < 18)
                {
                    MessageBox.Show(message, "Age is invalid", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show(message, "Age is invalid", MessageBoxButton.OK, MessageBoxImage.Error);

            }

            if (male.IsChecked == true)
            {
                gender = Gender.MALE;
            }
            else if(female.IsChecked == true)
            {
                gender = Gender.FEMALE;

            }
            else if(other.IsChecked == true)
            {
                gender = Gender.OTHER;
            }
            else
            {
                 MessageBox.Show("Choose gender");
                return;
               
            }
            
          

          
                try
                {
                    lists.VoterService.AddVoter(usernametxt.Text, passwordtxt.Text, nametxt.Text, lastnametxt.Text, age, gender);

                }catch(Exception exe)
                {
                    MessageBox.Show(exe.Message, "Your username is already used", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            

            Window startPanel = new MainWindow();
            this.Close();
            startPanel.Show();
        }

        private void RegisterButtonCandidate_Click(object sender, RoutedEventArgs e)
        {
            DataBase lists = DataBase.Instance;
            
            Gender gender;
            int age = 0;
            string message = "ERROR";

            if (agetxt.Text != "" && Regex.IsMatch(agetxt.Text, "^[1-9][0-9][0-9]?$"))
            {
                Int32.TryParse(agetxt.Text, out age);
                if(age < 18)
                {
                    MessageBox.Show(message, "Age is invalid", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show(message, "Age is invalid", MessageBoxButton.OK, MessageBoxImage.Error);

            }


            if (male.IsChecked == true)
            {
                gender = Gender.MALE;
            }
            else if (female.IsChecked == true)
            {
                gender = Gender.FEMALE;

            }
            else if (other.IsChecked == true)
            {
                gender = Gender.OTHER;
            }
            else
            {
                MessageBox.Show("Choose gender");
                return;

            }
           

           
                try
                {
                    lists.VoterService.AddVoter(usernametxt.Text, passwordtxt.Text, nametxt.Text, lastnametxt.Text, age, gender);

                }
                catch (Exception exe)
                {
                    MessageBox.Show(exe.Message, "Your username is already used", MessageBoxButton.OK, MessageBoxImage.Error);
                }


            Window startPanel = new MainWindow();
            this.Close();
            startPanel.Show();
        }
    }
}