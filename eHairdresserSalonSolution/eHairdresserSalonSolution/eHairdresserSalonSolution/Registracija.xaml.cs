using eHairdresserSalon_PCL.Model;
using eHairdresserSalon_PCL.Util;
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
	public partial class Registracija : ContentPage
	{
        private WebAPIHelper klijentiService = new WebAPIHelper(Global.APIAddress, Global.klijentiRoute);
		public Registracija ()
		{
			InitializeComponent ();
		}
        private void registracijaButton_Clicked(object sender, EventArgs e)
        {
            if (Validacija())
            {
                errorMsgLbl.IsVisible = false;

                Klijenti k = new Klijenti();
                k.Ime = imeInput.Text;
                k.Prezime = prezimeInput.Text;
                k.DatumRodjenja = datumRodjenjaInput.Date;
                k.Adresa = adresaInput.Text;
                k.Email = emailInput.Text;
                k.BrojTelefona = telefonInput.Text;
                k.Napomena = napomenaInput.Text;
                k.KorisnickoIme = korisnickoImeInput.Text;
                k.LozinkaSalt = UIHelper.GenerateSalt();
                k.LozinkaHash = UIHelper.GenerateHash(lozinkaInput.Text, k.LozinkaSalt);
                k.TerminiCount = 0;
                k.Aktivan = false;

                HttpResponseMessage response = klijentiService.PostResponse(k);
                if (response.IsSuccessStatusCode)
                {
                    DisplayAlert("Uspjeh", "Uspjesno ste se registrovali!", "OK");
                    this.Navigation.PopAsync();
                }
                else
                {
                    DisplayAlert("Greska", "Korisnicko ime je zauzeto.", "OK");
                }
            }
            else
            {
                errorMsgLbl.TextColor = Color.Red;
                errorMsgLbl.IsVisible = true;
            }
        }

        private bool Validacija()
        {
            if (String.IsNullOrEmpty(imeInput.Text))
            {
                return false;
            }
            else if (String.IsNullOrEmpty(prezimeInput.Text))
            {
                return false;
            }
            else if (String.IsNullOrEmpty(korisnickoImeInput.Text))
            {
                return false;
            }
            else if (String.IsNullOrEmpty(lozinkaInput.Text))
            {
                return false;
            }
            return true;

        }
    }
}