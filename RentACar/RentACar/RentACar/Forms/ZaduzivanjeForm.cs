using RentACar.Data.DataAcces.Exceptions;
using RentACar.Data.Model;
using RentACar.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACar.Forms
{
    public partial class ZaduzivanjeForm : Form
    {
        Zaposleni zap;
        Automobil auto;
        Iznajmljivac izn;
        Osoba oo;
        string jezik;
        string tema;
        public ZaduzivanjeForm() : this(null, null, "", "")
        {
        }

        public ZaduzivanjeForm(Automobil a, Zaposleni z, string jezik, string tema)
        {
            InitializeComponent();
            auto = a;
            zap = z;
            cbIznajmljivaci.DataSource = Common.DataFactory.Iznajmljivaci.getIznajmljivace2();
            this.jezik = jezik;
            this.tema = tema;
            

        }

        private void btnZaduzi_Click(object sender, EventArgs e)
        {
            
            StringBuilder errorMessage = new StringBuilder();
            string ime = tbIme.Text.Trim();
            string prezime = tbPrezime.Text.Trim();
            string jmb = tbJmb.Text.Trim();
            string brojTelefona = tbBrojTelefona.Text.Trim();
            string email = (string)tbEmail.Text.Trim();
            string adresa = tbAdresa.Text.Trim();
            
            if (string.IsNullOrEmpty(ime) || string.IsNullOrEmpty(prezime) || string.IsNullOrEmpty(jmb) || string.IsNullOrEmpty(brojTelefona) ||
                string.IsNullOrEmpty(email) || string.IsNullOrEmpty(adresa))
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

            Iznajmljivac i = new Iznajmljivac();
            Osoba o = new Osoba();
            i.ime = ime;
            o.ime = ime;
            i.prezime = prezime;
            o.prezime = prezime;
            i.jmb = jmb;
            o.jmb = jmb;
            i.brojTelefona = brojTelefona;
            o.brojTelefona = brojTelefona;
            i.email = email;
            o.email = email;
            i.adresa = adresa;
            izn = i;
            
            Iznajmljivanje iznajmljivanje = new Iznajmljivanje()
            {
                datumZaduzenja = DateTime.Now,
                datumRazduzenja = DateTime.MinValue,
                Automobil_idAutomobil = auto.idAutomobil,
                Automobil_naziv = auto.naziv,
                Iznajmljivac_jmb = izn.jmb,
                Iznajmljivac_ime = izn.ime,
                Iznajmljivac_prezime = izn.prezime,
                Zaposleni_jmb_zaduzuje = zap.jmb,
                Zaposleni_korisnickoIme_zaduzuje = zap.korisnickoIme,
                Zaposleni_jmb_razduzuje = zap.jmb,
                Zaposleni_KorisnickoIme_razduzuje = zap.korisnickoIme

            };
            try
            {
                Common.DataFactory.Osobe.addOsoba(o);
                Common.DataFactory.Iznajmljivaci.dodajIznajmljivaca(i);
                Common.DataFactory.Iznajmljivanja.dodajIznajmljivanje(iznajmljivanje);
                auto.zaduzen = 1;
                Common.DataFactory.Automobili.azurirajAutomobil(auto);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (DataAccessException ex)
            {
                new ObavjestenjeForm(ex.InnerException.Message, jezik, tema).ShowDialog();
            }
        }

        private void tmrTimer_Tick(object sender, EventArgs e)
        {
            lbVrijemeZaduzenja.Text = DateTime.Now.ToString();
        }

        private void btnZaduzi_Click_1(object sender, EventArgs e)
        {
            Iznajmljivac ii = (Iznajmljivac)cbIznajmljivaci.SelectedItem;
            Debug.WriteLine("ii.jmb = " + ii.jmb);
            izn = Common.DataFactory.Iznajmljivaci.getIznajmljivac(ii.jmb);
            oo = Common.DataFactory.Osobe.getOne(izn.jmb);
            Iznajmljivanje iznajmljivanje = new Iznajmljivanje()
            {
                datumZaduzenja = DateTime.Now,
                datumRazduzenja = DateTime.MinValue,
                Automobil_idAutomobil = auto.idAutomobil,
                Automobil_naziv = auto.naziv,
                Iznajmljivac_jmb = izn.jmb,
                Iznajmljivac_ime = izn.ime,
                Iznajmljivac_prezime = izn.prezime,
                Zaposleni_jmb_zaduzuje = zap.jmb,
                Zaposleni_korisnickoIme_zaduzuje = zap.korisnickoIme,
                Zaposleni_jmb_razduzuje = zap.jmb,
                Zaposleni_KorisnickoIme_razduzuje = zap.korisnickoIme

            };
            try
            {
                
                Common.DataFactory.Iznajmljivanja.dodajIznajmljivanje(iznajmljivanje);
                auto.zaduzen = 1;
                Common.DataFactory.Automobili.azurirajAutomobil(auto);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (DataAccessException ex)
            {
                new ObavjestenjeForm(ex.InnerException.Message, jezik, tema).ShowDialog();
            }
        }

        private void ZaduzivanjeForm_Load(object sender, EventArgs e)
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
            btnDodaj.BackColor = backColor;
            btnDodaj.ForeColor = foreColor;
            btnZaduzi.BackColor = backColor;
            btnZaduzi.ForeColor = foreColor;
            tbIme.BackColor = backColor;
            tbIme.ForeColor = foreColor;
            tbPrezime.BackColor = backColor;
            tbPrezime.ForeColor = foreColor;
            tbJmb.BackColor = backColor;
            tbJmb.ForeColor = foreColor;
            tbAdresa.BackColor = backColor;
            tbAdresa.ForeColor = foreColor;
            tbBrojTelefona.BackColor = backColor;
            tbBrojTelefona.ForeColor = foreColor;
            tbEmail.BackColor = backColor;
            tbEmail.ForeColor = foreColor;
            cbIznajmljivaci.BackColor = backColor;
            cbIznajmljivaci.ForeColor = foreColor;

            label1.Font = new Font(font, velicinaFonta, fs);
            lbIme.Font = new Font(font, velicinaFonta, fs);
            lbPrezime.Font = new Font(font, velicinaFonta, fs);
            lbJmb.Font = new Font(font, velicinaFonta, fs);
            lbBrojTelefona.Font = new Font(font, velicinaFonta, fs);
            lbEmail.Font = new Font(font, velicinaFonta, fs);
            lbAdresa.Font = new Font(font, velicinaFonta, fs);
            labelaVrijeme.Font = new Font(font, velicinaFonta, fs);
            lbVrijemeZaduzenja.Font = new Font(font, velicinaFonta, fs);

            tbIme.Font = new Font(font, velicinaFonta, fs);
            tbPrezime.Font = new Font(font, velicinaFonta, fs);
            tbJmb.Font = new Font(font, velicinaFonta, fs);
            tbBrojTelefona.Font = new Font(font, velicinaFonta, fs);
            tbEmail.Font = new Font(font, velicinaFonta, fs);
            tbAdresa.Font = new Font(font, velicinaFonta, fs);
            btnZaduzi.Font = new Font(font, velicinaFonta, fs);
            btnDodaj.Font = new Font(font, velicinaFonta, fs);
            cbIznajmljivaci.Font = new Font(font, velicinaFonta, fs);

        }

        private void ChangeLanguage(string lang)
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(lang);
            ComponentResourceManager resources = new ComponentResourceManager(typeof(ZaduzivanjeForm));
            resources.ApplyResources(this, "$this");
            applyResources(resources, this.Controls);
            ApplyResourceToControl(this, new ComponentResourceManager(typeof(ZaduzivanjeForm)), new CultureInfo(lang));

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
