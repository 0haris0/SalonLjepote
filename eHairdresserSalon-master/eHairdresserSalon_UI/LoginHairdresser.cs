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
    public partial class LoginHairdresser : Form
    {
        private WebAPIHelper frizeriService = new WebAPIHelper("http://ndemirovic.app.fit.ba/", "api/Frizeri");

        public LoginHairdresser()
        {
            InitializeComponent();
        }

        private void Prijava()
        {
            if (String.IsNullOrEmpty(KorisnickoImeInput.Text) || String.IsNullOrEmpty(LozinkaInput.Text))
                MessageBox.Show(Messages.usr_usr_req, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {

                HttpResponseMessage response = frizeriService.GetActionResponse("GetByUsername", KorisnickoImeInput.Text);

                if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                    MessageBox.Show(Messages.login_user_err, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);

                else if (response.IsSuccessStatusCode)
                {
                    Frizeri f = response.Content.ReadAsAsync<Frizeri>().Result;

                    if (UIHelper.GenerateHash(LozinkaInput.Text, f.LozinkaSalt) == f.LozinkaHash)
                    {
                        this.DialogResult = DialogResult.OK;
                        Global.prijavljeniFrizer = f;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(Messages.login_pass_err, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        LozinkaInput.Text = String.Empty;
                    }
                }
                else
                {
                    MessageBox.Show("Error Code" + response.StatusCode + " Message - " + response.ReasonPhrase);
                }
            }
        }

        private void potvrdiButton_Click(object sender, EventArgs e)
        {
            Prijava();
        }

        private void odustaniButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LozinkaInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Prijava();
        }
    }
}
