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
    public partial class AdminsInitialForm : Form
    {

        Administrator admin;
        string jezik;
        string tema;
        public AdminsInitialForm() : this(null, "")
        {
            
        }
        public AdminsInitialForm(Administrator a, string jezik)
        {
            InitializeComponent();
            this.admin = a;
            this.jezik = jezik;
            this.tema = a.tema;

            if (a.tema == "Standardna" || a.tema == "Standard")
            {
                cbTema.SelectedIndex = 0;
            }
            else if(a.tema == "Tamna" || a.tema == "Dark")
            {
                cbTema.SelectedIndex = 1;
            } 
            else if (a.tema == "Zelena" || a.tema == "Green")
            {
                cbTema.SelectedIndex = 2;
            } 
            else
            {
                cbTema.SelectedIndex = 3;
            }

        }


        private void btnPrikazVoznogParka_Click(object sender, EventArgs e)
        {
            new PrikazAutomobilaZaAdminaForm(admin, jezik, tema).ShowDialog();
            
        }

        private void btnDodajNoviAutomobil_Click(object sender, EventArgs e)
        {
            new DodavanjeNovogAutomobilaForm(admin, jezik, tema).ShowDialog();
            
        }

        private void btnPrikazZaposlenih_Click(object sender, EventArgs e)
        {
            new PrikazZaposlenihForm(jezik, tema).ShowDialog();
        }

        private void btnDodajNovogZaposlenog_Click(object sender, EventArgs e)
        {
            new DodavanjeZaposlenogForm(jezik, tema).ShowDialog();
        }

        private void btnAzurirajSvojePodatke_Click(object sender, EventArgs e)
        {
            
            new AzuriranjePodatakaAdminaForm(admin, jezik, tema).ShowDialog();
        }

        private void btnPregledSvihIznajmljivanja_Click(object sender, EventArgs e)
        {
            new PredgledSvihIznajmljivanjaForm(jezik, tema).ShowDialog();
        }

        
        private void btnOdjaviSe_Click(object sender, EventArgs e)
        {
            this.Close();
            admin = null;
        }

        private void AdminsInitialForm_Load(object sender, EventArgs e)
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
            ComponentResourceManager resources = new ComponentResourceManager(typeof(AdminsInitialForm));
            resources.ApplyResources(this, "$this");
            applyResources(resources, this.Controls);
            ApplyResourceToControl(this, new ComponentResourceManager(typeof(AdminsInitialForm)), new CultureInfo(lang));

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
                admin.tema = "Tamna";
                tema = "Tamna";
                Common.DataFactory.Administratori.azurirajTemu(admin,admin.jmb);
            }
            else if (cbTema.SelectedIndex == 2) //zelena
            {
                promjeniTemu(Color.DarkSeaGreen, Color.Maroon, Color.Azure, "Reem Kufi", FontStyle.Regular, 9);
                admin.tema = "Zelena";
                tema = "Zelena";
                Common.DataFactory.Administratori.azurirajTemu(admin, admin.jmb);
            }
            else if (cbTema.SelectedIndex == 3) //plava
            {
                promjeniTemu(Color.LightSteelBlue, Color.SaddleBrown, Color.LightGray, "Lucida Handwriting", FontStyle.Bold, 9);
                admin.tema = "Plava";
                tema = "Plava";
                Common.DataFactory.Administratori.azurirajTemu(admin, admin.jmb);
            }
            else //standardna
            {
                promjeniTemu(Color.WhiteSmoke, Color.Black, Color.Gainsboro, "Microsoft Sans Serif", FontStyle.Regular, 9);
                admin.tema = "Standardna";
                tema = "Standardna";
                Common.DataFactory.Administratori.azurirajTemu(admin, admin.jmb);
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
            btnPrikazVoznogParka.BackColor = backColor;
            btnPrikazVoznogParka.ForeColor = foreColor;
            btnDodajNoviAutomobil.BackColor = backColor;
            btnDodajNoviAutomobil.ForeColor = foreColor;
            btnPrikazZaposlenih.BackColor = backColor;
            btnPrikazZaposlenih.ForeColor = foreColor;
            btnDodajNovogZaposlenog.BackColor = backColor;
            btnDodajNovogZaposlenog.ForeColor = foreColor;
            btnAzurirajSvojePodatke.BackColor = backColor;
            btnAzurirajSvojePodatke.ForeColor = foreColor;
            btnPregledSvihIznajmljivanja.BackColor = backColor;
            btnPregledSvihIznajmljivanja.ForeColor = foreColor;

            lbTema.Font = new Font(font, velicinaFonta, fs);
            btnOdjaviSe.Font = new Font(font, velicinaFonta, fs);
            cbTema.Font = new Font(font, velicinaFonta, fs);
            btnPrikazVoznogParka.Font = new Font(font, velicinaFonta, fs);
            btnDodajNoviAutomobil.Font = new Font(font, velicinaFonta, fs);
            btnPrikazZaposlenih.Font = new Font(font, velicinaFonta, fs);
            btnDodajNovogZaposlenog.Font = new Font(font, velicinaFonta, fs);
            btnAzurirajSvojePodatke.Font = new Font(font, velicinaFonta, fs);
            btnPregledSvihIznajmljivanja.Font = new Font(font, velicinaFonta, fs);
        }
    }
}
