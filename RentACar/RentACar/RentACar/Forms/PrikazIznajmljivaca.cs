using RentACar.Data.Model;
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
    public partial class PrikazIznajmljivaca : Form
    {
        string jezik;
        string tema;
        Iznajmljivac i;
        public PrikazIznajmljivaca() : this(null, "", "")
        {
        }

        public PrikazIznajmljivaca(Iznajmljivac i, string jezik, string tema)
        {
            InitializeComponent();
            this.i = i;
            this.jezik = jezik;
            this.tema = tema;
        }

        private void PrikazIznajmljivaca_Load(object sender, EventArgs e)
        {
            if (jezik == "Srpski")
            {
                ChangeLanguage("sr-Latn-BA");
            }
            else
            {
                ChangeLanguage("en");
            }
            lbIme.Text += i.ime;
            lbPrezime.Text += i.prezime;
            lbJmb.Text += i.jmb;
            lbBrojTelefona.Text += i.brojTelefona;
            lbEmail.Text += i.email;
            lbAdresa.Text += i.adresa;
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
            
            lbIme.Font = new Font(font, velicinaFonta, fs);
            lbPrezime.Font = new Font(font, velicinaFonta, fs);
            lbBrojTelefona.Font = new Font(font, velicinaFonta, fs);
            lbEmail.Font = new Font(font, velicinaFonta, fs);
            lbAdresa.Font = new Font(font, velicinaFonta, fs);
            
        }

        private void ChangeLanguage(string lang)
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(lang);
            ComponentResourceManager resources = new ComponentResourceManager(typeof(PrikazIznajmljivaca));
            resources.ApplyResources(this, "$this");
            applyResources(resources, this.Controls);
            ApplyResourceToControl(this, new ComponentResourceManager(typeof(PrikazIznajmljivaca)), new CultureInfo(lang));

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
