
namespace RentACar.Forms
{
    partial class PrikazAutomobilaZaAdminaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrikazAutomobilaZaAdminaForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNazivAutomobila = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBrojSjedista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGodiste = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGorivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTransmisija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colZaduzen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbPretraga = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tslDetalji = new System.Windows.Forms.ToolStripLabel();
            this.tslUredi = new System.Windows.Forms.ToolStripLabel();
            this.tslObrisi = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tslDodajNoviAutomobil = new System.Windows.Forms.ToolStripLabel();
            this.mySqlConnection1 = new MySql.Data.MySqlClient.MySqlConnection();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.detaljiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.urediToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obrišiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajnoviAutomobilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colNazivAutomobila,
            this.colBrojSjedista,
            this.colGodiste,
            this.colGorivo,
            this.colTransmisija,
            this.colCijena,
            this.colZaduzen});
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // colID
            // 
            resources.ApplyResources(this.colID, "colID");
            this.colID.Name = "colID";
            // 
            // colNazivAutomobila
            // 
            resources.ApplyResources(this.colNazivAutomobila, "colNazivAutomobila");
            this.colNazivAutomobila.Name = "colNazivAutomobila";
            // 
            // colBrojSjedista
            // 
            resources.ApplyResources(this.colBrojSjedista, "colBrojSjedista");
            this.colBrojSjedista.Name = "colBrojSjedista";
            // 
            // colGodiste
            // 
            resources.ApplyResources(this.colGodiste, "colGodiste");
            this.colGodiste.Name = "colGodiste";
            // 
            // colGorivo
            // 
            resources.ApplyResources(this.colGorivo, "colGorivo");
            this.colGorivo.Name = "colGorivo";
            // 
            // colTransmisija
            // 
            resources.ApplyResources(this.colTransmisija, "colTransmisija");
            this.colTransmisija.Name = "colTransmisija";
            // 
            // colCijena
            // 
            resources.ApplyResources(this.colCijena, "colCijena");
            this.colCijena.Name = "colCijena";
            // 
            // colZaduzen
            // 
            resources.ApplyResources(this.colZaduzen, "colZaduzen");
            this.colZaduzen.Name = "colZaduzen";
            // 
            // tbPretraga
            // 
            resources.ApplyResources(this.tbPretraga, "tbPretraga");
            this.tbPretraga.Name = "tbPretraga";
            this.tbPretraga.TextChanged += new System.EventHandler(this.tbPretraga_TextChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // toolStrip1
            // 
            resources.ApplyResources(this.toolStrip1, "toolStrip1");
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslDetalji,
            this.tslUredi,
            this.tslObrisi,
            this.toolStripSeparator1,
            this.tslDodajNoviAutomobil});
            this.toolStrip1.Name = "toolStrip1";
            // 
            // tslDetalji
            // 
            resources.ApplyResources(this.tslDetalji, "tslDetalji");
            this.tslDetalji.Name = "tslDetalji";
            this.tslDetalji.Click += new System.EventHandler(this.tslDetalji_Click);
            // 
            // tslUredi
            // 
            resources.ApplyResources(this.tslUredi, "tslUredi");
            this.tslUredi.Name = "tslUredi";
            this.tslUredi.Click += new System.EventHandler(this.tslUredi_Click);
            // 
            // tslObrisi
            // 
            resources.ApplyResources(this.tslObrisi, "tslObrisi");
            this.tslObrisi.Name = "tslObrisi";
            this.tslObrisi.Click += new System.EventHandler(this.tslObrisi_Click);
            // 
            // toolStripSeparator1
            // 
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            // 
            // tslDodajNoviAutomobil
            // 
            resources.ApplyResources(this.tslDodajNoviAutomobil, "tslDodajNoviAutomobil");
            this.tslDodajNoviAutomobil.Name = "tslDodajNoviAutomobil";
            this.tslDodajNoviAutomobil.Click += new System.EventHandler(this.tslDodajNoviAutomobil_Click);
            // 
            // contextMenuStrip1
            // 
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.detaljiToolStripMenuItem,
            this.urediToolStripMenuItem,
            this.obrišiToolStripMenuItem,
            this.dodajnoviAutomobilToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            // 
            // detaljiToolStripMenuItem
            // 
            resources.ApplyResources(this.detaljiToolStripMenuItem, "detaljiToolStripMenuItem");
            this.detaljiToolStripMenuItem.Image = global::RentACar.Properties.Resources._132334_info_icon;
            this.detaljiToolStripMenuItem.Name = "detaljiToolStripMenuItem";
            this.detaljiToolStripMenuItem.Click += new System.EventHandler(this.detaljiToolStripMenuItem_Click);
            // 
            // urediToolStripMenuItem
            // 
            resources.ApplyResources(this.urediToolStripMenuItem, "urediToolStripMenuItem");
            this.urediToolStripMenuItem.Image = global::RentACar.Properties.Resources._132232_edit_icon;
            this.urediToolStripMenuItem.Name = "urediToolStripMenuItem";
            this.urediToolStripMenuItem.Click += new System.EventHandler(this.urediToolStripMenuItem_Click);
            // 
            // obrišiToolStripMenuItem
            // 
            resources.ApplyResources(this.obrišiToolStripMenuItem, "obrišiToolStripMenuItem");
            this.obrišiToolStripMenuItem.Image = global::RentACar.Properties.Resources._132192_delete_icon;
            this.obrišiToolStripMenuItem.Name = "obrišiToolStripMenuItem";
            this.obrišiToolStripMenuItem.Click += new System.EventHandler(this.obrišiToolStripMenuItem_Click);
            // 
            // dodajnoviAutomobilToolStripMenuItem
            // 
            resources.ApplyResources(this.dodajnoviAutomobilToolStripMenuItem, "dodajnoviAutomobilToolStripMenuItem");
            this.dodajnoviAutomobilToolStripMenuItem.Image = global::RentACar.Properties.Resources._132335_add_icon;
            this.dodajnoviAutomobilToolStripMenuItem.Name = "dodajnoviAutomobilToolStripMenuItem";
            this.dodajnoviAutomobilToolStripMenuItem.Click += new System.EventHandler(this.dodajnoviAutomobilToolStripMenuItem_Click_1);
            // 
            // PrikazAutomobilaZaAdminaForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPretraga);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.Name = "PrikazAutomobilaZaAdminaForm";
            this.Load += new System.EventHandler(this.PrikazAutomobilaZaAdminaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tbPretraga;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel tslDetalji;
        private System.Windows.Forms.ToolStripLabel tslUredi;
        private System.Windows.Forms.ToolStripLabel tslObrisi;
        private MySql.Data.MySqlClient.MySqlConnection mySqlConnection1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem detaljiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem urediToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obrišiToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel tslDodajNoviAutomobil;
        private System.Windows.Forms.ToolStripMenuItem dodajnoviAutomobilToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNazivAutomobila;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBrojSjedista;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGodiste;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGorivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTransmisija;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn colZaduzen;
    }
}