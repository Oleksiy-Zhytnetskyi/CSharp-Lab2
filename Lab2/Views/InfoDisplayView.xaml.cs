﻿using KMA.CSharp2024.Lab2.ViewModels;
using System.Windows.Controls;

namespace KMA.CSharp2024.Lab2.Views
{
    /// <summary>
    /// Interaction logic for InfoDisplayView.xaml
    /// </summary>
    public partial class InfoDisplayView : UserControl
    {
        public InfoDisplayView(InfoDisplayViewModel viewModel)
        {
            InitializeComponent();

            DataContext = viewModel;
        }
    }
}
