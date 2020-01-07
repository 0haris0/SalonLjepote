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

namespace eHairdresserSalon_UI.Gifts
{
    public partial class IzmijeniNagradu : Form
    {
        private WebAPIHelper nagradeService = new WebAPIHelper("http://ndemirovic.app.fit.ba/", "api/Nagrade");
        private Nagrade n { get; set; }

        public IzmijeniNagradu(int nagradaid)
        {
            InitializeComponent();

            HttpResponseMessage response = nagradeService.GetResponse(nagradaid.ToString());

            if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                n = null;
            else if (response.IsSuccessStatusCode)
            {
                n = response.Content.ReadAsAsync<Nagrade>().Result;
            }
        }

        private void FillForm()
        {
            NazivNagradeInput.Text = n.Naziv;
            datumOdDateTimePicker.Value = n.Od;
            datumDoDateTimePicker.Value = n.Do;
        }

        private void izmijeniNagraduBtn_Click(object sender, EventArgs e)
        {
            if (n != null)
            {
                n.Naziv = NazivNagradeInput.Text;
                n.Od = datumOdDateTimePicker.Value;
                n.Do = datumDoDateTimePicker.Value;


                HttpResponseMessage response = nagradeService.PutResponse(n.NagradaID, n);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show(Messages.edit_gift_succ, Messages.msg_succ, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error Code" + response.StatusCode + " : Message - " + response.ReasonPhrase);
                }
            }
        }

        private void IzmijeniNagradu_Load(object sender, EventArgs e)
        {
            FillForm();
        }

        private void NazivNagradeInput_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(NazivNagradeInput.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(NazivNagradeInput, Messages.gName_req);
            }
            else
            {
                errorProvider.SetError(NazivNagradeInput, null);
            }
        }
    }
}
