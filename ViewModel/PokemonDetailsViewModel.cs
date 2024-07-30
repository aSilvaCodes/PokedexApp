namespace PokedexApp.ViewModel
{
    [QueryProperty("Pokemon", "Pokemon")]
    public partial class PokemonDetailsViewModel: BaseViewModel
    {
        public PokemonDetailsViewModel()
        {
        }

        [ObservableProperty]
        Pokemon pokemon;

        [ObservableProperty]
        bool isVis = true;

        [RelayCommand]
        void SwitchIsVis()
        {
            IsVis = !IsVis;
        }

        [RelayCommand]
        async Task GoBackAsync()
        {
            await Shell.Current.GoToAsync("..", false);
        }
    }
}
