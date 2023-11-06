using TestMauiApp.ViewModels;

namespace TestMauiApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailPage : ContentPage
    {
        private DetailViewModel ViewModel => BindingContext as DetailViewModel;

        public DetailPage()
        {
            InitializeComponent();
            BindingContext = new DetailViewModel();
        }

        private void HideAllDetails()
        {
            ViewModel.IsButton1DetailsVisible = false;
            ViewModel.IsButton2DetailsVisible = false;
            ViewModel.IsButton3DetailsVisible = false;
        }

        private void RadioButton1_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (e.Value)
            {
                HideAllDetails();
                ViewModel.IsButton1DetailsVisible = true;
            }            
        }

        private void RadioButton2_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (e.Value)
            {
                HideAllDetails();
                ViewModel.IsButton2DetailsVisible = true;
            }
        }

        private void RadioButton3_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (e.Value)
            {
                HideAllDetails();
                ViewModel.IsButton3DetailsVisible = true;
            }
        }
    }
}