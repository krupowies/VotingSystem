﻿using System;
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

namespace VotingWPF.Views
{
    /// <summary>
    /// Logika interakcji dla klasy CandidateDash.xaml
    /// </summary>
    public partial class CandidateDash : Window
    {
        public CandidateDash()
        {
            InitializeComponent();
        }

        private void CreateDesButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void OtherButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CheckResButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void GoBackButton_Click(object sender, RoutedEventArgs e)
        {
            Window startPanel = new MainWindow();
            this.Close();
            startPanel.Show();
        }
    }
}
