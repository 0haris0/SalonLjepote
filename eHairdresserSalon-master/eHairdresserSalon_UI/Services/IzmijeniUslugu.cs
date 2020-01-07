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
    public partial class IzmijeniUslugu : Form
    {
        private WebAPIHelper uslugeService = new WebAPIHelper("http://ndemirovic.app.fit.ba/", "api/Usluge"); 
        private WebAPIHelper vrsteUslugaService = new WebAPIHelper("http://ndemirovic.app.fit.ba/", "api/VrsteUsluga");

        //private Usluge u = new Usluge();
        private Usluge u { get; set; }


        public IzmijeniUslugu(int uslugaId)
        {
            InitializeComponent();

            HttpResponseMessage response = uslugeService.GetResponse(uslugaId.ToString());

            if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                u = null;
            else if (response.IsSuccessStatusCode)
            {
                u = response.Content.ReadAsAsync<Usluge>().Result;
                //BindVrsteUsluga();
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
            NazivInput.Text = u.NazivUsluge;
            TrajanjeInput.Text = u.TrajanjeMinute.ToString();
            CijenaInput.Text = u.CijenaUsluge.ToString();
            vrstaUslugeComboBox.SelectedValue = u.VrstaUslugeID;
        }

        private void SacuvajBtn_Click(object sender, EventArgs e)
        {
            if (u != null)
            {
                u.NazivUsluge = NazivInput.Text;
                u.TrajanjeMinute = Convert.ToInt32(TrajanjeInput.Text);
                u.CijenaUsluge = Convert.ToDecimal(CijenaInput.Text);
                u.VrstaUslugeID = Convert.ToInt32(vrstaUslugeComboBox.SelectedValue);


                HttpResponseMessage response = uslugeService.PutResponse(u.UslugaID, u);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show(Messages.edit_ser_succ, Messages.msg_succ, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error Code" + response.StatusCode + " : Message - " + response.ReasonPhrase);
                }
            }
        }

        private void NazivInput_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(NazivInput.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(NazivInput, Messages.sName_req);
            }
            else
            {
                errorProvider.SetError(NazivInput, null);
            }
        }

        private void TrajanjeInput_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(TrajanjeInput.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(TrajanjeInput, Messages.sDuration_req);
            }
            else
            {
                errorProvider.SetError(TrajanjeInput, null);
            }
        }

        private void CijenaInput_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(CijenaInput.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(CijenaInput, Messages.sPrice_req);
            }
            else
            {
                errorProvider.SetError(CijenaInput, null);
            }
        }

        private void IzmijeniUslugu_Load(object sender, EventArgs e)
        {
            BindVrsteUsluga();
            FillForm();
        }
    }
}
