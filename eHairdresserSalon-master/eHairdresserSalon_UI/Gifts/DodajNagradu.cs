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
    public partial class DodajNagradu : Form
    {
        private WebAPIHelper nagradeService = new WebAPIHelper("http://ndemirovic.app.fit.ba/", "api/Nagrade");
        Nagrade n = new Nagrade();
        private FrizerskiSalonEntities dm = new FrizerskiSalonEntities();

        public DodajNagradu()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
        }

        private void dodajNagraduBtn_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                n.Naziv = NazivNagradeInput.Text;
                n.Od = datumOdDateTimePicker.Value;
                n.Do = datumDoDateTimePicker.Value;

                HttpResponseMessage response = nagradeService.PostResponse(n);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Nagrada je uspjesno dodana.");
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
