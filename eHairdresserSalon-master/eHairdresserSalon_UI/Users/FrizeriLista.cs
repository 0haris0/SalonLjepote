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
    public partial class FrizeriLista : Form
    {
        private WebAPIHelper uslugeService = new WebAPIHelper("http://ndemirovic.app.fit.ba/", "api/Frizeri");

        public FrizeriLista()
        {
            InitializeComponent();
            frizeriDataGridView.AutoGenerateColumns = true;
        }

        void BindForm()
        {
            HttpResponseMessage response = uslugeService.GetResponse();

            if (response.IsSuccessStatusCode)
            {
                List<Frizeri_Result> frizeri = response.Content.ReadAsAsync<List<Frizeri_Result>>().Result;
                foreach (var item in frizeri)
                {
                    if (item.UslugaOcjena == null && item.TretmanOcjena != null)
                        item.ProsjecnaOcjena = item.TretmanOcjena;
                    else if (item.UslugaOcjena != null && item.TretmanOcjena == null)
                        item.ProsjecnaOcjena = item.UslugaOcjena;
                    else
                        item.ProsjecnaOcjena = (item.UslugaOcjena + item.TretmanOcjena) / 2;

                }
                frizeriDataGridView.DataSource = frizeri;
           
            }
            else
            {
                MessageBox.Show("Error Code" + response.StatusCode + " : Message - " + response.ReasonPhrase);
            }
        }

        private void FrizeriLista_Load(object sender, EventArgs e)
        {
            BindForm();
        }

        private void DodajFrizeraBtn_Click(object sender, EventArgs e)
        {
            DodajFrizera frm = new DodajFrizera();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                BindForm();
            }
        }

        private void IzmijeniFrizeraBtn_Click(object sender, EventArgs e)
        {
            if (frizeriDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Odaberite frizera!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                IzmijeniFrizera frm = new IzmijeniFrizera(Convert.ToInt32(frizeriDataGridView.SelectedRows[0].Cells[0].Value));
                frm.ShowDialog();
                BindForm();
            }
        }

  
    }
}
