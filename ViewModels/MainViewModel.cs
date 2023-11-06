using System.Windows.Input;

namespace TestMauiApp.ViewModels
{
    public class MainViewModel : MvvmHelpers.BaseViewModel
    {
        public MainViewModel() { }

        public ICommand ButtonCommand => new MvvmHelpers.Commands.AsyncCommand(ButtonAsync);

        private async Task ButtonAsync() => await Shell.Current.GoToAsync($"/{nameof(DetailPage)}");
    }
}
