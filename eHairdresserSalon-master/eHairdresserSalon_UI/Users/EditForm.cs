using eHairdresserSalon_API.Models;
using eHairdresserSalon_UI.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eHairdresserSalon_UI.Users
{
    public partial class EditForm : Form
    {
        private WebAPIHelper klijentiService = new WebAPIHelper("http://ndemirovic.app.fit.ba/", "api/Klijenti");
        private Klijenti k = new Klijenti();

        public EditForm(int klijentId)
        {
            InitializeComponent();

            HttpResponseMessage response = klijentiService.GetResponse(klijentId.ToString());

            if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                k = null;
            else if (response.IsSuccessStatusCode)
            {
                k = response.Content.ReadAsAsync<Klijenti>().Result;
                FillForm();
            }
        }

        private void FillForm()
        {
            ImeInput.Text = k.Ime;
            PrezimeInput.Text = k.Prezime;
            datumRodjenjaDateTimePicker.Value = Convert.ToDateTime(k.DatumRodjenja);
            AdresaInput.Text = k.Adresa;
            EmailInput.Text = k.Email;
            BrojTelefonaInput.Text = k.BrojTelefona;
            NapomenaInput.Text = k.Napomena;
            KorisnickoImeInput.Text = k.KorisnickoIme;
        }

        private void sacuvajButton_Click(object sender, EventArgs e)
        {
            if (k != null)
            {
                k.Ime = ImeInput.Text;
                k.Prezime = PrezimeInput.Text;
                k.DatumRodjenja =datumRodjenjaDateTimePicker.Value;
                k.Adresa = AdresaInput.Text;
                k.Email = EmailInput.Text;
                k.BrojTelefona = BrojTelefonaInput.Text;
                k.Napomena = NapomenaInput.Text;

                k.KorisnickoIme = KorisnickoImeInput.Text;

                if (LozinkaInput.Text != String.Empty)
                {
                    k.LozinkaSalt = UIHelper.GenerateSalt();
                    k.LozinkaHash = UIHelper.GenerateHash(LozinkaInput.Text, k.LozinkaSalt);
                }

                HttpResponseMessage response = klijentiService.PutResponse(k.KlijentID, k);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show(Messages.edit_usr_succ, Messages.msg_succ, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error Code" + response.StatusCode + " : Message - " + response.ReasonPhrase);
                }
            }
        }

        private void ImeInput_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(ImeInput.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(ImeInput, Messages.fName_req);
            }
            else
            {
                errorProvider.SetError(ImeInput, null);
            }
        }

        private void PrezimeInput_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(PrezimeInput.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(PrezimeInput, Messages.lName_req);
            }
            else
            {
                errorProvider.SetError(PrezimeInput, null);
            }
        }

        private void EmailInput_Validating(object sender, CancelEventArgs e)
        {
            if (!(string.IsNullOrEmpty(EmailInput.Text)))
            {
                try
                {
                    MailAddress mail = new MailAddress(EmailInput.Text);
                    errorProvider.SetError(EmailInput, null);
                }
                catch (Exception)
                {
                    e.Cancel = true;
                    errorProvider.SetError(EmailInput, Messages.email_err);
                }
            }
        }

        private void KorisnickoImeInput_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(KorisnickoImeInput.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider.SetError(KorisnickoImeInput, Messages.usr_req);
            }
            else if (!(String.IsNullOrEmpty(KorisnickoImeInput.Text.Trim())))
            {
                HttpResponseMessage response = klijentiService.GetActionResponse("GetByUsername", KorisnickoImeInput.Text.Trim());
                if (response.IsSuccessStatusCode)
                {
                    Klijenti k = response.Content.ReadAsAsync<Klijenti>().Result;
                    if (k.KorisnickoIme == KorisnickoImeInput.Text.Trim())
                    {
                        e.Cancel = true;
                        errorProvider.SetError(KorisnickoImeInput, Messages.username_con);
                    }
                }
            }
            else
                errorProvider.SetError(KorisnickoImeInput, null);
        }

        private void LozinkaInput_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(LozinkaInput.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider.SetError(LozinkaInput, Messages.lozinka_req);
            }
            else if (LozinkaInput.TextLength < 6 || !LozinkaInput.Text.Any(char.IsDigit) || !LozinkaInput.Text.Any(char.IsLetter))
            {
                e.Cancel = true;
                errorProvider.SetError(LozinkaInput, Messages.lozinka_err);
            }
            else
                errorProvider.SetError(LozinkaInput, null);
        }
    }
}
