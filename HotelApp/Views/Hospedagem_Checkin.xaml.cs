namespace HotelApp.Views
{
    public partial class Hospedagem_Checkin : ContentPage
    {
        public Hospedagem_Checkin()
        {
            InitializeComponent();
        }



        private async void OnHospedagemContratadaClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HotelApp.Views.HospedagemContratada.HospedagemContratadaPage());
        }

        private async void OnSobreClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.Sobre.SobrePage());
        }



    }
}