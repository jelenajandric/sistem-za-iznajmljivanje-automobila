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
    public partial class PrikazZaposlenihForm : Form
    {
        string jezik;
        string tema;
        public PrikazZaposlenihForm() : this("", "")
        {
            
        }

        public PrikazZaposlenihForm(string jezik, string tema)
        {
            InitializeComponent();
            this.jezik = jezik;
            this.tema = tema;
            FillGrid();
            
        }
        void FillGrid()
        {
            dataGridView1.Rows.Clear();
            foreach (var p in Common.DataFactory.Zaposleni.getZaposlene(tbPretraga.Text))
            {
                DataGridViewRow row = new DataGridViewRow()
                {
                    Tag = p
                };
                string temp = "";
                if(p.onemogucen==0)
                {
                    if (jezik == "Srpski")
                    {
                        temp = "NE";
                    }
                    else
                    {
                        temp = "NO";
                    }
                } else
                {
                    if (jezik == "Srpski")
                    {
                        temp = "DA";
                    }
                    else
                    {
                        temp = "YES";
                    }
                }
                row.CreateCells(dataGridView1, p.prezime, p.ime, p.jmb, p.brojTelefona, p.email, p.korisnickoIme, temp);
                dataGridView1.Rows.Add(row);
               
            }
        }

        private void SetContextMenuOptionsAvailability()
        {
            bool b = (dataGridView1.SelectedRows.Count == 1);
            if (b)
            {
                string jmb = (String)dataGridView1.SelectedRows[0].Cells[2].Value;
                Zaposleni z = Common.DataFactory.Zaposleni.getOne(jmb);
                if(z.onemogucen==0)
                {
                    onemoguciToolStripMenuItem.Enabled =true;
                    omoguciNalogZaposlenomToolStripMenuItem.Enabled = false;
                } 
                else
                {
                    onemoguciToolStripMenuItem.Enabled = false;
                    omoguciNalogZaposlenomToolStripMenuItem.Enabled = true;
                }
                
            } else
            {
                onemoguciToolStripMenuItem.Enabled = omoguciNalogZaposlenomToolStripMenuItem.Enabled = false;
            }
            
            
           
        }

        private void PrikazZaposlenihForm_Load(object sender, EventArgs e)
        {
            SetContextMenuOptionsAvailability();
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
            
            contextMenuStrip1.BackColor = backColor;
            contextMenuStrip1.ForeColor = foreColor;
            label1.ForeColor = foreColor;

            label1.Font = new Font(font, velicinaFonta, fs);
            tbPretraga.Font = new Font(font, velicinaFonta, fs);
            dataGridView1.Font = new Font(font, velicinaFonta, fs);
            contextMenuStrip1.Font = new Font(font, velicinaFonta, fs);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            SetContextMenuOptionsAvailability();
        }

        private void obrisiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                string jmb = (String)dataGridView1.SelectedRows[0].Cells[2].Value;
                Common.DataFactory.Zaposleni.onemuguciNalog(jmb, 1);
                FillGrid();
                SetContextMenuOptionsAvailability();
            }
        }

        private void dodajnovogZaposlenogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new DodavanjeZaposlenogForm(jezik, tema).ShowDialog();
            FillGrid();
            SetContextMenuOptionsAvailability();
        }

        private void tbPretraga_TextChanged_1(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void ChangeLanguage(string lang)
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(lang);
            ComponentResourceManager resources = new ComponentResourceManager(typeof(PrikazZaposlenihForm));
            resources.ApplyResources(this, "$this");
            applyResources(resources, this.Controls);
            ApplyResourceToControl(this, new ComponentResourceManager(typeof(PrikazZaposlenihForm)), new CultureInfo(lang));

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

        private void omoguciNalogZaposlenomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                string jmb = (String)dataGridView1.SelectedRows[0].Cells[2].Value;
                Common.DataFactory.Zaposleni.onemuguciNalog(jmb, 0);
                FillGrid();
                SetContextMenuOptionsAvailability();
            }
        }
    }
}
