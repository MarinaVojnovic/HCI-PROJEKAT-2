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

namespace ResourcesApplication
{
    /// <summary>
    /// Interaction logic for Maps.xaml
    /// </summary>
    public partial class Maps : Window
    {
        public Maps()
        {
            InitializeComponent();
        }

        private void worldButton_Click(object sender, RoutedEventArgs e)
        {
            AddTag tag = new AddTag();
            tag.Show();
        }
    }
}
