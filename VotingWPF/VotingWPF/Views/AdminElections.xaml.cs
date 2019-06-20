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
    /// Logika interakcji dla klasy AdminElections.xaml
    /// </summary>
    public partial class AdminElections : Window,ListView
    {
        DataBase database;
        public AdminElections()
        {
            InitializeComponent();
            this.database = DataBase.Instance;
        }

        private void AddEleButton_Click(object sender, RoutedEventArgs e)
        {
            AddElection addElection = new AddElection();
            addElection.Owner = this;
            addElection.Show();
        }

        private void DeleteEleButton_Click(object sender, RoutedEventArgs e)
        {
            if (electionList.Items.Count != 0)
            {
                Election election = (Election)electionList.SelectedItems[0];
                database.ElectionService.ElectionRepository.deleteElement(election.Id);
                UpdateList();
            }
        }

        private void ElectionList_PreviewMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (electionList.Items.Count != 0)
            {
                Election election = (Election)electionList.SelectedItems[0];
                ElectionDetail electionDetail = new ElectionDetail();
                electionDetail.Election = election;
                electionDetail.DisplayInfo();
                electionDetail.Owner = this;
                electionDetail.Show();
            }
        }

        private void ElectionList_Loaded(object sender, RoutedEventArgs e)
        {
            UpdateList();
        }
        public void UpdateList()
        {
            List<Election> elections = database.ElectionService.ElectionRepository.getAll();
            electionList.Items.Clear();
            elections.ForEach(election =>
            {
                electionList.Items.Add(election);
            });
        }
    }
}
