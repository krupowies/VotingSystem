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

namespace VotingWPF
{
    /// <summary>
    /// Logika interakcji dla klasy AdminEnter.xaml
    /// </summary>
    public partial class AdminEnter : Window
    {
        public AdminEnter()
        {
            InitializeComponent();
        }

        private void GoBackButton_Click(object sender, RoutedEventArgs e)
        {
            Window startPanel = new MainWindow();
            this.Hide();
            startPanel.Show();
        }

        private void EnterButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}