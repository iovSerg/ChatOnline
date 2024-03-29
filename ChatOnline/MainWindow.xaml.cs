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

namespace ChatOnline
{
    public partial class MainWindow : Window
    {
        ViewApplication view;
        public MainWindow()
        {
            InitializeComponent();
            ImageBrush brush = new ImageBrush(new BitmapImage(new Uri("2.jpg",UriKind.Relative)));
            brush.Stretch = Stretch.Fill;
            this.Background = brush;
            DataContext = view = new ViewApplication(textMsg);
            Closing += (s, e) => { view.client.Close(); };
        }
    }
}
