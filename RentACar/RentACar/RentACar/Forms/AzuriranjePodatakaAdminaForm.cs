using RentACar.Data.DataAcces.Exceptions;
using RentACar.Data.Model;
using RentACar.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACar.Forms
{
    public partial class AzuriranjePodatakaAdminaForm : Form
    {
        Administrator admin;
        string jezik;
        string tema;
        public AzuriranjePodatakaAdminaForm() : this(null, "", "")
        {
        }

        public AzuriranjePodatakaAdminaForm(Administrator a, string jezik, string tema)
        {
            InitializeComponent();
            this.admin = Common.DataFactory.Administratori.getOne(a.jmb);
            Osoba o = Common.DataFactory.Osobe.getOne(admin.jmb);
            tbIme.Text = o.ime;
            tbPrezime.Text = o.prezime;
            tbBrojTelefona.Text = o.brojTelefona;
            tbEmail.Text = o.email;
            tbKorisnickoIme.Text = admin.korisnickoIme;
            tbLozinka.Text = admin.lozinka;
            this.jezik = jezik;
            this.tema = tema;
        }

        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            StringBuilder errorMessage = new StringBuilder();
            string ime = tbIme.Text.Trim();
            string prezime = tbPrezime.Text.Trim();
            string brojTelefona = tbBrojTelefona.Text.Trim();
            string email = (string)tbEmail.Text.Trim();
            string korisnickoIme = tbKorisnickoIme.Text.Trim();
            string lozinka = tbLozinka.Text.Trim();

            if (string.IsNullOrEmpty(ime) || string.IsNullOrEmpty(prezime) || string.IsNullOrEmpty(brojTelefona) ||
                string.IsNullOrEmpty(email) || string.IsNullOrEmpty(korisnickoIme) || string.IsNullOrEmpty(lozinka))
            {
                if (jezik.Equals("Srpski"))
                {
                    errorMessage.AppendLine("Morate popuniti sva polja!");
                }
                else
                {
                    errorMessage.AppendLine("You must enter data in all fields!");
                }
            }

            if (errorMessage.Length > 0)
            {
                new ObavjestenjeForm(errorMessage.ToString(), jezik, tema).ShowDialog();
                return;
            }

            Administrator a = new Administrator();
            Osoba o = new Osoba();
            a.ime = ime;
            o.ime = ime;
            a.prezime = prezime;
            o.prezime = prezime; 
            a.brojTelefona = brojTelefona;
            o.brojTelefona = brojTelefona;
            a.email = email;
            o.email = email;
            a.korisnickoIme = korisnickoIme;
            a.lozinka = lozinka;
            a.jmb = admin.jmb;
            o.jmb = admin.jmb;
            try
            {
                Common.DataFactory.Osobe.azurirajOsobu(o);
                Common.DataFactory.Administratori.azurirajAdministratora(a, admin.jmb);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (DataAccessException ex)
            {
                new ObavjestenjeForm(ex.InnerException.Message, jezik, tema).ShowDialog();
            }
        }

        private void AzuriranjePodatakaAdminaForm_Load(object sender, EventArgs e)
        {
            if (jezik == "Srpski")
            {
                ChangeLanguage("sr-Latn-BA");
            }
            else
            {
                ChangeLanguage("en");
            }

            if (tema == "Tamna")
            {
                promjeniTemu(Color.DimGray, Color.White, Color.Gray, "Consolas", FontStyle.Bold, 9);
            }
            else if (tema == "Zelena")
            {
                promjeniTemu(Color.DarkSeaGreen, Color.Maroon, Color.Azure, "Reem Kufi", FontStyle.Regular, 9);
            }
            else if (tema == "Plava")
            {
                promjeniTemu(Color.LightSteelBlue, Color.SaddleBrown, Color.LightGray, "Lucida Handwriting", FontStyle.Bold, 9);
            }
            else
            {
                promjeniTemu(Color.WhiteSmoke, Color.Black, Color.Gainsboro, "Microsoft Sans Serif", FontStyle.Regular, 9);
            }
        }

        private void promjeniTemu(Color backColorForm, Color foreColor, Color backColor, String font, FontStyle fs, float velicinaFonta)
        {
            this.BackColor = backColorForm;
            this.ForeColor = foreColor;
            btnPotvrdi.BackColor = backColor;
            btnPotvrdi.ForeColor = foreColor;
            tbIme.BackColor = backColor;
            tbIme.ForeColor = foreColor;
            tbPrezime.BackColor = backColor;
            tbPrezime.ForeColor = foreColor;
            tbKorisnickoIme.BackColor = backColor;
            tbKorisnickoIme.ForeColor = foreColor;
            tbLozinka.BackColor = backColor;
            tbLozinka.ForeColor = foreColor;
            tbBrojTelefona.BackColor = backColor;
            tbBrojTelefona.ForeColor = foreColor;
            tbEmail.BackColor = backColor;
            tbEmail.ForeColor = foreColor;

            label1.Font = new Font(font, velicinaFonta, fs);
            lbIme.Font = new Font(font, velicinaFonta, fs);
            lbPrezime.Font = new Font(font, velicinaFonta, fs);
            lbBrojTelefona.Font = new Font(font, velicinaFonta, fs);
            lbEmail.Font = new Font(font, velicinaFonta, fs);
            lbKorisnickoIme.Font = new Font(font, velicinaFonta, fs);
            lbLozinka.Font = new Font(font, velicinaFonta, fs);

            tbIme.Font = new Font(font, velicinaFonta, fs);
            tbPrezime.Font = new Font(font, velicinaFonta, fs);
            tbBrojTelefona.Font = new Font(font, velicinaFonta, fs);
            tbEmail.Font = new Font(font, velicinaFonta, fs);
            tbKorisnickoIme.Font = new Font(font, velicinaFonta, fs);
            tbLozinka.Font = new Font(font, velicinaFonta, fs);
            btnPotvrdi.Font = new Font(font, velicinaFonta, fs);
        }

        private void ChangeLanguage(string lang)
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(lang);
            ComponentResourceManager resources = new ComponentResourceManager(typeof(AzuriranjePodatakaAdminaForm));
            resources.ApplyResources(this, "$this");
            applyResources(resources, this.Controls);
            ApplyResourceToControl(this, new ComponentResourceManager(typeof(AzuriranjePodatakaAdminaForm)), new CultureInfo(lang));

        }
        private void applyResources(ComponentResourceManager resources, Control.ControlCollection ctls)
        {
            foreach (Control ctl in ctls)
            {
                resources.ApplyResources(ctl, ctl.Name);
                applyResources(resources, ctl.Controls);
            }
        }
        private void ApplyResourceToControl(Control control, ComponentResourceManager cmp, CultureInfo cultureInfo)
        {
            cmp.ApplyResources(control, control.Name, cultureInfo);

            foreach (Control child in control.Controls)
            {
                ApplyResourceToControl(child, cmp, cultureInfo);
            }
        }
    }
}
