using eHairdresserSalon_PCL.Model;
using eHairdresserSalon_PCL.Util;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eHairdresserSalonSolution
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PregledTretmana : ContentPage
    {
        private WebAPIHelper dodatniTretmaniService = new WebAPIHelper(Global.APIAddress, Global.DodatniTretmaniRoute);
        private WebAPIHelper vrsteUslugaService = new WebAPIHelper(Global.APIAddress, Global.VrsteUslugaRoute);
        
        public PregledTretmana()
        {
            InitializeComponent();

            List<VrsteUsluga_Result> vrsteUsluga = new List<VrsteUsluga_Result>();
            HttpResponseMessage responseVrsteUsluga = vrsteUslugaService.GetResponse();
            if (responseVrsteUsluga.IsSuccessStatusCode)
            {
                var jsonObject = responseVrsteUsluga.Content.ReadAsStringAsync();
                vrsteUsluga = JsonConvert.DeserializeObject<List<VrsteUsluga_Result>>(jsonObject.Result);
                vrstaUslugePicker.ItemsSource = vrsteUsluga;
                vrstaUslugePicker.ItemDisplayBinding = new Binding("Naziv");
            }
            vrstaUslugePicker.SelectedIndex = 0;

            //HttpResponseMessage responseTretmani = dodatniTretmaniService.GetActionResponse("GetTretmaniOcjene");
            //if (responseTretmani.IsSuccessStatusCode)
            //{
            //    var jsonObject = responseTretmani.Content.ReadAsStringAsync();
            //    List<DodatniTretmani_Ocjene_Result> tretmani = JsonConvert.DeserializeObject<List<DodatniTretmani_Ocjene_Result>>(jsonObject.Result);

            //    listaTretmana.ItemsSource = tretmani;
            //}

            int vrstaUslugeId = (vrstaUslugePicker.SelectedItem as VrsteUsluga_Result).VrstaUslugeID;
            HttpResponseMessage responseTretmani = dodatniTretmaniService.GetActionResponse("SearchByVrstaUsluge", vrstaUslugeId.ToString());
            if (responseTretmani.IsSuccessStatusCode)
            {
                var jsonObject = responseTretmani.Content.ReadAsStringAsync();
                List<DodatniTretmani_Ocjene_Result> tretmani = JsonConvert.DeserializeObject<List<DodatniTretmani_Ocjene_Result>>(jsonObject.Result);

                listaTretmana.ItemsSource = tretmani;
            }
        }

        private void vrstaUslugePicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            int vrstaUslugeId = (vrstaUslugePicker.SelectedItem as VrsteUsluga_Result).VrstaUslugeID;
            HttpResponseMessage responseTretmani = dodatniTretmaniService.GetActionResponse("SearchByVrstaUsluge", vrstaUslugeId.ToString());
            if (responseTretmani.IsSuccessStatusCode)
            {
                var jsonObject = responseTretmani.Content.ReadAsStringAsync();
                List<DodatniTretmani_Ocjene_Result> tretmani = JsonConvert.DeserializeObject<List<DodatniTretmani_Ocjene_Result>>(jsonObject.Result);

                listaTretmana.ItemsSource = tretmani;
            }
        }

        private void listaTretmana_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if(e.Item!= null)
            {
                this.Navigation.PushAsync(new DetaljiTretmana(e.Item as DodatniTretmani_Ocjene_Result));
            }
        }
    }
}