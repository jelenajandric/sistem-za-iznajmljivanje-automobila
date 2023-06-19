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
    public partial class PrikazAutomobilaForm : Form //uradi da se moze izabrati trenutni iznajmljivac i da se blokiaju polja zaduzi razduzi ako ne mogu
    {
        Zaposleni zap;
        string jezik;
        string tema;
        public PrikazAutomobilaForm() : this(null, "", "")
        {
        }

        public PrikazAutomobilaForm(Zaposleni z, string jezik, string tema)
        {
            InitializeComponent();
            this.zap = z;
            this.jezik = jezik;
            this.tema = tema;
            FillGrid();
            SetContextMenuOptionsAvailability();
            
        }

        void FillGrid()
        {
            dataGridView1.Rows.Clear();
            foreach (var p in Common.DataFactory.Automobili.getAutomobile(tbPretraga.Text))
            {
                DataGridViewRow row = new DataGridViewRow()
                {
                    Tag = p

                };
                string zad = "NE";
                if (p.zaduzen == 0)
                {
                    if (jezik == "Srpski")
                    {
                        zad = "NE";
                    }
                    else
                    {
                        zad = "NO";
                    }

                }
                else
                {
                    if (jezik == "Srpski")
                    {
                        zad = "DA";
                    }
                    else
                    {
                        zad = "YES";
                    }
                }

                if (checkBoxIznajmljeniAutomobili.Checked && (!checkBoxSlobodniAutomobili.Checked) && p.zaduzen==0)
                {
                    continue;
                }
                else if(checkBoxSlobodniAutomobili.Checked && (!checkBoxIznajmljeniAutomobili.Checked) && p.zaduzen==1)
                {
                    continue;
                }
                row.CreateCells(dataGridView1, p.idAutomobil, p.naziv, p.brojSjedista, p.godinaProizvodnje, p.gorivo, p.transmisija, p.cijena, zad);
                dataGridView1.Rows.Add(row);
            }
        }

        private void SetContextMenuOptionsAvailability()
        {
            bool b = (dataGridView1.SelectedRows.Count == 1);
            ToolStripMenuItemDetalji.Enabled = ToolStripMenuItemZaduzi.Enabled = ToolStripMenuItemRazduzi.Enabled = b;
            tslDetalji.Enabled = tslRazduzi.Enabled = tslZaduzi.Enabled = b;
            if (b)
            {
                int id = (Int32)dataGridView1.SelectedRows[0].Cells[0].Value;
                Automobil a = Common.DataFactory.Automobili.getOne(id);
                if (a.zaduzen == 1)
                {
                    ToolStripMenuItemZaduzi.Enabled = false;
                    tslZaduzi.Enabled = false;
                }
                else if (a.zaduzen == 0)
                {
                    ToolStripMenuItemRazduzi.Enabled = false;
                    tslRazduzi.Enabled = false;
                }
            }
        }

        private void PrikazAutomobilaForm_Load(object sender, EventArgs e)
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
            toolStrip1.BackColor = backColor;
            toolStrip1.ForeColor = foreColor;
            contextMenuStrip1.BackColor = backColor;
            contextMenuStrip1.ForeColor = foreColor;
            checkBoxIznajmljeniAutomobili.BackColor = backColor;
            checkBoxIznajmljeniAutomobili.ForeColor = foreColor;
            checkBoxSlobodniAutomobili.BackColor = backColor;
            checkBoxSlobodniAutomobili.ForeColor = foreColor;
            lbPretraga.ForeColor = foreColor;

            lbPretraga.Font = new Font(font, velicinaFonta, fs);
            tbPretraga.Font = new Font(font, velicinaFonta, fs);
            dataGridView1.Font = new Font(font, velicinaFonta, fs);
            toolStrip1.Font = new Font(font, velicinaFonta, fs);
            contextMenuStrip1.Font = new Font(font, velicinaFonta, fs);
            checkBoxSlobodniAutomobili.Font = new Font(font, velicinaFonta, fs);
            checkBoxIznajmljeniAutomobili.Font = new Font(font, velicinaFonta, fs);
        }

        private void detaljiOAutomobilu()
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int id = (Int32)dataGridView1.SelectedRows[0].Cells[0].Value;
                Automobil a = Common.DataFactory.Automobili.getOne(id);
                new DetaljiForm(a, jezik, tema).ShowDialog();
            }
        }

        private void tslDetalji_Click(object sender, EventArgs e)
        {
            detaljiOAutomobilu();
        }

        private void tslZaduzi_Click(object sender, EventArgs e)
        {
            zaduzivanje();
        }

        private void tslRazduzi_Click(object sender, EventArgs e)
        {
            razduzivanje();
        }

        private void checkBoxSlobodniAutomobili_CheckedChanged(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void checkBoxIznajmljeniAutomobili_CheckedChanged(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void tbPretraga_TextChanged(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void ToolStripMenuItemDetalji_Click(object sender, EventArgs e)
        {
            detaljiOAutomobilu();
        }

        private void ToolStripMenuItemZaduzi_Click(object sender, EventArgs e)
        {
            zaduzivanje();
        }

        private void ToolStripMenuItemRazduzi_Click(object sender, EventArgs e)
        {
            razduzivanje();
        }

        private void zaduzivanje()
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int id = (Int32)dataGridView1.SelectedRows[0].Cells[0].Value;
                Automobil a = Common.DataFactory.Automobili.getOne(id);
                new ZaduzivanjeForm(a, zap, jezik, tema).ShowDialog();
            }
            FillGrid();
            SetContextMenuOptionsAvailability();
        }

        private void razduzivanje()
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int id = (Int32)dataGridView1.SelectedRows[0].Cells[0].Value;
                Automobil a = Common.DataFactory.Automobili.getOne(id);
                new RazduzivanjeForm(a, zap, jezik, tema).ShowDialog();
            }
            FillGrid();
            SetContextMenuOptionsAvailability();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            SetContextMenuOptionsAvailability();
        }

        private void tslPrikazSvihIznajmljivanja_Click(object sender, EventArgs e)
        {
            new PredgledSvihIznajmljivanjaForm(jezik, tema).ShowDialog();
        }
        private void ChangeLanguage(string lang)
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(lang);
            ComponentResourceManager resources = new ComponentResourceManager(typeof(PrikazAutomobilaForm));
            resources.ApplyResources(this, "$this");
            applyResources(resources, this.Controls);
            ApplyResourceToControl(this, new ComponentResourceManager(typeof(PrikazAutomobilaForm)), new CultureInfo(lang));

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

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
