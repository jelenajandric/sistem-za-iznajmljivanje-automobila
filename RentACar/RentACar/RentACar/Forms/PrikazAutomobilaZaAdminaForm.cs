﻿using RentACar.Util;
using System;
using RentACar.Data.Model;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Globalization;

namespace RentACar.Forms
{
    public partial class PrikazAutomobilaZaAdminaForm : Form
    {
        Administrator admin;
        string jezik;
        string tema;
        public PrikazAutomobilaZaAdminaForm() : this(null, "", "")
        {
            
        }
         public PrikazAutomobilaZaAdminaForm(Administrator a, string jezik, string tema)
        {
            InitializeComponent();
            admin = a;
            this.jezik = jezik;
            this.tema = tema;
            FillGrid();
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
                    if(jezik == "Srpski")
                    {
                        zad = "NE";
                    } else
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
                row.CreateCells(dataGridView1,p.idAutomobil ,p.naziv, p.brojSjedista, p.godinaProizvodnje, p.gorivo, p.transmisija, p.cijena, zad);
                dataGridView1.Rows.Add(row);
            }
        }

        private void tbPretraga_TextChanged(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void SetContextMenuOptionsAvailability()
        {
            bool b = (dataGridView1.SelectedRows.Count == 1);
            detaljiToolStripMenuItem.Enabled = urediToolStripMenuItem.Enabled = obrišiToolStripMenuItem.Enabled = b;
            tslDetalji.Enabled = tslUredi.Enabled = tslObrisi.Enabled = b;
        }

        private void PrikazAutomobilaZaAdminaForm_Load(object sender, EventArgs e)
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
            label1.ForeColor = foreColor;
            

            label1.Font = new Font(font, velicinaFonta, fs);
            tbPretraga.Font = new Font(font, velicinaFonta, fs);
            dataGridView1.Font = new Font(font, velicinaFonta, fs);
            toolStrip1.Font = new Font(font, velicinaFonta, fs);
            contextMenuStrip1.Font = new Font(font, velicinaFonta, fs);

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            SetContextMenuOptionsAvailability();

        }
        private void detaljiOAutomobilu()
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int id = (Int32) dataGridView1.SelectedRows[0].Cells[0].Value;
                Debug.WriteLine("id: " + id);
                
                Automobil a = Common.DataFactory.Automobili.getOne(id);
                new DetaljiForm(a, jezik, tema).ShowDialog();
            }
        }

        private void obrisi()
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int id = (Int32)dataGridView1.SelectedRows[0].Cells[0].Value;
                Debug.WriteLine("id: " + id);
                new BrisanjeAutomobilaForm(id, jezik, tema).ShowDialog();
                FillGrid();
                SetContextMenuOptionsAvailability();
            }
        }

        private void uredi()
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int id = (Int32)dataGridView1.SelectedRows[0].Cells[0].Value;
                Debug.WriteLine("id: " + id);
                new AzuriranjeAutomobilaForm(admin, id,jezik, tema).ShowDialog();
                FillGrid();
                SetContextMenuOptionsAvailability();
            }
        }

        private void tslDodajNoviAutomobil_Click(object sender, EventArgs e)
        {
            new DodavanjeNovogAutomobilaForm(admin, jezik, tema).ShowDialog();
            SetContextMenuOptionsAvailability();
            FillGrid();
        }

        private void tslDetalji_Click(object sender, EventArgs e)
        {
            detaljiOAutomobilu();
        }

        private void tslUredi_Click(object sender, EventArgs e)
        {
            uredi();
        }

        private void tslObrisi_Click(object sender, EventArgs e)
        {
            obrisi();
        }

        private void detaljiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            detaljiOAutomobilu();
        }

        private void urediToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uredi();
        }

        private void obrišiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            obrisi();
        }

        private void dodajnoviAutomobilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new DodavanjeNovogAutomobilaForm(admin, jezik, tema).ShowDialog();
            SetContextMenuOptionsAvailability();
            FillGrid();
        }

        private void ChangeLanguage(string lang)
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(lang);
            ComponentResourceManager resources = new ComponentResourceManager(typeof(PrikazAutomobilaZaAdminaForm));
            resources.ApplyResources(this, "$this");
            applyResources(resources, this.Controls);
            ApplyResourceToControl(this, new ComponentResourceManager(typeof(PrikazAutomobilaZaAdminaForm)), new CultureInfo(lang));

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

        private void dodajnoviAutomobilToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            new DodavanjeNovogAutomobilaForm(admin, jezik, tema).ShowDialog();
            SetContextMenuOptionsAvailability();
            FillGrid();
        }
    }
}
