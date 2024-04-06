using KMA.CSharp2024.Lab2.ViewModels;
using System.Windows;

namespace KMA.CSharp2024.Lab2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DataContext = new MainWindowViewModel(Content);
        }
    }
}