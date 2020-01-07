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

namespace eHairdresserSalon_UI.Appointments
{
    public partial class IzmijeniTermin : Form
    {
        private WebAPIHelper TerminiService = new WebAPIHelper("http://ndemirovic.app.fit.ba/", "api/Termini");
        private WebAPIHelper FrizeriService = new WebAPIHelper("http://ndemirovic.app.fit.ba/", "api/Frizeri");
        private WebAPIHelper SkladisteService = new WebAPIHelper("http://ndemirovic.app.fit.ba/", "api/Skladiste");
        private Termini t { get; set; }


        public IzmijeniTermin(int terminid)
        {
            InitializeComponent();

            HttpResponseMessage response = TerminiService.GetResponse(terminid.ToString());

            if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                t = null;
            else if (response.IsSuccessStatusCode)
            {
                t = response.Content.ReadAsAsync<Termini>().Result;
            }
        }

        private void BindFrizeri()
        {
            HttpResponseMessage response = FrizeriService.GetResponse();

            if (response.IsSuccessStatusCode)
            {
                frizeriComboBox.DataSource = response.Content.ReadAsAsync<List<Frizeri_Result>>().Result; ;
                frizeriComboBox.DisplayMember = "ImePrezime";
                frizeriComboBox.ValueMember = "FrizerID";
            }
        }

        private void FillForm()
        {
            datumDateTimePicker.Value = t.Datum;
            DateTime dt = vrijemeDateTimePicker.Value;
            TimeSpan st = new TimeSpan(dt.Hour, dt.Minute, 0);
            st = t.Vrijeme;
            if (t.prosaoTermin==true)
            {
                checkBoxProsaoTermin.Checked = Convert.ToBoolean(t.prosaoTermin);
                checkBoxProsaoTermin.Enabled = false;
            }

            DateTime v = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, t.Vrijeme.Hours, t.Vrijeme.Minutes, 0);
            vrijemeDateTimePicker.Value = v;

            frizeriComboBox.SelectedValue = t.FrizerID;
        }

        private void SacuvajBtn_Click(object sender, EventArgs e)
        {
            if (t != null)
            {
                t.Datum = datumDateTimePicker.Value;
                DateTime dt = vrijemeDateTimePicker.Value;
                TimeSpan st = new TimeSpan(dt.Hour, dt.Minute, 0);
                t.Vrijeme = st;
                t.FrizerID = Convert.ToInt32(frizeriComboBox.SelectedValue);

                if (t.prosaoTermin != true && checkBoxProsaoTermin.Checked==true)
                {
                    HttpResponseMessage skladisteGet = SkladisteService.GetActionResponse("GetSkladisteByTretman", t.TretmanID.ToString());
                    if (skladisteGet.IsSuccessStatusCode)
                    {
                        Skladiste s = skladisteGet.Content.ReadAsAsync<Skladiste>().Result;
                        s.Kolicina = -1;

                        HttpResponseMessage skladistePut = SkladisteService.PutResponse(s.SkladisteID, s);
                    }
                }

                t.prosaoTermin = checkBoxProsaoTermin.Checked;


                HttpResponseMessage response = TerminiService.PutResponse(t.TerminID, t);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show(Messages.edit_appo_succ, Messages.msg_succ, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error Code" + response.StatusCode + " : Message - " + response.ReasonPhrase);
                }
            }
        }

        private void IzmijeniTermin_Load(object sender, EventArgs e)
        {
            BindFrizeri();
            FillForm();
        }
    }
}
