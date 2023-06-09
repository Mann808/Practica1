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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Practica1.PRACTICADataSetTableAdapters;

namespace Practica1
{
    public partial class MainWindow : Window
    {
        ClientsTableAdapter client = new ClientsTableAdapter();
        public MainWindow()
        {
            InitializeComponent();
            clientdatagrid.ItemsSource = client.GetData();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = new Clients();
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = new Orders();
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = new Payments();
        }

        private void PageFrame_Navigated(object sender, NavigationEventArgs e)
        {

        }
    }
}
