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
	public partial class PregledFrizera : ContentPage
	{
        private WebAPIHelper frizeriService = new WebAPIHelper(Global.APIAddress, Global.frizeriRoute);
        private WebAPIHelper vrsteUslugaService = new WebAPIHelper(Global.APIAddress, Global.VrsteUslugaRoute);


        public PregledFrizera ()
		{
			InitializeComponent ();

            NavigationPage.SetHasNavigationBar(this, true);


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

            int vrstaUslugeId = (vrstaUslugePicker.SelectedItem as VrsteUsluga_Result).VrstaUslugeID;
            HttpResponseMessage responseFrizeri = frizeriService.GetActionResponse("SearchByVrstaUsluge", vrstaUslugeId.ToString());
            if (responseFrizeri.IsSuccessStatusCode)
            {
                var jsonObject = responseFrizeri.Content.ReadAsStringAsync();
                List<Frizeri_Result> frizeri = JsonConvert.DeserializeObject<List<Frizeri_Result>>(jsonObject.Result);
                foreach (var item in frizeri)
                {
                    if (item.UslugaOcjena == null && item.TretmanOcjena != null)
                        item.ProsjecnaOcjena = item.TretmanOcjena;
                    else if (item.UslugaOcjena != null && item.TretmanOcjena == null)
                        item.ProsjecnaOcjena = item.UslugaOcjena;
                    else
                        item.ProsjecnaOcjena = (item.UslugaOcjena + item.TretmanOcjena) / 2;

                }
                listaFrizera.ItemsSource = frizeri;
            }

            //HttpResponseMessage responseFrizeri = frizeriService.GetResponse();
            //if(responseFrizeri.IsSuccessStatusCode)
            //{
            //    var jsonObject = responseFrizeri.Content.ReadAsStringAsync();
            //    List<Frizeri_Result> frizeri = JsonConvert.DeserializeObject<List<Frizeri_Result>>(jsonObject.Result);
            //    foreach (var item in frizeri)
            //    {
            //        if (item.UslugaOcjena == null && item.TretmanOcjena != null)
            //            item.ProsjecnaOcjena = item.TretmanOcjena;
            //        else if (item.UslugaOcjena != null && item.TretmanOcjena == null)
            //            item.ProsjecnaOcjena = item.UslugaOcjena;
            //        else
            //            item.ProsjecnaOcjena = (item.UslugaOcjena + item.TretmanOcjena) / 2;

            //    }
            //    listaFrizera.ItemsSource = frizeri;
            //}vrstaUslugePicker_SelectedIndexChanged
        }

        private void vrstaUslugePicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            int vrstaUslugeId = (vrstaUslugePicker.SelectedItem as VrsteUsluga_Result).VrstaUslugeID;
            HttpResponseMessage responseFrizeri = frizeriService.GetActionResponse("SearchByVrstaUsluge", vrstaUslugeId.ToString());
            if (responseFrizeri.IsSuccessStatusCode)
            {
                var jsonObject = responseFrizeri.Content.ReadAsStringAsync();
                List<Frizeri_Result> frizeri = JsonConvert.DeserializeObject<List<Frizeri_Result>>(jsonObject.Result);
                foreach (var item in frizeri)
                {
                    if (item.UslugaOcjena == null && item.TretmanOcjena != null)
                        item.ProsjecnaOcjena = item.TretmanOcjena;
                    else if (item.UslugaOcjena != null && item.TretmanOcjena == null)
                        item.ProsjecnaOcjena = item.UslugaOcjena;
                    else
                        item.ProsjecnaOcjena = (item.UslugaOcjena + item.TretmanOcjena) / 2;

                }
                listaFrizera.ItemsSource = frizeri;
            }
        }

        private void rezervisiTerminFrizerBtn_Clicked(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            Frizeri_Result rezervacija = btn.BindingContext as Frizeri_Result;
            int vrstaUslugeId = (vrstaUslugePicker.SelectedItem as VrsteUsluga_Result).VrstaUslugeID;

            this.Navigation.PushAsync(new PregledTermina(rezervacija.FrizerID, vrstaUslugeId));
        }
    }
}