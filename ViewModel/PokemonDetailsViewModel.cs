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
    }
}
