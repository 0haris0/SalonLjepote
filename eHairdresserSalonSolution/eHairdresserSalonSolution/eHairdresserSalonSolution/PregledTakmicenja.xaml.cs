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
	public partial class PregledTakmicenja : ContentPage
	{
        private WebAPIHelper takmicenjaService = new WebAPIHelper(Global.APIAddress, Global.TakmicenjaRoute);
        private WebAPIHelper klijentiTakmicenjaService = new WebAPIHelper(Global.APIAddress, Global.KlijentiTakmicenjaRoute);

        public PregledTakmicenja ()
		{
			InitializeComponent ();

            HttpResponseMessage responseTakmicenja = takmicenjaService.GetActionResponse("GetTakmicenjaByDatum", Global.prijavljeniKlijent.KlijentID.ToString());
            if(responseTakmicenja.IsSuccessStatusCode)
            {
                var jsonObject = responseTakmicenja.Content.ReadAsStringAsync();
                List<Takmicenja> takmicenja = JsonConvert.DeserializeObject<List<Takmicenja>>(jsonObject.Result);

                if (takmicenja.Count() > 0)
                {
                    listaTakmicenja.ItemsSource = takmicenja;

                }
                else
                {
                    errLabel.IsVisible = true;
                    listaTakmicenja.IsVisible = false;
                }
            }


        }

        private void PrijaviSeBtn_Clicked(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            Takmicenja takmicenje = btn.BindingContext as Takmicenja;

            KlijentiTakmicenja kt = new KlijentiTakmicenja()
            {
                KlijentID=Global.prijavljeniKlijent.KlijentID,
                TakmicenjeID=takmicenje.TakmicenjeID,
                DatumPrijave=DateTime.Today
            };
            HttpResponseMessage responsePost = klijentiTakmicenjaService.PostResponse(kt);
            if(responsePost.IsSuccessStatusCode)
            {
                DisplayAlert("Uspjeh", "Uspješna prijava. Bit ćete obaviješteni o selekciji.", "OK");
                btn.Text = "Prijavljen";
                btn.IsEnabled = false;
            }
            else
            {
                DisplayAlert("Greška", "Prijave su popunjene", "OK");
            }
        }
    }
}