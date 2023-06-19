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
    public partial class DetaljiForm : Form
    {
        string jezik;
        string tema;
        Automobil a;
        public DetaljiForm() : this(null, "", "")
        {
        }

        public DetaljiForm(Automobil a, string jezik, string tema)
        {
            InitializeComponent();
            this.a = a; 
            this.jezik = jezik;
            this.tema = tema;
        }

        private void DetaljiForm_Load(object sender, EventArgs e)
        {
            if (jezik == "Srpski")
            {
                ChangeLanguage("sr-Latn-BA");
            }
            else
            {
                ChangeLanguage("en");
            }

            Debug.WriteLine(a.putanjaDoSlike);
            this.pbSlikaAuta.Image = new System.Drawing.Bitmap(a.putanjaDoSlike);
            lbNazivICijena.Text = a.naziv + ": " + (a.cijena).ToString() + "KM/24h";
            lbKubikaza.Text += a.kubikaza;
            lbPotrosnja.Text += a.potrosnja;
            lbGorivo.Text += a.gorivo;
            lbGodinaProizvodnje.Text += a.godinaProizvodnje;
            lbTransmisija.Text += a.transmisija;
            lbKapacitetRezervoara.Text += a.kapacietetRezervoara;
            lbKonjskihSnaga.Text += a.konjskihSnaga;
            lbBrojSjedista.Text += a.brojSjedista;

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
            lbNazivICijena.Font = new Font(font, velicinaFonta, fs);
            lbKubikaza.Font = new Font(font, velicinaFonta, fs);
            lbPotrosnja.Font = new Font(font, velicinaFonta, fs);
            lbGorivo.Font = new Font(font, velicinaFonta, fs);
            lbTransmisija.Font = new Font(font, velicinaFonta, fs);
            lbGodinaProizvodnje.Font = new Font(font, velicinaFonta, fs);
            lbKapacitetRezervoara.Font = new Font(font, velicinaFonta, fs);
            lbKonjskihSnaga.Font = new Font(font, velicinaFonta, fs);
            lbBrojSjedista.Font = new Font(font, velicinaFonta, fs);

        }
        private void ChangeLanguage(string lang)
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(lang);
            ComponentResourceManager resources = new ComponentResourceManager(typeof(DetaljiForm));
            resources.ApplyResources(this, "$this");
            applyResources(resources, this.Controls);
            ApplyResourceToControl(this, new ComponentResourceManager(typeof(DetaljiForm)), new CultureInfo(lang));

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
