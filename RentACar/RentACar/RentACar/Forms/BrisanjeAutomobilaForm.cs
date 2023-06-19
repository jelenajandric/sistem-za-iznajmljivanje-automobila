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
    public partial class BrisanjeAutomobilaForm : Form
    {
        int id;
        string jezik = "";
        string tema = "";
        public BrisanjeAutomobilaForm() : this(0, "", "")
        {
        }

        public BrisanjeAutomobilaForm(int id, string jezik, string tema)
        {
            InitializeComponent();
            this.id = id;
            this.jezik = jezik;
            this.tema = tema;
        }

        private void btnDa_Click(object sender, EventArgs e)
        {
            Automobil a = Common.DataFactory.Automobili.getOne(id);
            if (a.zaduzen == 0)
            {
                Common.DataFactory.Iznajmljivanja.izbrisiIznajmljivanja(id);
                Common.DataFactory.Automobili.obrisiAutomobil(id);
                this.Close();
            } else
            {
                string poruka = "";
                if(jezik.Equals("Srpski"))
                {
                    poruka = "Ne možete izbrisati auto koje je trenutno iznajmljeno.";
                } else
                {
                    poruka = "You cannot delete a car that is currently rented.";
                }
                new ObavjestenjeForm(poruka, jezik, tema).ShowDialog();
            }
        }

        private void btnNe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BrisanjeAutomobilaForm_Load(object sender, EventArgs e)
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
            btnDa.BackColor = backColor;
            btnDa.ForeColor = foreColor;
            btnNe.BackColor = backColor;
            btnNe.ForeColor = foreColor;
 
            label1.Font = new Font(font, velicinaFonta, fs);
            btnDa.Font = new Font(font, velicinaFonta, fs);
            btnNe.Font = new Font(font, velicinaFonta, fs);
        }

        private void ChangeLanguage(string lang)
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(lang);
            ComponentResourceManager resources = new ComponentResourceManager(typeof(BrisanjeAutomobilaForm));
            resources.ApplyResources(this, "$this");
            applyResources(resources, this.Controls);
            ApplyResourceToControl(this, new ComponentResourceManager(typeof(BrisanjeAutomobilaForm)), new CultureInfo(lang));

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
