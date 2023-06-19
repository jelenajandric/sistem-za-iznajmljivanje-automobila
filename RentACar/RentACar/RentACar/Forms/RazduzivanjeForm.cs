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
    public partial class RazduzivanjeForm : Form
    {
        Automobil auto;
        Zaposleni zap;
        string jezik;
        string tema;
        double zaPlatiti = 0;
        public RazduzivanjeForm() : this(null, null, "", "")
        {
        }

        public RazduzivanjeForm(Automobil a, Zaposleni z, string jezik, string tema)
        {
            InitializeComponent();
            auto = a;
            zap = z;
            this.jezik = jezik;
            this.tema = tema;
            DateTime vrijemeIznajmljivanja = Common.DataFactory.Iznajmljivanja.GetVrijemeIznajmljivanja(auto.idAutomobil);
            double brojDana = (DateTime.Now - vrijemeIznajmljivanja).TotalDays;
            Debug.WriteLine("broj dana=" + brojDana);
            
            zaPlatiti = auto.cijena * brojDana;
            zaPlatiti = Math.Round(zaPlatiti , 2);
            Debug.WriteLine("za platiti = " + zaPlatiti);
            lbCijena.Text = zaPlatiti + "KM";
        }

        private void btnNe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDa_Click(object sender, EventArgs e)
        {
            
            Common.DataFactory.Iznajmljivanja.azurirajIznajmljivanje(DateTime.Now, zap, auto.idAutomobil);
            auto.zaduzen = 0;
            Common.DataFactory.Automobili.azurirajAutomobil(auto);
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbvrijemeRazduzivanja.Text = DateTime.Now.ToString();
        }

        private void RazduzivanjeForm_Load(object sender, EventArgs e)
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
            lbCijena.Text = zaPlatiti + "KM";
        }

        private void promjeniTemu(Color backColorForm, Color foreColor, Color backColor, String font, FontStyle fs, float velicinaFonta)
        {
            this.BackColor = backColorForm;
            this.ForeColor = foreColor;
            btnDa.BackColor = backColor;
            btnDa.ForeColor = foreColor;
            btnNe.BackColor = backColor;
            btnNe.ForeColor = foreColor;

            label1.Font = new Font(font, velicinaFonta, fs);
            labelacijena.Font = new Font(font, velicinaFonta, fs);
            labelaVrijeme.Font = new Font(font, velicinaFonta, fs);
            lbvrijemeRazduzivanja.Font = new Font(font, velicinaFonta, fs);
            lbCijena.Font = new Font(font, velicinaFonta, fs);
            btnDa.Font = new Font(font, velicinaFonta, fs);
            btnNe.Font = new Font(font, velicinaFonta, fs);
        }

        private void ChangeLanguage(string lang)
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(lang);
            ComponentResourceManager resources = new ComponentResourceManager(typeof(RazduzivanjeForm));
            resources.ApplyResources(this, "$this");
            applyResources(resources, this.Controls);
            ApplyResourceToControl(this, new ComponentResourceManager(typeof(RazduzivanjeForm)), new CultureInfo(lang));

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
