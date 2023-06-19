using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using RentACar.Util;
using RentACar.Data.Model;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Diagnostics;
using System.Globalization;

namespace RentACar.Forms
{
    public partial class PrijavaForm : Form
    {
        public PrijavaForm()
        {
            InitializeComponent();
            
        }

        private void btnPrijaviSe_Click(object sender, EventArgs e)
        {
            
            bool b1 = false;
            bool b2 = false;
            Administrator a = null;
            List<Administrator> administratori = Common.DataFactory.Administratori.getAdministratore();
            for(int i=0; i<administratori.Count; i++)
            {
                a = administratori[i]; 
                if(a.korisnickoIme.Equals(tbKorisnickoIme.Text))
                {
                    b1 = true;
                    if(a.lozinka.Equals(tbLozinka.Text))
                    {
                        b2 = true;
                        new AdminsInitialForm(a, cbJezik.SelectedItem.ToString()).ShowDialog();
                        tbKorisnickoIme.Text = "";
                        tbLozinka.Text = "";
                        return;
                        
                    }
                }
            }
            Zaposleni z = new Zaposleni();
            List<Zaposleni> zaposleni = Common.DataFactory.Zaposleni.getZaposlene("");
            for (int i = 0; i < zaposleni.Count; i++)
            {
                z = zaposleni[i];
                if (z.korisnickoIme.Equals(tbKorisnickoIme.Text))
                {
                    b1 = true;
                    if (z.lozinka.Equals(tbLozinka.Text))
                    {
                        b2 = true;
                        if (z.onemogucen == 0)
                        {
                            new ZaposleniInitialForm(z, cbJezik.SelectedItem.ToString()).ShowDialog();
                            tbKorisnickoIme.Text = "";
                            tbLozinka.Text = "";
                            break;
                        }
                        else
                        {
                            string sadrajPoruke = "";
                            if (cbJezik.SelectedItem.ToString().Equals("Srpski"))
                            {
                                sadrajPoruke = "Vaš nalog je onemogućen. Prijava nije uspjela!";
                            }
                            else
                            {
                                sadrajPoruke = "Your account has been disabled. Login failed!";
                            }
                            new ObavjestenjeForm(sadrajPoruke, cbJezik.SelectedItem.ToString(), "Standardna").ShowDialog();
                            return;
                        }
                    }
                }
                 
            }
            if (!b1)
            {
                string sadrajPoruke = "";
                if (cbJezik.SelectedItem.ToString().Equals("Srpski"))
                {
                    sadrajPoruke = "Uneseno korisnicko ime ne postoji!";
                }
                else
                {
                    sadrajPoruke = "The username you entered doesn't exist!";
                }
                new ObavjestenjeForm(sadrajPoruke, cbJezik.SelectedItem.ToString(), "Standardna").ShowDialog();
                
            }
            else if(!b2)
            {
                string sadrajPoruke = "";
                if (cbJezik.SelectedItem.ToString().Equals("Srpski"))
                {
                    sadrajPoruke = "Unesena lozinka nije tacna!";
                }
                else
                {
                    sadrajPoruke = "The password you entered is incorrect!";
                }
                new ObavjestenjeForm(sadrajPoruke, cbJezik.SelectedItem.ToString(), "Standardna").ShowDialog();
                
            } 
        }

        private void PrijavaForm_Load(object sender, EventArgs e)
        {
            cbJezik.SelectedIndex = 0;
            this.cbJezik.DropDownStyle = ComboBoxStyle.DropDownList;
            ChangeLanguage("sr-Latn-BA");

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbJezik.SelectedItem.ToString() == "Srpski")
            {
                ChangeLanguage("sr-Latn-BA");
            }
            else
            {
                ChangeLanguage("en");
            }
        }

        private void ChangeLanguage(string lang)
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(lang);
            ComponentResourceManager resources = new ComponentResourceManager(typeof(PrijavaForm));
            resources.ApplyResources(this, "$this");
            applyResources(resources, this.Controls);
            ApplyResourceToControl(this, new ComponentResourceManager(typeof(PrijavaForm)), new CultureInfo(lang));

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
