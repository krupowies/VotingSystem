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
    public partial class ElectionsPanel : Window ,ListView
    {
        Voter voter;

        internal Voter Voter { get => voter; set => voter = value; }

        public ElectionsPanel()
        {
            InitializeComponent();
        }

        private void GoBackButton_Click(object sender, RoutedEventArgs e)
        {
            Window startPanel = new MainWindow();
            this.Close();
            startPanel.Show();
        }

        private void ElectionList_Loaded(object sender, RoutedEventArgs e)
        {
            UpdateList();
        }

        private void ElectionList_PreviewMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (electionList.Items.Count != 0)
            {
                Election election = (Election)electionList.SelectedItems[0];
                DoTheVote vote = new DoTheVote();
                vote.Election = election;
                vote.Voter = voter;
                vote.Owner = this;
                vote.Show();
            }
        }

        public void UpdateList()
        {
            DataBase database = DataBase.Instance;
            List<Election> elections = database.ElectionService.ElectionRepository.getAll();
            electionList.Items.Clear();
            elections.ForEach(election =>
            {
                if(!election.VoterVoted(voter))
                electionList.Items.Add(election);
            });
        }
    }
}
