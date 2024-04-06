using KMA.CSharp2024.Lab2.ViewModels;
using System.Windows.Controls;

namespace KMA.CSharp2024.Lab2.Views
{
    /// <summary>
    /// Interaction logic for LandingView.xaml
    /// </summary>
    public partial class LandingView : UserControl
    {
        public LandingView()
        {
            InitializeComponent();

            DataContext = new LandingViewModel();
        }

        private void DpOnSelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DataContext is LandingViewModel viewModel)
            {
                viewModel.BirthDate = (sender as DatePicker)?.SelectedDate ?? default;
            }
        }
    }
}
