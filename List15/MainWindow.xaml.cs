﻿using System;
using System.Windows;


namespace List15
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string[] listarray;
        int num = 0;
            double total = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            newlist();
            lblTellToAdd.Content = " Enter Items";
            btn1.Visibility = Visibility.Hidden;
            btn2.Visibility = Visibility.Visible;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (num+1 == listarray.Length) lblTellToAdd.Content = " Click Again to Revise List";
            if (num + 1 < listarray.Length) lblTellToAdd.Content = "Enter Item: " + (num + 2);

            addItem();
        }
        private void newlist()
        {
            listarray = new string[Convert.ToInt32(tboxItemAmount.Text)];
        }

        private void addItem()
        {
            if (num < listarray.Length)
            {
                total += Convert.ToDouble(tboxItemPrice.Text);
                listarray[num] = tboxItemAmount.Text + string.Format(" {0:c", Convert.ToDouble(tboxItemPrice.Text));
                num++;
            }
            else
            {
                foreach (string x in listarray)
                {
                    labelList.Content += x + "\n";
                }
                labelTotal.Content = string.Format("Total is: {0:c}", total);

                tboxItemPrice.Text = null;
               tboxItemName.Text = null;

            }
        }
    }
}
