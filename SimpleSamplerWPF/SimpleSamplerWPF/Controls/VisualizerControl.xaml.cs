﻿using SimpleSamplerWPF.ViewModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SimpleSamplerWPF.Controls
{
    /// <summary>
    /// Interaction logic for VisualizerControl.xaml
    /// </summary>
    public partial class VisualizerControl : UserControl
    {
        public VisualizerControl()
        {
            InitializeComponent();
            DataContext = new VisualizerViewModel();
        }
    }
}
