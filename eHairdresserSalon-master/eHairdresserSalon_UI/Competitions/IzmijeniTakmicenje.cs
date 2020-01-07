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
    public partial class IzmijeniTakmicenje : Form
    {
        private WebAPIHelper takmicenjaService = new WebAPIHelper("http://ndemirovic.app.fit.ba/", "api/Takmicenja");
        private WebAPIHelper FrizeriService = new WebAPIHelper("http://ndemirovic.app.fit.ba/", "api/Frizeri");
        private Takmicenja t { get; set; }

        public IzmijeniTakmicenje(int takmicenjeid)
        {
            InitializeComponent();

            HttpResponseMessage response = takmicenjaService.GetResponse(takmicenjeid.ToString());

            if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                t = null;
            else if (response.IsSuccessStatusCode)
            {
                t = response.Content.ReadAsAsync<Takmicenja>().Result;
                FillForm();
            }
        }

        private void BindFrizeri()
        {
            HttpResponseMessage response = FrizeriService.GetResponse();

            if (response.IsSuccessStatusCode)
            {
                FrizerComboBox.DataSource = response.Content.ReadAsAsync<List<Frizeri_Result>>().Result; ;
                FrizerComboBox.DisplayMember = "ImePrezime";
                FrizerComboBox.ValueMember = "FrizerID";
            }
        }



        private void FillForm()
        {
            NazivInput.Text = t.Naziv;
            DatumTakmicenjaDateTimePicker.Value = t.Datum;
            MjestoInput.Text = t.Mjesto;
            OpisInput.Text = t.Opis;
            FrizerComboBox.SelectedValue = t.FrizerID;

        }

        private void SacuvajBtn_Click(object sender, EventArgs e)
        {
            if (t != null)
            {
                t.Naziv = NazivInput.Text;
                t.Datum = DatumTakmicenjaDateTimePicker.Value;
                t.Mjesto = MjestoInput.Text;
                t.Opis = OpisInput.Text;
                t.FrizerID = Convert.ToInt32(FrizerComboBox.SelectedValue);


                HttpResponseMessage response = takmicenjaService.PutResponse(t.TakmicenjeID, t);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show(Messages.edit_com_succ, Messages.msg_succ, MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void IzmijeniTakmicenje_Load(object sender, EventArgs e)
        {
            BindFrizeri();
            FillForm();
        }
    }
}
