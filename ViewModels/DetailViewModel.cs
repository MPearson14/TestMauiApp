namespace TestMauiApp.ViewModels
{
    public enum DetailViewStep
    {
        None = 0,
        Type = 1,
        Search = 2
    }

    public class DetailViewModel : MvvmHelpers.BaseViewModel
    {
        public DetailViewModel() { }

        private IEnumerable<short> _CarouselData = new List<short> { (short)DetailViewStep.Type, (short)DetailViewStep.Search };
        private int _IndicatorPosition = 0;    
        private bool _IsButton1DetailsVisible = true;
        private bool _IsButton2DetailsVisible = false;
        private bool _IsButton3DetailsVisible = false;

        public IEnumerable<short> CarouselData
        {
            get => _CarouselData;
            set => SetProperty(ref _CarouselData, value);
        }

        public int IndicatorItemCount => 2;

        public int IndicatorPosition
        {
            get => _IndicatorPosition;
            set => SetProperty(ref _IndicatorPosition, value);
        }

        public bool IsButton1DetailsVisible
        {
            get => _IsButton1DetailsVisible;
            set => SetProperty(ref _IsButton1DetailsVisible, value);
        }

        public bool IsButton2DetailsVisible
        {
            get => _IsButton2DetailsVisible;
            set => SetProperty(ref _IsButton2DetailsVisible, value);
        }

        public bool IsButton3DetailsVisible
        {
            get => _IsButton3DetailsVisible;
            set => SetProperty(ref _IsButton3DetailsVisible, value);
        }
    }
}
