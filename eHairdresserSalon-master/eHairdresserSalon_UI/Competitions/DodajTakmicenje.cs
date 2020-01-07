using eHairdresserSalon_API.Models;
using eHairdresserSalon_UI.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eHairdresserSalon_UI.Competitions
{
    public partial class DodajTakmicenje : Form
    {
        private WebAPIHelper takmicenjaService = new WebAPIHelper("http://ndemirovic.app.fit.ba/", "api/Takmicenja");
        private WebAPIHelper frizeriService = new WebAPIHelper("http://ndemirovic.app.fit.ba/", "api/Frizeri");


        private FrizerskiSalonEntities dm = new FrizerskiSalonEntities();


        private void BindFrizeri()
        {
            HttpResponseMessage response = frizeriService.GetResponse();
            if (response.IsSuccessStatusCode)
            {
                List<Frizeri_Result> lst = response.Content.ReadAsAsync<List<Frizeri_Result>>().Result;
                lst.Insert(0, new Frizeri_Result() { ImePrezime = "Odaberite frizera: " });
                FrizeriComboBox.DataSource = lst;
                FrizeriComboBox.DisplayMember = "ImePrezime";
                FrizeriComboBox.ValueMember = "FrizerID";
            }
        }

        public DodajTakmicenje()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
        }

        private void DodajTakmicenjeBtn_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                Takmicenja t = new Takmicenja();
                t.Naziv = NazivInput.Text;
                t.Datum = DatumInput.Value;
                t.Mjesto = MjestoInput.Text;
                t.Opis = OpisInput.Text;

                if (FrizeriComboBox.SelectedIndex != 0)
                    t.FrizerID = Convert.ToInt32(FrizeriComboBox.SelectedValue);

                HttpResponseMessage response = takmicenjaService.PostResponse(t);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Takmicenje je uspjesno dodano.");
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    string msg = response.ReasonPhrase;
                    if (!String.IsNullOrEmpty(Messages.ResourceManager.GetString(response.ReasonPhrase)))
                        msg = Messages.ResourceManager.GetString(response.ReasonPhrase);

                    MessageBox.Show("Error code: " + response.StatusCode + " Message: " + msg);

                }
            }
        }

        private void NazivInput_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(NazivInput.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(NazivInput, Messages.cName_req);
            }
            else
            {
                errorProvider.SetError(NazivInput, null);
            }
        }

        private void MjestoInput_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(MjestoInput.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(MjestoInput, Messages.cPlace_req);
            }
            else
            {
                errorProvider.SetError(MjestoInput, null);
            }
        }

        private void DodajTakmicenje_Load(object sender, EventArgs e)
        {
            BindFrizeri();
        }
    }
}
