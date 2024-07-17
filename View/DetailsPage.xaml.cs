namespace PokedexApp.View;

public partial class DetailsPage : ContentPage
{
	public DetailsPage(PokemonDetailsViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}