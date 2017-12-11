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
using WpfShippingService.ViewModels;

namespace WpfShippingService
{
    /// <summary>
    /// Interaction logic for ShippingView.xaml
    /// </summary>
    public partial class ShippingView : Window
    {
        public ShippingView(BaseViewModel bvm)
        {
            

            InitializeComponent();
            this.DataContext = bvm;
        }
    }
}
