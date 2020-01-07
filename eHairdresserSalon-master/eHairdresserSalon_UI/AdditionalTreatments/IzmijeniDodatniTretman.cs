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
    public partial class IzmijeniDodatniTretman : Form
    {

        private WebAPIHelper DodatniTretmaniService = new WebAPIHelper("http://ndemirovic.app.fit.ba/", "api/DodatniTretmani");
        private WebAPIHelper vrsteUslugaService = new WebAPIHelper("http://ndemirovic.app.fit.ba/", "api/VrsteUsluga");

        private DodatniTretmani t { get; set; }

        public IzmijeniDodatniTretman(int dodatniTretmanId)
        {
            InitializeComponent();

            HttpResponseMessage response = DodatniTretmaniService.GetResponse(dodatniTretmanId.ToString());

            if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                t = null;
            else if (response.IsSuccessStatusCode)
            {
                t = response.Content.ReadAsAsync<DodatniTretmani>().Result;
                //FillForm();
            }
        }

        private void BindVrsteUsluga()
        {
            HttpResponseMessage response = vrsteUslugaService.GetResponse();
            if (response.IsSuccessStatusCode)
            {
                List<VrsteUsluga_Result> lst = response.Content.ReadAsAsync<List<VrsteUsluga_Result>>().Result;
                vrstaUslugeComboBox.DataSource = lst;
                vrstaUslugeComboBox.DisplayMember = "Naziv";
                vrstaUslugeComboBox.ValueMember = "VrstaUslugeID";
            }
        }

        private void FillForm()
        {
            NazivDodatnogTretmanaInput.Text = t.NazivTretmana;
            CijenaDodatnogTretmanaInput.Text = t.Cijena.ToString();
            vrstaUslugeComboBox.SelectedValue = t.VrstaUslugeID;
        }

        private void SacuvajBtn_Click(object sender, EventArgs e)
        {
            if (t != null)
            {
                t.NazivTretmana = NazivDodatnogTretmanaInput.Text;
                t.Cijena = Convert.ToInt32(CijenaDodatnogTretmanaInput.Text);
                t.VrstaUslugeID = Convert.ToInt32(vrstaUslugeComboBox.SelectedValue);

                HttpResponseMessage response = DodatniTretmaniService.PutResponse(t.TretmanID, t);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show(Messages.edit_addT_succ, Messages.msg_succ, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error Code" + response.StatusCode + " : Message - " + response.ReasonPhrase);
                }
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

        private void IzmijeniDodatniTretman_Load(object sender, EventArgs e)
        {
            BindVrsteUsluga();
            FillForm();
        }
    }
}
