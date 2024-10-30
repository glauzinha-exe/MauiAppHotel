namespace MauiAppHotel.Views;

public partial class Sobre : ContentPage
{
	public Sobre()
	{
		InitializeComponent();
	}

    private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
    {
        var url = "https://github.com/glauzinha-exe";  
        await Launcher.OpenAsync(url);     
    }

    private async void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
    {
        var url = "https://www.linkedin.com"; 
        await Launcher.OpenAsync(url);       
    }

    private async void TapGestureRecognizer_Tapped_2(object sender, TappedEventArgs e)
    {
        var url = "https://github.com/glauzinha-exe/MauiAppHotel";
        await Launcher.OpenAsync(url);
    }

    private void Button_Pressed(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new ContratacaoHospedagem());

        }
        catch (Exception ex)
        {
            DisplayAlert("ops", ex.Message, "ok");
        }
    }
}