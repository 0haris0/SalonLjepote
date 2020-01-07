using eHairdresserSalon_PCL.Model;
using eHairdresserSalon_PCL.Util;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;

using Xamarin.Forms;

namespace eHairdresserSalonSolution
{
    public class Login : ContentPage
    {
        private WebAPIHelper klijentiService = new WebAPIHelper(Global.APIAddress, Global.klijentiRoute);

        protected override void OnAppearing()
        {
            Global.prijavljeniKlijent = null;

            NavigationPage.SetHasNavigationBar(this, false);

            base.OnAppearing();
        }

        public Login()
        {
            NavigationPage.SetHasBackButton(this, false);
            NavigationPage.SetHasNavigationBar(this, false);

            StackLayout stek = new StackLayout();
            stek.Margin = 10;
            stek.VerticalOptions = LayoutOptions.CenterAndExpand;

            Label zaglavljeLabel = new Label()
            {
                Text = "Prijava @ eBeautySalon",
                FontSize = 30,
                HorizontalTextAlignment = TextAlignment.Center
            };
            Entry korisnickoImeInput = new Entry() { Placeholder = "Korisnicko ime..." };
            Entry lozinkaInput = new Entry() { Placeholder = "********", IsPassword=true };

            Button prijavaButton = new Button() { Text = "Prijava" };
            prijavaButton.Clicked += (sender, args) =>
            {
                try
                {
                    if (String.IsNullOrEmpty(korisnickoImeInput.Text) || String.IsNullOrEmpty(lozinkaInput.Text))
                        DisplayAlert("Greška", "Unesite korisničko ime i lozinku.", "OK");
                    else
                    {
                        HttpResponseMessage response = klijentiService.GetActionResponse("GetByUsername", korisnickoImeInput.Text);
                        if (response.IsSuccessStatusCode)
                        {
                            var jsonResult = response.Content.ReadAsStringAsync();
                            Klijenti k = JsonConvert.DeserializeObject<Klijenti>(jsonResult.Result);

                            if(k.Aktivan==true)
                            {
                                if (k.LozinkaHash == UIHelper.GenerateHash(lozinkaInput.Text, k.LozinkaSalt))
                                {
                                    Global.prijavljeniKlijent = k;
                                    NavigationPage.SetHasNavigationBar(this, true);
                                    this.Navigation.PushAsync(new PregledFrizera());

                                }
                                else
                                    DisplayAlert("Greška", "Unijeli ste pogrešnu lozinku.", "OK");
                            }
                            else
                            {
                                DisplayAlert("Greška", "Vaš račun još nije aktiviran.", "OK");

                            }

                        }
                        else
                        {
                            DisplayAlert("Greška", "Niste unijeli ispravne podatke.", "OK");
                        }
                    }
                }
                catch (Exception ex)
                {
                    DisplayAlert("Greška", ex.Message, "OK");
                }
            };

            Button registracijaButton = new Button() { Text = "Registracija" };
            registracijaButton.Clicked += async (sender, args) =>
            {
                await Navigation.PushAsync(new Registracija());
            };

            stek.Children.Add(zaglavljeLabel);
            stek.Children.Add(korisnickoImeInput);
            stek.Children.Add(lozinkaInput);

            StackLayout stekButtons = new StackLayout();
            stekButtons.Children.Add(registracijaButton);
            stekButtons.Children.Add(prijavaButton);
            stekButtons.Orientation = StackOrientation.Horizontal;
            stekButtons.HorizontalOptions = LayoutOptions.End;

            stek.Children.Add(stekButtons);

            Content = stek;
        }
    }
}