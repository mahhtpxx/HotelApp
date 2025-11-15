namespace HotelApp.Views
{
    public partial class Hospedagem_Checkin : ContentPage
    {
        App PropriedadesApp;


        public Hospedagem_Checkin()
        {
            InitializeComponent();

            PropriedadesApp = (App)Application.Current;

            Suíte.ItemsSource = PropriedadesApp.lista_quartos;

            dt_check_out.MinimumDate = DateTime.Now;
            dt_check_out.MaximumDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month + 1, DateTime.Now.Day);

            dt_check_out.MinimumDate = dtof_checkin.Date.AddDays(1);
            dt_check_out.MaximumDate = dtof_checkin.Date.AddMonths(6);
        }



        private async void OnHospedagemContratadaClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HotelApp.Views.HospedagemContratada.HospedagemContratadaPage());
        }

        private async void OnSobreClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.Sobre.SobrePage());
        }


        private void dtpck_checkin_DateSelected(object sender, DateChangedEventArgs e)
        {
            DatePicker elemento = sender as DatePicker;

            DateTime data_selecionada_checkin = elemento.Date;

            dt_check_out.MinimumDate = data_selecionada_checkin.AddDays(1);
            dt_check_out.MaximumDate = data_selecionada_checkin.AddMonths(6);
        }

    }
}