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
    public partial class DodajTermin : Form
    {
        private WebAPIHelper TerminiService = new WebAPIHelper("http://ndemirovic.app.fit.ba/", "api/Termini");
        private WebAPIHelper UslugeService = new WebAPIHelper("http://ndemirovic.app.fit.ba/", "api/Usluge");
        private WebAPIHelper FrizeriService = new WebAPIHelper("http://ndemirovic.app.fit.ba/", "api/Frizeri");
        private WebAPIHelper KlijentiService = new WebAPIHelper("http://ndemirovic.app.fit.ba/", "api/Klijenti");
        private WebAPIHelper DodatniTretmaniService = new WebAPIHelper("http://ndemirovic.app.fit.ba/", "api/DodatniTretmani");


        private Termini t = new Termini();
        private FrizerskiSalonEntities dm = new FrizerskiSalonEntities();


        public DodajTermin()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
        }
      

        private void BindFrizeri()
        {
            HttpResponseMessage response = FrizeriService.GetResponse();
            if (response.IsSuccessStatusCode)
            {
                List<Frizeri_Result> lst = response.Content.ReadAsAsync<List<Frizeri_Result>>().Result;
                lst.Insert(0, new Frizeri_Result() { ImePrezime = "Odaberite frizera: " });
                frizeriComboBox.DataSource = lst;
                frizeriComboBox.DisplayMember = "ImePrezime";
                frizeriComboBox.ValueMember = "FrizerID";
            }
        }

        private void DodajTermin_Load(object sender, EventArgs e)
        {
            BindFrizeri();

        }

        private void klijentiComboBox_Format(object sender, ListControlConvertEventArgs e)
        {
            string ime = ((Klijenti)e.ListItem).Ime;
            string prezime = ((Klijenti)e.ListItem).Prezime;
            e.Value = ime + " " + prezime;
        }

        private void frizeriComboBox_Format(object sender, ListControlConvertEventArgs e)
        {
            string imeprezime = ((Frizeri_Result)e.ListItem).ImePrezime;
            e.Value = imeprezime;
        }

        private void dodajTerminBtn_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                Termini t = new Termini();
                t.Datum = datumDateTimePicker.Value;
                DateTime dt = vrijemeDateTimePicker.Value;
                TimeSpan st = new TimeSpan(dt.Hour, dt.Minute, 0);
                t.Vrijeme = st;
                t.Zauzeto = false;
                t.KlijentID = null;
                t.UslugaID = null;
                t.prosaoTermin = false;

                if (t == null)
                    t = new Termini();



                if (frizeriComboBox.SelectedIndex != 0)
                    t.FrizerID = Convert.ToInt32(frizeriComboBox.SelectedValue);


                HttpResponseMessage response = TerminiService.PostResponse(t);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Termin je uspjesno dodan.");
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                    MessageBox.Show(response.ReasonPhrase, Messages.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void frizeriComboBox_Validating(object sender, CancelEventArgs e)
        {
            if (frizeriComboBox.SelectedIndex == 0)
            {
                e.Cancel = true;
                errorProvider.SetError(frizeriComboBox, Messages.appHairdresser_req);
            }
            else
            {
                errorProvider.SetError(frizeriComboBox, null);
            }
        }
    }
}
