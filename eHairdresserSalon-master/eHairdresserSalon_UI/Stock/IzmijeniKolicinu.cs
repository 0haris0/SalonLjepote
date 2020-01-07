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

namespace eHairdresserSalon_UI.Stock
{
    public partial class IzmijeniKolicinu : Form
    {
        private WebAPIHelper skladisteService = new WebAPIHelper("http://ndemirovic.app.fit.ba/", "api/Skladiste");
        private Skladiste s = new Skladiste();

        public IzmijeniKolicinu(int skaldisteId)
        {
            InitializeComponent();

            HttpResponseMessage response = skladisteService.GetResponse(skaldisteId.ToString());

            if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                s = null;
            else if (response.IsSuccessStatusCode)
            {
                s = response.Content.ReadAsAsync<Skladiste>().Result;
                FillForm();
            }
        }

        private void FillForm()
        {
            KolicinaInput.Text=s.Kolicina.ToString();
        }

        private void SacuvajBtn_Click(object sender, EventArgs e)
        {
            if (s != null)
            {
                s.Kolicina = Convert.ToInt32(KolicinaInput.Text);

                HttpResponseMessage response = skladisteService.PutResponse(s.SkladisteID, s);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show(Messages.edit_st_succ, Messages.msg_succ, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error Code" + response.StatusCode + " : Message - " + response.ReasonPhrase);
                }
            }
        }

        private void KolicinaInput_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(KolicinaInput.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(KolicinaInput, Messages.sName_req);
            }
            else
            {
                errorProvider.SetError(KolicinaInput, null);
            }
        }
    }
}
