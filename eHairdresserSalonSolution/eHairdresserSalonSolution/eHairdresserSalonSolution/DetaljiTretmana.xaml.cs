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
	public partial class DetaljiTretmana : ContentPage
	{
        private WebAPIHelper dodatniTretmaniService = new WebAPIHelper(Global.APIAddress, Global.DodatniTretmaniRoute);

        int odabraniTretman = -1;
        int odabranaVrstaUsluge = -1;
        public DetaljiTretmana (DodatniTretmani_Ocjene_Result tretman)
		{
			InitializeComponent ();

            nazivLabel.Text = tretman.NazivTretmana;
            cijenaLabel.Text = "Cijena: " + tretman.Cijena + " KM";
            opisLabel.Text = tretman.Opis;

            odabraniTretman = tretman.TretmanID;
            odabranaVrstaUsluge = tretman.VrstaUslugeID;

            HttpResponseMessage responseRecommended = dodatniTretmaniService.GetActionResponse("PreporukaDodatnihTretmana", Global.prijavljeniKlijent.KlijentID.ToString(), tretman.TretmanID.ToString(), tretman.VrstaUslugeID.ToString());
            if (responseRecommended.IsSuccessStatusCode)
            {
                var jsonObject = responseRecommended.Content.ReadAsStringAsync();
                List<DodatniTretmani_Ocjene_Result> lpp = JsonConvert.DeserializeObject<List<DodatniTretmani_Ocjene_Result>>(jsonObject.Result);
                listaPreporucenihTretmana.ItemsSource = lpp;
                if (lpp.Count() == 0)
                    stLbl.IsVisible = false;
                else
                    stLbl.IsVisible = true;
            }
    }

        private void btnKoristiTretman_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new PregledTermina(odabraniTretman.ToString(), odabranaVrstaUsluge));
        }

        private void listaPreporucenihTretmana_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            this.Navigation.PushAsync(new DetaljiTretmana((e.Item as DodatniTretmani_Ocjene_Result)));
        }
    }
}