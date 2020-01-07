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
    public partial class OcijeniTermin : ContentPage
    {
        private WebAPIHelper terminiService = new WebAPIHelper(Global.APIAddress, Global.TerminiRoute);
        private WebAPIHelper uslugeOcjeneService = new WebAPIHelper(Global.APIAddress, Global.UslugeOcjeneRoute);
        private WebAPIHelper dodatniTretmaniOcjeneService = new WebAPIHelper(Global.APIAddress, Global.DodatniTretmaniOcjeneRoute);

        Termini_Result3 odabraniTermin = new Termini_Result3();
        public OcijeniTermin(Termini_Result3 termin)
        {
            InitializeComponent();


            this.odabraniTermin = termin;
            if (String.IsNullOrEmpty(termin.NazivTretmana))
            {
                tretmanLabel.IsVisible = false;
                tretmanInput.IsVisible = false;
            }
            if (termin.OcijenjenaUsluga == true || termin.OcijenjenTretman == true)
            {
                uslugaInput.IsEnabled = false;
                tretmanInput.IsEnabled = false;
                sacuvajBtn.IsEnabled = false;
            }

        }

        private void sacuvajBtn_Clicked(object sender, EventArgs e)
        {
            if ((Convert.ToInt32(uslugaInput.Text) < 1 || Convert.ToInt32(uslugaInput.Text) > 5) || ((!String.IsNullOrEmpty(tretmanInput.Text)) && (Convert.ToInt32(tretmanInput.Text) < 1 || Convert.ToInt32(tretmanInput.Text) > 5)))
            {
                DisplayAlert("Greška", "Ocjena mora biti od 1 do 5.", "OK");
            }
            else
            {
                HttpResponseMessage responseTermin = terminiService.GetResponse(odabraniTermin.TerminID.ToString());
                if (responseTermin.IsSuccessStatusCode)
                {
                    var jsonObject = responseTermin.Content.ReadAsStringAsync();
                    Termini termin = JsonConvert.DeserializeObject<Termini>(jsonObject.Result);

                    UslugeOcjene uo = new UslugeOcjene()
                    {
                        FrizerID = Convert.ToInt32(termin.FrizerID),
                        KlijentID = Convert.ToInt32(termin.KlijentID),
                        UslugaID = Convert.ToInt32(termin.UslugaID),
                        Ocjena = Convert.ToInt32(uslugaInput.Text),
                        TerminID = Convert.ToInt32(termin.TerminID)
                    };

                    HttpResponseMessage responseUsluge = uslugeOcjeneService.PostResponse(uo);

                    termin.OcijenjenaUsluga = true;
                    termin.OcijenjenTretman = true;
                    HttpResponseMessage responseTerminPut = terminiService.PutResponse(termin.TerminID, termin);

                    if (!String.IsNullOrEmpty(odabraniTermin.NazivTretmana))
                    {
                        DodatniTretmaniOcjene dto = new DodatniTretmaniOcjene()
                        {
                            FrizerID = Convert.ToInt32(termin.FrizerID),
                            KlijentID = Convert.ToInt32(termin.KlijentID),
                            TretmanID = Convert.ToInt32(termin.TretmanID),
                            Ocjena = Convert.ToInt32(tretmanInput.Text)
                        };

                        HttpResponseMessage responseTretmani = dodatniTretmaniOcjeneService.PostResponse(dto);

                        if (responseUsluge.IsSuccessStatusCode && responseTretmani.IsSuccessStatusCode)
                        {
                            DisplayAlert("Uspjeh", "Uspješno ste ocijenili uslugu i tretman.", "OK");
                        }
                    }

                    if (String.IsNullOrEmpty(odabraniTermin.NazivTretmana) && responseUsluge.IsSuccessStatusCode)
                    {
                        DisplayAlert("Uspjeh", "Uspješno ste ocijenili uslugu.", "OK");
                    }

                    this.Navigation.PopAsync();
                }
            }

        }
    }
}