namespace PokedexApp.ViewModel
{
    public partial class BaseViewModel : ObservableObject
    {
        public BaseViewModel() 
        {
            
        }

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(IsNotBusy))]
        bool isBusy;

        [ObservableProperty]
        string title;

        [ObservableProperty]
        bool isVisible;

        public bool IsNotBusy => !IsBusy;
    }
}
