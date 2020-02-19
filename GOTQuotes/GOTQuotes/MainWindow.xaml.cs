﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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

namespace GOTQuotes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


            imgGOTBackground.Source = new BitmapImage(new Uri("https://wallpaperaccess.com/full/25485.jpg"));
            
            //
        }

        private void BtnRandomQuote_Click(object sender, RoutedEventArgs e)
        {
            string path = "https://got-quotes.herokuapp.com/quotes";
            GOT gotQuote;
            using (var client = new HttpClient())
            {
                string json = client.GetStringAsync(path).Result;

                gotQuote = JsonConvert.DeserializeObject<GOT>(json);

            }
            lstGOTQuote.Items.Add(gotQuote);
            //lstGOTQuote.Items.Clear();
        }
    }
}
