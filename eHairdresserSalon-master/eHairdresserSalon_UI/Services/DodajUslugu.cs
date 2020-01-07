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

namespace eHairdresserSalon_UI.Services
{
    public partial class DodajUslugu : Form
    {
        private WebAPIHelper uslugeService = new WebAPIHelper("http://ndemirovic.app.fit.ba/", "api/Usluge");
        private WebAPIHelper vrsteUslugaService = new WebAPIHelper("http://ndemirovic.app.fit.ba/", "api/VrsteUsluga");


        public DodajUslugu()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
        }

        private void BindVrsteUsluga()
        {
            HttpResponseMessage response = vrsteUslugaService.GetResponse();
            if (response.IsSuccessStatusCode)
            {
                List<VrsteUsluga_Result> lst = response.Content.ReadAsAsync<List<VrsteUsluga_Result>>().Result;
                lst.Insert(0, new VrsteUsluga_Result() { Naziv = "Odaberite: " });
                vrstaUslugeComboBox.DataSource = lst;
                vrstaUslugeComboBox.DisplayMember = "Naziv";
                vrstaUslugeComboBox.ValueMember = "VrstaUslugeID";
            }
        }

        private void DodajUsluguBtn_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                Usluge u = new Usluge();
                u.NazivUsluge = NazivUslugeInput.Text;
                u.TrajanjeMinute = Convert.ToInt32(TrajanjeUslugeInput.Text);
                u.CijenaUsluge = Convert.ToDecimal(CijenaUslugeInput.Text);

                if (vrstaUslugeComboBox.SelectedIndex != 0)
                    u.VrstaUslugeID = Convert.ToInt32(vrstaUslugeComboBox.SelectedValue);

                HttpResponseMessage response = uslugeService.PostResponse(u);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Usluga je uspjesno dodana.");
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

        private void NazivUslugeInput_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(NazivUslugeInput.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(NazivUslugeInput, Messages.sName_req);
            }
            else
            {
                errorProvider.SetError(NazivUslugeInput, null);
            }
        }

        private void TrajanjeUslugeInput_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(TrajanjeUslugeInput.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(TrajanjeUslugeInput, Messages.sDuration_req);
            }
            else
            {
                errorProvider.SetError(TrajanjeUslugeInput, null);
            }
        }

        private void CijenaUslugeInput_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(CijenaUslugeInput.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(CijenaUslugeInput, Messages.sPrice_req);
            }
            else
            {
                errorProvider.SetError(CijenaUslugeInput, null);
            }
        }

        private void DodajUslugu_Load(object sender, EventArgs e)
        {
            BindVrsteUsluga();
        }

        private void vrstaUslugeComboBox_Validating(object sender, CancelEventArgs e)
        {
            if (vrstaUslugeComboBox.SelectedIndex == 0)
            {
                e.Cancel = true;
                errorProvider.SetError(vrstaUslugeComboBox, Messages.serviceType_req);
            }
            else
            {
                errorProvider.SetError(vrstaUslugeComboBox, null);
            }
        }
    }
}
