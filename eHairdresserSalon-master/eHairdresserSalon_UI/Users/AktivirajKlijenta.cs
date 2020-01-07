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

namespace eHairdresserSalon_UI.Users
{
    public partial class AktivirajKlijenta : Form
    {
        private WebAPIHelper klijentiService = new WebAPIHelper("http://ndemirovic.app.fit.ba/", "api/Klijenti");

        List<Klijenti> klijenti = new List<Klijenti>();

        public AktivirajKlijenta()
        {
            InitializeComponent();


        }

        private void BindGrid()
        {
            klijenti.Clear();

            HttpResponseMessage responseGet = klijentiService.GetActionResponse("GetNeaktivniKlijenti");
            if (responseGet.IsSuccessStatusCode)
            {
                klijenti = responseGet.Content.ReadAsAsync<List<Klijenti>>().Result;
                dataGridViewKlijenti.DataSource = klijenti;
                dataGridViewKlijenti.ClearSelection();
                dataGridViewKlijenti.Columns[0].Visible = false;
            }
        }

        private void AktivirajKlijenta_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void btnAktiviraj_Click(object sender, EventArgs e)
        {
            if (dataGridViewKlijenti.SelectedRows.Count == 0)
            {
                MessageBox.Show("Odaberite klijenta!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int index = Convert.ToInt32(dataGridViewKlijenti.SelectedRows[0].Index);
                Klijenti odabrani = klijenti[index];
                odabrani.Aktivan = true;

                HttpResponseMessage responsePut = klijentiService.PutResponse(odabrani.KlijentID, odabrani);
                if (responsePut.IsSuccessStatusCode)
                {
                    MessageBox.Show("Klijent je uspješno aktiviran.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                BindGrid();
            }
        }
    }
}
