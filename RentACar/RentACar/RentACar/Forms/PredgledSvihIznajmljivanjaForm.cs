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
    public partial class PredgledSvihIznajmljivanjaForm : Form
    {
        string jezik;
        string tema;
        public PredgledSvihIznajmljivanjaForm() :this("", "")
        {
        }
        public PredgledSvihIznajmljivanjaForm(string jezik,string tema)
        {
            InitializeComponent();
            this.jezik = jezik;
            this.tema = tema;
            FillGrid();
            SetToolStripMenuOptionsAvailability();

        }

        private void FillGrid()
        {
            dataGridView1.Rows.Clear();
            foreach (var p in Common.DataFactory.Iznajmljivanja.getIznajmljivanja(tbPretraga.Text)) 
            {
                DataGridViewRow row = new DataGridViewRow()
                {
                    Tag = p
                };
                DateTime d1 = DateTime.MinValue;
                DateTime d2 = (DateTime) p.datumRazduzenja;
                int res = DateTime.Compare(d1, d2);
                if (res ==  0)
                { 
                    p.Zaposleni_jmb_razduzuje = "";
                    p.Zaposleni_KorisnickoIme_razduzuje = "";
                    p.datumRazduzenja = null;
                    if (!(checkBox1.Checked))
                        continue;
                }
                row.CreateCells(dataGridView1, p.idIznajmljivanje, p.Automobil_idAutomobil, p.Automobil_naziv, p.Iznajmljivac_ime + " " +p.Iznajmljivac_prezime, p.Iznajmljivac_jmb, p.Zaposleni_korisnickoIme_zaduzuje, p.Zaposleni_jmb_zaduzuje, p.Zaposleni_KorisnickoIme_razduzuje , p.Zaposleni_jmb_razduzuje, p.datumZaduzenja, p.datumRazduzenja);
                dataGridView1.Rows.Add(row);
            }
        }

        private void tbPretraga_TextChanged(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            FillGrid();
        }
        private void SetToolStripMenuOptionsAvailability()
        {
            bool b = (dataGridView1.SelectedRows.Count == 1);
            toolStrip1.Enabled =  b;
            
        }
        private void tsPregledIznajmljivaca_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                string jmb = (string)dataGridView1.SelectedRows[0].Cells[4].Value;
                Iznajmljivac a = Common.DataFactory.Iznajmljivaci.getIznajmljivac(jmb);
                new PrikazIznajmljivaca(a, jezik, tema).ShowDialog();
            }
            
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            SetToolStripMenuOptionsAvailability();
        }

        private void PredgledSvihIznajmljivanjaForm_Load(object sender, EventArgs e)
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
            if (foreColor == Color.White)
            {
                this.ForeColor = Color.Black;
                dataGridView1.ForeColor = Color.Black;
                dataGridView1.BackColor = backColor;
            }
            else
            {
                this.ForeColor = foreColor;
                dataGridView1.BackColor = backColor;
                dataGridView1.ForeColor = foreColor;
            }
            tbPretraga.BackColor = backColor;
            tbPretraga.ForeColor = foreColor;
            
            toolStrip1.BackColor = backColor;
            toolStrip1.ForeColor = foreColor;
            checkBox1.BackColor = backColor;
            checkBox1.ForeColor = foreColor;
            label1.ForeColor = foreColor;

            label1.Font = new Font(font, velicinaFonta, fs);
            tbPretraga.Font = new Font(font, velicinaFonta, fs);
            dataGridView1.Font = new Font(font, velicinaFonta, fs);
            toolStrip1.Font = new Font(font, velicinaFonta, fs);
            checkBox1.Font = new Font(font, velicinaFonta, fs);

        }

        private void ChangeLanguage(string lang)
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(lang);
            ComponentResourceManager resources = new ComponentResourceManager(typeof(PredgledSvihIznajmljivanjaForm));
            resources.ApplyResources(this, "$this");
            applyResources(resources, this.Controls);
            ApplyResourceToControl(this, new ComponentResourceManager(typeof(PredgledSvihIznajmljivanjaForm)), new CultureInfo(lang));

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
