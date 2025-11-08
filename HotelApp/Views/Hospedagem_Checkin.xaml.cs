namespace HotelApp.Views
{
    public partial class Hospedagem_Checkin : ContentPage
    {
        public Hospedagem_Checkin()
        {
            InitializeComponent();
        }

        private async void OnSobreClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.Sobre.SobrePage());
        }


    }
}