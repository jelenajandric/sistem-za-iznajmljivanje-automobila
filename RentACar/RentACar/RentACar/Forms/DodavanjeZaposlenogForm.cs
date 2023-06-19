﻿using RentACar.Data.DataAcces.Exceptions;
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
    public partial class DodavanjeZaposlenogForm : Form
    {
        string jezik;
        string tema;
        public DodavanjeZaposlenogForm() : this("", "")
        {
        }
         public DodavanjeZaposlenogForm(string jezik, string tema)
        {
            InitializeComponent();
            this.jezik = jezik;
            this.tema = tema;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            StringBuilder errorMessage = new StringBuilder();
            string ime = tbIme.Text.Trim();
            string prezime = tbPrezime.Text.Trim();
            string jmb = tbJmb.Text.Trim();
            string brojTelefona = tbBrojTelefona.Text.Trim();
            string email = (string)tbEmail.Text.Trim();
            string korisnickoIme = tbKorisnickoIme.Text.Trim();
            string lozinka = tbLozinka.Text.Trim();

            if (string.IsNullOrEmpty(ime) || string.IsNullOrEmpty(prezime) || string.IsNullOrEmpty(jmb) || string.IsNullOrEmpty(brojTelefona) ||
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

            Zaposleni z = new Zaposleni();
            Osoba o = new Osoba();
            z.ime = ime;
            o.ime = ime;
            z.prezime = prezime;
            o.prezime = prezime;
            z.jmb = jmb;
            o.jmb = jmb;
            z.brojTelefona = brojTelefona;
            o.brojTelefona = brojTelefona;
            z.email = email;
            o.email = email;
            z.korisnickoIme = korisnickoIme;
            z.lozinka = lozinka;
            try
            {
                Common.DataFactory.Osobe.addOsoba(o);
                Common.DataFactory.Zaposleni.dodajZaposlenog(z);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (DataAccessException ex)
            {
                new ObavjestenjeForm(ex.InnerException.Message, jezik, tema).ShowDialog();
            }
        }

        private void DodavanjeZaposlenogForm_Load(object sender, EventArgs e)
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
            tbIme.BackColor = backColor;
            tbIme.ForeColor = foreColor;
            tbPrezime.BackColor = backColor;
            tbPrezime.ForeColor = foreColor;
            tbJmb.BackColor = backColor;
            tbJmb.ForeColor = foreColor;
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
            lbJmb.Font = new Font(font, velicinaFonta, fs);
            lbBrojTelefona.Font = new Font(font, velicinaFonta, fs);
            lbEmail.Font = new Font(font, velicinaFonta, fs);
            lbKorisnickoIme.Font = new Font(font, velicinaFonta, fs);
            lbLozinka.Font = new Font(font, velicinaFonta, fs);

            tbIme.Font = new Font(font, velicinaFonta, fs);
            tbPrezime.Font = new Font(font, velicinaFonta, fs);
            tbJmb.Font = new Font(font, velicinaFonta, fs);
            tbBrojTelefona.Font = new Font(font, velicinaFonta, fs);
            tbEmail.Font = new Font(font, velicinaFonta, fs);
            tbKorisnickoIme.Font = new Font(font, velicinaFonta, fs);
            tbLozinka.Font = new Font(font, velicinaFonta, fs);
            btnDodaj.Font = new Font(font, velicinaFonta, fs);
        }

        private void ChangeLanguage(string lang)
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(lang);
            ComponentResourceManager resources = new ComponentResourceManager(typeof(DodavanjeZaposlenogForm));
            resources.ApplyResources(this, "$this");
            applyResources(resources, this.Controls);
            ApplyResourceToControl(this, new ComponentResourceManager(typeof(DodavanjeZaposlenogForm)), new CultureInfo(lang));

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
