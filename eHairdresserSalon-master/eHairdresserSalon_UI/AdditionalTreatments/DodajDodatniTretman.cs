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

namespace eHairdresserSalon_UI.AdditionalTreatments
{
    public partial class DodajDodatniTretman : Form
    {
        private WebAPIHelper dodatniTretmaniService = new WebAPIHelper("http://ndemirovic.app.fit.ba/", "api/DodatniTretmani"); 
        private WebAPIHelper skladisteService = new WebAPIHelper("http://ndemirovic.app.fit.ba/", "api/Skladiste");
        private WebAPIHelper vrsteUslugaService = new WebAPIHelper("http://ndemirovic.app.fit.ba/", "api/VrsteUsluga");

        public DodajDodatniTretman()
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

        private void DodajDodatniTretmanBtn_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                DodatniTretmani d = new DodatniTretmani();
                d.NazivTretmana = NazivDodatnogTretmanaInput.Text;
                d.Cijena = Convert.ToInt32(CijenaDodatnogTretmanaInput.Text);

                if (vrstaUslugeComboBox.SelectedIndex != 0)
                    d.VrstaUslugeID = Convert.ToInt32(vrstaUslugeComboBox.SelectedValue);

                int trenutnoDodaniTretman = -1;
                HttpResponseMessage response = dodatniTretmaniService.PostResponse(d);
                if (response.IsSuccessStatusCode)
                {
                    trenutnoDodaniTretman = response.Content.ReadAsAsync<DodatniTretmani>().Result.TretmanID;
                    MessageBox.Show("Dodatni tretman je uspjesno dodan.");
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

                Skladiste s = new Skladiste()
                {
                    TretmanID = trenutnoDodaniTretman,
                    Kolicina = Convert.ToInt32(kolicinaInput.Text)
                };
                HttpResponseMessage responseSkladista = skladisteService.PostResponse(s);
              
            }
        }

        private void NazivDodatnogTretmanaInput_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(NazivDodatnogTretmanaInput.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(NazivDodatnogTretmanaInput, Messages.atName_req);
            }
            else
            {
                errorProvider.SetError(NazivDodatnogTretmanaInput, null);
            }
        }

        private void CijenaDodatnogTretmanaInput_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(CijenaDodatnogTretmanaInput.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(CijenaDodatnogTretmanaInput, Messages.atPrice_req);
            }
            else
            {
                errorProvider.SetError(CijenaDodatnogTretmanaInput, null);
            }
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

        private void DodajDodatniTretman_Load(object sender, EventArgs e)
        {
            BindVrsteUsluga();
        }
    }
}
