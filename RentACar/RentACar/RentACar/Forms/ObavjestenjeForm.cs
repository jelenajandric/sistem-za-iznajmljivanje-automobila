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
    public partial class ObavjestenjeForm : Form
    {
        string labela;
        string tema;
        string jezik;
        public ObavjestenjeForm() : this("", "", "")
        {
            
        }

        public ObavjestenjeForm(string labela, string jezik, string tema)
        {
            InitializeComponent();
            this.labela = labela;
            this.jezik = jezik;
            this.tema = tema;

        }

        private void ObavjestenjeForm_Load(object sender, EventArgs e)
        {
            
            if (jezik == "Srpski")
            {
                ChangeLanguage("sr-Latn-BA");
            }
            else
            {
                ChangeLanguage("en");
            }
            label1.Text = labela;
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
            button1.BackColor = backColor;
            button1.ForeColor = foreColor;

            label1.Font = new Font(font, velicinaFonta, fs);
            button1.Font = new Font(font, velicinaFonta, fs);

        }

        private void ChangeLanguage(string lang)
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(lang);
            ComponentResourceManager resources = new ComponentResourceManager(typeof(ObavjestenjeForm));
            resources.ApplyResources(this, "$this");
            applyResources(resources, this.Controls);
            ApplyResourceToControl(this, new ComponentResourceManager(typeof(ObavjestenjeForm)), new CultureInfo(lang));

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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
