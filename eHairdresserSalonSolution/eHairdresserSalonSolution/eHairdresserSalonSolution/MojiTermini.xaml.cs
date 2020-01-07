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
    public partial class MojiTermini : ContentPage
    {
        private WebAPIHelper terminiService = new WebAPIHelper(Global.APIAddress, Global.TerminiRoute);

        List<Termini_Result3> termini = new List<Termini_Result3>();


        public Command PrikaziButtonCommand { get; }


        public MojiTermini()
        {
            InitializeComponent();


            HttpResponseMessage response = terminiService.GetActionResponse("SearchByKlijent", Global.prijavljeniKlijent.KlijentID.ToString());
            if (response.IsSuccessStatusCode)
            {
                var jsonObject = response.Content.ReadAsStringAsync();
                termini = JsonConvert.DeserializeObject<List<Termini_Result3>>(jsonObject.Result);
                if (termini.Count() > 0)
                {
                    foreach (var item in termini)
                    {
                        if (item.Datum > DateTime.Today)
                        {
                            int daysDiff = ((TimeSpan)(item.Datum - DateTime.Today)).Days;
                            item.VrijemeDoTermina = "Ostalo je "+ daysDiff + " dana do vašeg termina.";
                        }
                        else if (item.Datum == DateTime.Today)
                        {
                            item.VrijemeDoTermina = "Vaš termin je danas.";
                        }
                        else
                            item.VrijemeDoTermina = "";

                        if (Convert.ToInt32(item.Ocjena) != 0)
                        {
                            item.Ocijenjeno = false;
                            item.Ocjena = "Termin je ocijenjen ocjenom " + item.Ocjena + ".";
                        }
                        else
                        {
                            item.Ocijenjeno = true;
                            item.Ocjena = "";
                        }
                    }
                    listaTermina.ItemsSource = termini;


                }
                else
                {
                    errLabel.IsVisible = true;
                    listaTermina.IsVisible = false;
                }
            }
        }

        private void OcijeniBtn_Clicked(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            Termini_Result3 ocijeni = btn.BindingContext as Termini_Result3;

            this.Navigation.PushAsync(new OcijeniTermin(ocijeni));

        }
    }
}