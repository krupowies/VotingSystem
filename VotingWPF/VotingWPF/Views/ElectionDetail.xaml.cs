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

namespace VotingWPF.Views
{
    /// <summary>
    /// Logika interakcji dla klasy ElectionDetail.xaml
    /// </summary>
    public partial class ElectionDetail : Window
    {
        private Election election;

        internal Election Election { get => election; set => election = value; }

        public ElectionDetail()
        {
            InitializeComponent();
        }

        public void DisplayInfo()
        {
            Elenametxt.Text = election.Name;
            Questiontxt.Text = election.Question;
        }
        private void GoBackButton_Click(object sender, RoutedEventArgs e)
        {

        }
        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ElectionList_Loaded(object sender, RoutedEventArgs e)
        {

        }
      
        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            DataBase db = DataBase.Instance;
            string username = CandidateInput.Text;
            Candidate candidate = db.CandidateService.FindCandidateByUsername(username);
            if(candidate == null)
            {

            }
            else
            {
                election.AddOption(candidate);
                //UpdateThisList()
            }

        }
    }
}
