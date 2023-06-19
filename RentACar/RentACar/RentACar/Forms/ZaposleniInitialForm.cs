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
    public partial class ZaposleniInitialForm : Form
    {
        Zaposleni z = new Zaposleni();
        string jezik;
        string tema;
        public ZaposleniInitialForm() : this(null, "")
        {
        }
        public ZaposleniInitialForm(Zaposleni zap, string jezik)
        {
            InitializeComponent();
            this.z = zap;
            this.jezik = jezik;
            this.tema = z.tema;
            if (z.tema == "Standardna" || z.tema == "Standard")
            {
                cbTema.SelectedIndex = 0;
            }
            else if (z.tema == "Tamna" || z.tema == "Dark")
            {
                cbTema.SelectedIndex = 1;
            }
            else if (z.tema == "Zelena" || z.tema == "Green")
            {
                cbTema.SelectedIndex = 2;
            }
            else
            {
                cbTema.SelectedIndex = 3;
            }
        }

        private void btnPregledVoznogParka_Click(object sender, EventArgs e)
        {
            new PrikazAutomobilaForm(z, jezik, tema).ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new AzuriranjePodatakaZaposlenogForm(z, jezik, tema).ShowDialog();
        }

        private void btnOdjaviSe_Click(object sender, EventArgs e)
        {
            this.Close();
            z = null;
        }

        private void ZaposleniInitialForm_Load(object sender, EventArgs e)
        {
            this.cbTema.DropDownStyle = ComboBoxStyle.DropDownList;
            if (jezik == "Srpski")
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
            ComponentResourceManager resources = new ComponentResourceManager(typeof(ZaposleniInitialForm));
            resources.ApplyResources(this, "$this");
            applyResources(resources, this.Controls);
            ApplyResourceToControl(this, new ComponentResourceManager(typeof(ZaposleniInitialForm)), new CultureInfo(lang));

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

        private void cbTema_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTema.SelectedIndex == 1) //tamna
            {
                promjeniTemu(Color.DimGray, Color.White, Color.Gray, "Consolas", FontStyle.Bold, 9);
                z.tema = "Tamna";
                tema = "Tamna";
                Common.DataFactory.Zaposleni.azurirajTemu(z, z.jmb);
            }
            else if (cbTema.SelectedIndex == 2) //zelena
            {
                promjeniTemu(Color.DarkSeaGreen, Color.Maroon, Color.Azure, "Reem Kufi", FontStyle.Regular, 9);
                z.tema = "Zelena";
                tema = "Zelena";
                Common.DataFactory.Zaposleni.azurirajTemu(z, z.jmb);
            }
            else if (cbTema.SelectedIndex == 3) //plava
            {
                promjeniTemu(Color.LightSteelBlue, Color.SaddleBrown, Color.LightGray, "Lucida Handwriting", FontStyle.Bold, 9);
                z.tema = "Plava";
                tema = "Plava";
                Common.DataFactory.Zaposleni.azurirajTemu(z, z.jmb);
            }
            else //standardna
            {
                promjeniTemu(Color.WhiteSmoke, Color.Black, Color.Gainsboro, "Microsoft Sans Serif", FontStyle.Regular, 9);
                z.tema = "Standardna";
                tema = "Standardna";
                Common.DataFactory.Zaposleni.azurirajTemu(z, z.jmb);
            }
        }

        private void promjeniTemu(Color backColorForm, Color foreColor, Color backColor, String font, FontStyle fs, float velicinaFonta)
        {
            this.BackColor = backColorForm;
            this.ForeColor = foreColor;
            btnOdjaviSe.BackColor = backColor;
            btnOdjaviSe.ForeColor = foreColor;
            cbTema.BackColor = backColor;
            cbTema.ForeColor = foreColor;
            btnPregledVoznogParka.BackColor = backColor;
            btnPregledVoznogParka.ForeColor = foreColor;
            btnAzurirajSvojProfil.BackColor = backColor;
            btnAzurirajSvojProfil.ForeColor = foreColor;

            lbTema.Font = new Font(font, velicinaFonta, fs);
            btnOdjaviSe.Font = new Font(font, velicinaFonta, fs);
            cbTema.Font = new Font(font, velicinaFonta, fs);
            btnPregledVoznogParka.Font = new Font(font, velicinaFonta, fs);
            btnAzurirajSvojProfil.Font = new Font(font, velicinaFonta, fs);

        }
    }
}
