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

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void radioButton1_Checked(object sender, RoutedEventArgs e)
        {

        }
        private void radioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (radioButton1.IsChecked == true)
            {
                MessageBox.Show("Hello");
            }
            else
            {
                radioButton.IsChecked = true;
                MessageBox.Show("Goodbye");
            }

        }

        private void radioButton2_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
            
}

