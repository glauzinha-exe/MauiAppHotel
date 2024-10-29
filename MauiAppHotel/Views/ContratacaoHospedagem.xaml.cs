namespace MauiAppHotel.Views;

public partial class ContratacaoHospedagem : ContentPage
{
	public ContratacaoHospedagem()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		try
		{
			Navigation.PushAsync(new HospedagemContratada());

		}catch(Exception ex)
		{
			DisplayAlert("ops", ex.Message, "ok");
		}
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new Sobre());

        }
        catch (Exception ex)
        {
            DisplayAlert("ops", ex.Message, "ok");
        }

    }
}