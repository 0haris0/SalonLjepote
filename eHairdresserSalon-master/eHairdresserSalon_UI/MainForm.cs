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

namespace eHairdresserSalon_UI
{
    public partial class MainForm : Form
    {
        private WebAPIHelper TerminiService = new WebAPIHelper("http://ndemirovic.app.fit.ba/", "api/Termini");

        public MainForm()
        {
            InitializeComponent();
        }

        private void TerminiBtn_Click(object sender, EventArgs e)
        {
            Appointments.AppointmentsListForm alf = new Appointments.AppointmentsListForm();
            alf.Show();
        }

        private void KlijentiBtn_Click(object sender, EventArgs e)
        {
            IndexForm f = new IndexForm();
            f.Show();
        }

        private void UslugeBtn_Click(object sender, EventArgs e)
        {
            Services.UslugeListForm u = new Services.UslugeListForm();
            u.Show();
        }

        private void TakmicenjaBtn_Click(object sender, EventArgs e)
        {
            Competitions.TakmicenjaListForm t = new Competitions.TakmicenjaListForm();
            t.Show();
        }

        private void DodatniTretmaniBtn_Click(object sender, EventArgs e)
        {
            AdditionalTreatments.DodatniTretmaniListForm dt = new AdditionalTreatments.DodatniTretmaniListForm();
            dt.Show();
        }

        private void SkladisteBtn_Click(object sender, EventArgs e)
        {
            Stock.SkladisteListForm slf = new Stock.SkladisteListForm();
            slf.Show();
        }

        private void FrizeriBtn_Click_1(object sender, EventArgs e)
        {
            Users.FrizeriLista df = new Users.FrizeriLista();
            df.Show();
        }


        private void IzvjestajiBtn_Click(object sender, EventArgs e)
        {
            Appointments.AktivniTermini df = new Appointments.AktivniTermini();
            df.Show();
        }

        private void odjavaBtn_Click(object sender, EventArgs e)
        {
            //Application.Restart();
            Application.Exit();
        }

        private void NagradeBtn_Click(object sender, EventArgs e)
        {
            Gifts.NagradeListForm nl = new Gifts.NagradeListForm();
            nl.Show();
        }
    }
}
