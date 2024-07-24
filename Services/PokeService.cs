using System.Net.Http.Json;

namespace PokedexApp.Services
{
    public class PokeService
    {
        HttpClient httpClient;

        public PokeService()
        {
            httpClient = new HttpClient();
        }

        List<Pokemon> pokemonList = new ();
        public async Task<List<Pokemon>> GetPokemons()
        {
            if(pokemonList?.Count > 0)
                return pokemonList;

            var url = "https://raw.githubusercontent.com/aSilvaCodes/PokedexApp/CollectionView/PokeTest.json?token=GHSAT0AAAAAACUKIPU6UUPAU4DLLNWHNGPUZVAI4FA";

            var response = await httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                pokemonList = await response.Content.ReadFromJsonAsync<List<Pokemon>>();
            }

            return pokemonList;
        }
    }
}
