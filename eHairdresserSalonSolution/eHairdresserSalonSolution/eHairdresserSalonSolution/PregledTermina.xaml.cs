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
    public partial class PregledTermina : ContentPage
    {
        private WebAPIHelper terminiService = new WebAPIHelper(Global.APIAddress, Global.TerminiRoute);
        private WebAPIHelper frizeriService = new WebAPIHelper(Global.APIAddress, Global.frizeriRoute);
        private WebAPIHelper uslugeService = new WebAPIHelper(Global.APIAddress, Global.UslugeRoute);
        private WebAPIHelper dodatniTretmaniService = new WebAPIHelper(Global.APIAddress, Global.DodatniTretmaniRoute);
        private WebAPIHelper klijentiService = new WebAPIHelper(Global.APIAddress, Global.klijentiRoute);
        private WebAPIHelper vrsteUslugaService = new WebAPIHelper(Global.APIAddress, Global.VrsteUslugaRoute);


        public PregledTermina(string tretmanID, int vrstaUslugeId)
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

                int odabranaVrstaUslugeIndex = -1;
                for (int i = 0; i < vrsteUsluga.Count(); i++)
                {
                    if (vrsteUsluga[i].VrstaUslugeID == vrstaUslugeId)
                        odabranaVrstaUslugeIndex = i;
                }

                if (odabranaVrstaUslugeIndex != -1)
                    vrstaUslugePicker.SelectedIndex = odabranaVrstaUslugeIndex;
                else
                    vrstaUslugePicker.SelectedIndex = 0;
            }

            List<Frizeri_Result> frizeri = new List<Frizeri_Result>();
            HttpResponseMessage responseFrizeri = frizeriService.GetActionResponse("SearchByVrstaUsluge", vrstaUslugeId.ToString());
            if (responseFrizeri.IsSuccessStatusCode)
            {
                var jsonObject = responseFrizeri.Content.ReadAsStringAsync();
                frizeri = JsonConvert.DeserializeObject<List<Frizeri_Result>>(jsonObject.Result);
                frizerPicker.ItemsSource = frizeri;
                frizerPicker.ItemDisplayBinding = new Binding("ImePrezime");
            }
            frizerPicker.SelectedIndex = 0;

            List<Usluge_Result> usluge = new List<Usluge_Result>();
            HttpResponseMessage responseUsluge = uslugeService.GetActionResponse("SearchByVrstaUsluge", vrstaUslugeId.ToString());
            if (responseUsluge.IsSuccessStatusCode)
            {
                var jsonObject = responseUsluge.Content.ReadAsStringAsync();
                usluge = JsonConvert.DeserializeObject<List<Usluge_Result>>(jsonObject.Result);
                foreach (var item in usluge)
                {
                    item.NazivUsluge += " - " + item.CijenaUsluge + " KM";
                }
                uslugaPicker.ItemsSource = usluge;
                uslugaPicker.ItemDisplayBinding = new Binding("NazivUsluge");
            }
            uslugaPicker.SelectedIndex = 0;

            List<DodatniTretmani_Result> tretmani = new List<DodatniTretmani_Result>();
            HttpResponseMessage responseTretmani = dodatniTretmaniService.GetActionResponse("SearchByVrstaUsluge", vrstaUslugeId.ToString());
            if (responseTretmani.IsSuccessStatusCode)
            {
                var jsonObject = responseTretmani.Content.ReadAsStringAsync();
                tretmani = JsonConvert.DeserializeObject<List<DodatniTretmani_Result>>(jsonObject.Result);
                foreach (var item in tretmani)
                {
                    item.NazivTretmana += " - " + item.Cijena + " KM";
                }
                dodatniTretmaniPicker.ItemsSource = tretmani;
                dodatniTretmaniPicker.ItemDisplayBinding = new Binding("NazivTretmana");

                int odabraniTretmanIndex = -1;
                for (int i = 0; i < tretmani.Count(); i++)
                {
                    if (tretmani[i].TretmanID == Convert.ToInt32(tretmanID))
                        odabraniTretmanIndex = i;
                }

                if (odabraniTretmanIndex != -1)
                    dodatniTretmaniPicker.SelectedIndex = odabraniTretmanIndex;
                else
                    dodatniTretmaniPicker.SelectedIndex = 0;
            }
        }

        public PregledTermina(int frizerId, int vrstaUslugeId)
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

                int odabranaVrstaUslugeIndex = -1;
                for (int i = 0; i < vrsteUsluga.Count(); i++)
                {
                    if (vrsteUsluga[i].VrstaUslugeID == vrstaUslugeId)
                        odabranaVrstaUslugeIndex = i;
                }

                if (odabranaVrstaUslugeIndex != -1)
                    vrstaUslugePicker.SelectedIndex = odabranaVrstaUslugeIndex;
                else
                    vrstaUslugePicker.SelectedIndex = 0;
            }

            List<Frizeri_Result> frizeri = new List<Frizeri_Result>();
            HttpResponseMessage responseFrizeri = frizeriService.GetActionResponse("SearchByVrstaUsluge", vrstaUslugeId.ToString());
            if (responseFrizeri.IsSuccessStatusCode)
            {
                var jsonObject = responseFrizeri.Content.ReadAsStringAsync();
                frizeri = JsonConvert.DeserializeObject<List<Frizeri_Result>>(jsonObject.Result);
                frizerPicker.ItemsSource = frizeri;
                frizerPicker.ItemDisplayBinding = new Binding("ImePrezime");

                int odabraniFrizerIndex = -1;
                for (int i = 0; i < frizeri.Count(); i++)
                {
                    if (frizeri[i].FrizerID == frizerId)
                        odabraniFrizerIndex = i;
                }

                if (odabraniFrizerIndex != -1)
                    frizerPicker.SelectedIndex = odabraniFrizerIndex;
                else
                    frizerPicker.SelectedIndex = 0;
            }

            List<Usluge_Result> usluge = new List<Usluge_Result>();
            HttpResponseMessage responseUsluge = uslugeService.GetActionResponse("SearchByVrstaUsluge", vrstaUslugeId.ToString());
            if (responseUsluge.IsSuccessStatusCode)
            {
                var jsonObject = responseUsluge.Content.ReadAsStringAsync();
                usluge = JsonConvert.DeserializeObject<List<Usluge_Result>>(jsonObject.Result);
                foreach (var item in usluge)
                {
                    item.NazivUsluge += " - " + item.CijenaUsluge + " KM";
                }
                uslugaPicker.ItemsSource = usluge;
                uslugaPicker.ItemDisplayBinding = new Binding("NazivUsluge");
            }
            uslugaPicker.SelectedIndex = 0;


            List<DodatniTretmani_Result> tretmani = new List<DodatniTretmani_Result>();
            HttpResponseMessage responseTretmani = dodatniTretmaniService.GetActionResponse("SearchByVrstaUsluge", vrstaUslugeId.ToString());
            if (responseTretmani.IsSuccessStatusCode)
            {
                var jsonObject = responseTretmani.Content.ReadAsStringAsync();
                tretmani = JsonConvert.DeserializeObject<List<DodatniTretmani_Result>>(jsonObject.Result);
                foreach (var item in tretmani)
                {
                    item.NazivTretmana += " - " + item.Cijena + " KM";
                }
                dodatniTretmaniPicker.ItemsSource = tretmani;
                dodatniTretmaniPicker.ItemDisplayBinding = new Binding("NazivTretmana");
            }
        }

        public PregledTermina()
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
                vrstaUslugePicker.ItemDisplayBinding = new Binding("Naziv");
            }
            vrstaUslugePicker.SelectedIndex = 0;

            List<Frizeri_Result> frizeri = new List<Frizeri_Result>();
            int vrstaUslugeId = (vrstaUslugePicker.SelectedItem as VrsteUsluga_Result).VrstaUslugeID;
            HttpResponseMessage responseFrizeri = frizeriService.GetActionResponse("SearchByVrstaUsluge", vrstaUslugeId.ToString());
            if (responseFrizeri.IsSuccessStatusCode)
            {
                var jsonObject = responseFrizeri.Content.ReadAsStringAsync();
                frizeri = JsonConvert.DeserializeObject<List<Frizeri_Result>>(jsonObject.Result);
                frizerPicker.ItemsSource = frizeri;
                frizerPicker.ItemDisplayBinding = new Binding("ImePrezime");
            }
            frizerPicker.SelectedIndex = 0;

            List<Usluge_Result> usluge = new List<Usluge_Result>();
            HttpResponseMessage responseUsluge = uslugeService.GetActionResponse("SearchByVrstaUsluge", vrstaUslugeId.ToString());
            if (responseUsluge.IsSuccessStatusCode)
            {
                var jsonObject = responseUsluge.Content.ReadAsStringAsync();
                usluge = JsonConvert.DeserializeObject<List<Usluge_Result>>(jsonObject.Result);
                foreach (var item in usluge)
                {
                    item.NazivUsluge += " - " + item.CijenaUsluge + " KM";
                }
                uslugaPicker.ItemsSource = usluge;
                uslugaPicker.ItemDisplayBinding = new Binding("NazivUsluge");
            }
            uslugaPicker.SelectedIndex = 0;

            List<DodatniTretmani_Result> tretmani = new List<DodatniTretmani_Result>();
            //HttpResponseMessage responseTretmani = dodatniTretmaniService.GetResponse();
            HttpResponseMessage responseTretmani = dodatniTretmaniService.GetActionResponse("SearchByVrstaUsluge", vrstaUslugeId.ToString());
            if (responseTretmani.IsSuccessStatusCode)
            {
                var jsonObject = responseTretmani.Content.ReadAsStringAsync();
                tretmani = JsonConvert.DeserializeObject<List<DodatniTretmani_Result>>(jsonObject.Result);
                foreach (var item in tretmani)
                {
                    item.NazivTretmana += " - " + item.Cijena + " KM";
                }
                dodatniTretmaniPicker.ItemsSource = tretmani;
                dodatniTretmaniPicker.ItemDisplayBinding = new Binding("NazivTretmana");
            }
        }

        private void frizerPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (frizerPicker.SelectedItem != null)
            {
                int frizerId = (frizerPicker.SelectedItem as Frizeri_Result).FrizerID;
                HttpResponseMessage response = terminiService.GetActionResponse("SearchByFrizer", frizerId.ToString());
                if (response.IsSuccessStatusCode)
                {
                    var jsonObject = response.Content.ReadAsStringAsync();
                    List<Termini_Result2> termini = JsonConvert.DeserializeObject<List<Termini_Result2>>(jsonObject.Result);
                    listaTermina.ItemsSource = termini;
                }
            }
        }

        private void vrsteUslugaPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Frizeri_Result> frizeri = new List<Frizeri_Result>();
            int vrstaUslugeId = (vrstaUslugePicker.SelectedItem as VrsteUsluga_Result).VrstaUslugeID;
            HttpResponseMessage responseFrizeri = frizeriService.GetActionResponse("SearchByVrstaUsluge", vrstaUslugeId.ToString());
            if (responseFrizeri.IsSuccessStatusCode)
            {
                var jsonObject = responseFrizeri.Content.ReadAsStringAsync();
                frizeri = JsonConvert.DeserializeObject<List<Frizeri_Result>>(jsonObject.Result);
                frizerPicker.ItemsSource = frizeri;
                frizerPicker.ItemDisplayBinding = new Binding("ImePrezime");
            }
            frizerPicker.SelectedIndex = 0;

            List<Usluge_Result> usluge = new List<Usluge_Result>();
            HttpResponseMessage responseUsluge = uslugeService.GetActionResponse("SearchByVrstaUsluge", vrstaUslugeId.ToString());
            if (responseUsluge.IsSuccessStatusCode)
            {
                var jsonObject = responseUsluge.Content.ReadAsStringAsync();
                usluge = JsonConvert.DeserializeObject<List<Usluge_Result>>(jsonObject.Result);
                foreach (var item in usluge)
                {
                    item.NazivUsluge += " - " + item.CijenaUsluge + " KM";
                }
                uslugaPicker.ItemsSource = usluge;
                uslugaPicker.ItemDisplayBinding = new Binding("NazivUsluge");
            }
            uslugaPicker.SelectedIndex = 0;

            List<DodatniTretmani_Result> tretmani = new List<DodatniTretmani_Result>();
            HttpResponseMessage responseTretmani = dodatniTretmaniService.GetActionResponse("SearchByVrstaUsluge", vrstaUslugeId.ToString());
            if (responseTretmani.IsSuccessStatusCode)
            {
                var jsonObject = responseTretmani.Content.ReadAsStringAsync();
                tretmani = JsonConvert.DeserializeObject<List<DodatniTretmani_Result>>(jsonObject.Result);
                foreach (var item in tretmani)
                {
                    item.NazivTretmana += " - " + item.Cijena + " KM";
                }
                dodatniTretmaniPicker.ItemsSource = tretmani;
                dodatniTretmaniPicker.ItemDisplayBinding = new Binding("NazivTretmana");
            }
        }



        private void btnRezervisi_Clicked(object sender, EventArgs e)
        {
            HttpResponseMessage responseGetKlijent = klijentiService.GetResponse(Global.prijavljeniKlijent.KlijentID.ToString());
            if (responseGetKlijent.IsSuccessStatusCode)
            {
                var jsonObjectKlijent = responseGetKlijent.Content.ReadAsStringAsync();
                Klijenti logirani = JsonConvert.DeserializeObject<Klijenti>(jsonObjectKlijent.Result);

                if (logirani.TerminiCount < 3)
                {
                    Button btn = sender as Button;
                    Termini_Result2 rezervacija = btn.BindingContext as Termini_Result2;

                    HttpResponseMessage responseTermin = terminiService.GetResponse(rezervacija.TerminID.ToString());
                    if (responseTermin.IsSuccessStatusCode)
                    {
                        var jsonObject = responseTermin.Content.ReadAsStringAsync();
                        Termini termin = JsonConvert.DeserializeObject<Termini>(jsonObject.Result);

                        termin.KlijentID = Global.prijavljeniKlijent.KlijentID;
                        termin.UslugaID = (uslugaPicker.SelectedItem as Usluge_Result).UslugaID;
                        termin.Zauzeto = true;

                        if ((dodatniTretmaniPicker.SelectedItem as DodatniTretmani_Result) == null)
                            termin.TretmanID = null;
                        else
                            termin.TretmanID = (dodatniTretmaniPicker.SelectedItem as DodatniTretmani_Result).TretmanID;

                        HttpResponseMessage responseTerminPut = terminiService.PutResponse(termin.TerminID, termin);
                        if (responseTerminPut.IsSuccessStatusCode)
                        {
                            btn.Text = "Rezervisano";
                            btn.IsEnabled = false;
                            DisplayAlert("Uspjeh", "Termin je uspješno rezervisan.", "OK");

                            logirani.TerminiCount++;
                            HttpResponseMessage responsePutKlijent = klijentiService.PutResponse(logirani.KlijentID, logirani);
                        }

                    }
                }
                else
                {
                    DisplayAlert("Greška", "Nije moguće rezervisati više od 3 termina.", "OK");
                }
            }

        }
    }
}