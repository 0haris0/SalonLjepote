using eHairdresserSalon_API.Models;
using eHairdresserSalon_UI.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eHairdresserSalon_UI.Users
{
    public partial class DodajFrizera : Form
    {
        private WebAPIHelper frizeriService = new WebAPIHelper("http://ndemirovic.app.fit.ba/", "api/Frizeri");
        private WebAPIHelper vrsteUslugaService = new WebAPIHelper("http://ndemirovic.app.fit.ba/", "api/VrsteUsluga");
        private Frizeri f = new Frizeri();

        public DodajFrizera()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
        }

        private void BindVrsteUsluga()
        {
            HttpResponseMessage response = vrsteUslugaService.GetResponse();
            if (response.IsSuccessStatusCode)
            {
                List<VrsteUsluga_Result> lst = response.Content.ReadAsAsync<List<VrsteUsluga_Result>>().Result;
                lst.Insert(0, new VrsteUsluga_Result() { Naziv = "Odaberite: " });
                vrstaUslugeComboBox.DataSource = lst;
                vrstaUslugeComboBox.DisplayMember = "Naziv";
                vrstaUslugeComboBox.ValueMember = "VrstaUslugeID";
            }
        }

        private void DodajFrizeraBtn_Click(object sender, EventArgs e)
        {

            if (this.ValidateChildren())
            {
               
                f.Ime = ImeInput.Text;
                f.Prezime = PrezimeInput.Text;
                f.KorisnickoIme = KorisnickoImeInput.Text;
                f.LozinkaSalt = UIHelper.GenerateSalt();
                f.LozinkaHash = UIHelper.GenerateHash(LozinkaInput.Text, f.LozinkaSalt);
                f.Opis = opisInput.Text;

                if (vrstaUslugeComboBox.SelectedIndex != 0)
                    f.VrstaUslugeID = Convert.ToInt32(vrstaUslugeComboBox.SelectedValue);

                HttpResponseMessage response = frizeriService.PostResponse(f);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Uposlenik je uspjesno dodan.");
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                    MessageBox.Show("Error code: " + response.StatusCode + " Message: " + response.ReasonPhrase);
            }
        }

        private void ucitajSlikuBtn_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Image orgImage = Image.FromFile(openFileDialog.FileName);
                if (orgImage.Width > 750 || orgImage.Height > 750)
                    MessageBox.Show("Velicina slike nije podrzana. Izaberite manju sliku.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    slikaInput.Text = openFileDialog.FileName;

                    MemoryStream ms = new MemoryStream();
                    orgImage.Save(ms, ImageFormat.Jpeg);
                    f.ProfilnaSlika = ms.ToArray();

                    int resizedImageWidth = Convert.ToInt32(ConfigurationManager.AppSettings["resizedImageWidth"]);
                    int resizedImageHeight = Convert.ToInt32(ConfigurationManager.AppSettings["resizedImageHeight"]);
                    int croppedImageWidth = Convert.ToInt32(ConfigurationManager.AppSettings["croppedImageWidth"]);
                    int croppedImageHeight = Convert.ToInt32(ConfigurationManager.AppSettings["croppedImageHeight"]);

                    if (orgImage.Width > resizedImageWidth && orgImage.Height > resizedImageHeight)
                    {
                        Image resizedImage = Util.UIHelper.ResizeImage(orgImage, new Size(resizedImageWidth, resizedImageHeight));
                        Image croppedImage = resizedImage;

                        if (resizedImage.Width >= croppedImageWidth && resizedImage.Height >= croppedImageHeight)
                        {
                            int croppedX = (resizedImageWidth - croppedImageWidth) / 2;
                            int croppedY = (resizedImageHeight - croppedImageHeight) / 2;
                            croppedImage = Util.UIHelper.CropImage(resizedImage, new Rectangle(croppedX, croppedY, croppedImageWidth, croppedImageHeight));

                            pictureBox.Image = croppedImage;

                            MemoryStream ms2 = new MemoryStream();
                            croppedImage.Save(ms2, ImageFormat.Jpeg);
                            f.SlikaThumb = ms2.ToArray();
                        }
                        else
                        {
                            pictureBox.Image = resizedImage;

                            MemoryStream ms2 = new MemoryStream();
                            resizedImage.Save(ms2, ImageFormat.Jpeg);
                            f.SlikaThumb = ms2.ToArray();
                        }
                    }
                    else
                    {
                        pictureBox.Image = orgImage;

                        MemoryStream ms2 = new MemoryStream();
                        orgImage.Save(ms2, orgImage.RawFormat);
                        f.SlikaThumb = ms2.ToArray();
                    }

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
                HttpResponseMessage response = frizeriService.GetActionResponse("GetByUsername", KorisnickoImeInput.Text.Trim());
                if (response.IsSuccessStatusCode)
                {
                    Frizeri f = response.Content.ReadAsAsync<Frizeri>().Result;
                    if (f.KorisnickoIme == KorisnickoImeInput.Text.Trim())
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

        private void vrstaUslugeComboBox_Validating(object sender, CancelEventArgs e)
        {
            if (vrstaUslugeComboBox.SelectedIndex == 0)
            {
                e.Cancel = true;
                errorProvider.SetError(vrstaUslugeComboBox, Messages.serviceType_req);
            }
            else
            {
                errorProvider.SetError(vrstaUslugeComboBox, null);
            }
        }

        private void DodajFrizera_Load(object sender, EventArgs e)
        {
            BindVrsteUsluga();
        }
    }
}
