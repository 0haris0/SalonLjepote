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
	public partial class MojaTakmicenja : ContentPage
	{
        private WebAPIHelper takmicenjaService = new WebAPIHelper(Global.APIAddress, Global.TakmicenjaRoute);
        private WebAPIHelper klijentiTakmicenjaService = new WebAPIHelper(Global.APIAddress, Global.KlijentiTakmicenjaRoute);

        public MojaTakmicenja()
        {
            InitializeComponent();

            HttpResponseMessage response = klijentiTakmicenjaService.GetActionResponse("SearchByKlijent", Global.prijavljeniKlijent.KlijentID.ToString());
            if (response.IsSuccessStatusCode)
            {
                var jsonObject = response.Content.ReadAsStringAsync();
                List<Takmicenja_Result> takmicenja = JsonConvert.DeserializeObject<List<Takmicenja_Result>>(jsonObject.Result);
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
    }
}