using PokedexApp.Services;

namespace PokedexApp.ViewModel
{
    public partial class PokemonViewModel : BaseViewModel
    {
        PokeService pokeService;
        public ObservableCollection<Pokemon> Pokemons { get; } = new();

        public PokemonViewModel(PokeService pokeService)
        {
            this.Title = "Pokedex Classic";
            this.pokeService = pokeService;
        }

        [RelayCommand]
        async Task GoToDetailsAsync(Pokemon pokemon)
        {
            if(pokemon is null)
                return;

            await Shell.Current.GoToAsync($"{nameof(DetailsPage)}", true, 
                new Dictionary<string, object>
                {
                    {"Pokemon", pokemon}
                });
        }

        [RelayCommand]
        async Task GetPokemonAsync()
        {
            if (IsBusy)
                return;

            try
            {
                IsVisible = !IsVisible;
                IsBusy = true;
                var pokemons = await pokeService.GetPokemons();

                if (Pokemons.Count != 0)
                    Pokemons.Clear();

                foreach (var pokemon in pokemons) 
                    Pokemons.Add(pokemon);
            }
            catch (Exception e)
            { 
                Debug.WriteLine(e);
                await Shell.Current.DisplayAlert("Error!", $"Failed to get pokemon: {e.Message}", "OK");
            }
            finally 
            {
                IsBusy = false;
            }
        }
    }
}
