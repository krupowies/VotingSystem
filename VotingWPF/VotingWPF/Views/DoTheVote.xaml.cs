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

namespace VotingWPF.Views
{
    public partial class DoTheVote : Window
    {
        Election election;
        Voter voter;
        public DoTheVote()
        {
            InitializeComponent();
        }

        internal Election Election { get => election; set => election = value; }
        internal Voter Voter { get => voter; set => voter = value; }

        internal void UpdateList()
        {
            Question.Text = election.Question;

            List<ElectionOption> elections = election.Candidates;
            electionList.Items.Clear();
            elections.ForEach(election =>
            {
                electionList.Items.Add(election.Candidate);
            });
            // throw new NotImplementedException();
        }

        private void Vote_Click(object sender, RoutedEventArgs e)
        {
            if (electionList.Items.Count != 0)
            {
                Candidate candidate = (Candidate)electionList.SelectedItems[0];
                election.Voting(Voter, candidate);
            }
               

            ElectionsPanel panel = (ElectionsPanel)this.Owner;
            panel.UpdateList();
            this.Close();
        }

        private void ElectionList_Loaded(object sender, RoutedEventArgs e)
        {
            UpdateList();
        }
    }
}
