
namespace RentACar.Forms
{
    partial class PrikazAutomobilaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrikazAutomobilaForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colIdAutomobil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNaziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBrojSjedista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGodiste = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGorivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTransmisija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colZaduzen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbPretraga = new System.Windows.Forms.Label();
            this.tbPretraga = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItemDetalji = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemZaduzi = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemRazduzi = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tslDetalji = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tslZaduzi = new System.Windows.Forms.ToolStripLabel();
            this.tslRazduzi = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tslPrikazSvihIznajmljivanja = new System.Windows.Forms.ToolStripLabel();
            this.mySqlConnection1 = new MySql.Data.MySqlClient.MySqlConnection();
            this.checkBoxSlobodniAutomobili = new System.Windows.Forms.CheckBox();
            this.checkBoxIznajmljeniAutomobili = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdAutomobil,
            this.colNaziv,
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
            // colIdAutomobil
            // 
            resources.ApplyResources(this.colIdAutomobil, "colIdAutomobil");
            this.colIdAutomobil.Name = "colIdAutomobil";
            // 
            // colNaziv
            // 
            resources.ApplyResources(this.colNaziv, "colNaziv");
            this.colNaziv.Name = "colNaziv";
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
            // lbPretraga
            // 
            resources.ApplyResources(this.lbPretraga, "lbPretraga");
            this.lbPretraga.Name = "lbPretraga";
            // 
            // tbPretraga
            // 
            resources.ApplyResources(this.tbPretraga, "tbPretraga");
            this.tbPretraga.Name = "tbPretraga";
            this.tbPretraga.TextChanged += new System.EventHandler(this.tbPretraga_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemDetalji,
            this.ToolStripMenuItemZaduzi,
            this.ToolStripMenuItemRazduzi});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // ToolStripMenuItemDetalji
            // 
            this.ToolStripMenuItemDetalji.Image = global::RentACar.Properties.Resources._132334_info_icon;
            this.ToolStripMenuItemDetalji.Name = "ToolStripMenuItemDetalji";
            resources.ApplyResources(this.ToolStripMenuItemDetalji, "ToolStripMenuItemDetalji");
            this.ToolStripMenuItemDetalji.Click += new System.EventHandler(this.ToolStripMenuItemDetalji_Click);
            // 
            // ToolStripMenuItemZaduzi
            // 
            this.ToolStripMenuItemZaduzi.Image = global::RentACar.Properties.Resources._132306_properties_icon;
            this.ToolStripMenuItemZaduzi.Name = "ToolStripMenuItemZaduzi";
            resources.ApplyResources(this.ToolStripMenuItemZaduzi, "ToolStripMenuItemZaduzi");
            this.ToolStripMenuItemZaduzi.Click += new System.EventHandler(this.ToolStripMenuItemZaduzi_Click);
            // 
            // ToolStripMenuItemRazduzi
            // 
            this.ToolStripMenuItemRazduzi.Image = global::RentACar.Properties.Resources._132206_date_icon;
            this.ToolStripMenuItemRazduzi.Name = "ToolStripMenuItemRazduzi";
            resources.ApplyResources(this.ToolStripMenuItemRazduzi, "ToolStripMenuItemRazduzi");
            this.ToolStripMenuItemRazduzi.Click += new System.EventHandler(this.ToolStripMenuItemRazduzi_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslDetalji,
            this.toolStripSeparator1,
            this.tslZaduzi,
            this.tslRazduzi,
            this.toolStripSeparator2,
            this.tslPrikazSvihIznajmljivanja});
            resources.ApplyResources(this.toolStrip1, "toolStrip1");
            this.toolStrip1.Name = "toolStrip1";
            // 
            // tslDetalji
            // 
            this.tslDetalji.Name = "tslDetalji";
            resources.ApplyResources(this.tslDetalji, "tslDetalji");
            this.tslDetalji.Click += new System.EventHandler(this.tslDetalji_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // tslZaduzi
            // 
            this.tslZaduzi.Name = "tslZaduzi";
            resources.ApplyResources(this.tslZaduzi, "tslZaduzi");
            this.tslZaduzi.Click += new System.EventHandler(this.tslZaduzi_Click);
            // 
            // tslRazduzi
            // 
            this.tslRazduzi.Name = "tslRazduzi";
            resources.ApplyResources(this.tslRazduzi, "tslRazduzi");
            this.tslRazduzi.Click += new System.EventHandler(this.tslRazduzi_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // tslPrikazSvihIznajmljivanja
            // 
            this.tslPrikazSvihIznajmljivanja.Name = "tslPrikazSvihIznajmljivanja";
            resources.ApplyResources(this.tslPrikazSvihIznajmljivanja, "tslPrikazSvihIznajmljivanja");
            this.tslPrikazSvihIznajmljivanja.Click += new System.EventHandler(this.tslPrikazSvihIznajmljivanja_Click);
            // 
            // checkBoxSlobodniAutomobili
            // 
            resources.ApplyResources(this.checkBoxSlobodniAutomobili, "checkBoxSlobodniAutomobili");
            this.checkBoxSlobodniAutomobili.Checked = true;
            this.checkBoxSlobodniAutomobili.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSlobodniAutomobili.Name = "checkBoxSlobodniAutomobili";
            this.checkBoxSlobodniAutomobili.UseVisualStyleBackColor = true;
            this.checkBoxSlobodniAutomobili.CheckedChanged += new System.EventHandler(this.checkBoxSlobodniAutomobili_CheckedChanged);
            // 
            // checkBoxIznajmljeniAutomobili
            // 
            resources.ApplyResources(this.checkBoxIznajmljeniAutomobili, "checkBoxIznajmljeniAutomobili");
            this.checkBoxIznajmljeniAutomobili.Checked = true;
            this.checkBoxIznajmljeniAutomobili.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxIznajmljeniAutomobili.Name = "checkBoxIznajmljeniAutomobili";
            this.checkBoxIznajmljeniAutomobili.UseVisualStyleBackColor = true;
            this.checkBoxIznajmljeniAutomobili.CheckedChanged += new System.EventHandler(this.checkBoxIznajmljeniAutomobili_CheckedChanged);
            // 
            // PrikazAutomobilaForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.checkBoxIznajmljeniAutomobili);
            this.Controls.Add(this.checkBoxSlobodniAutomobili);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tbPretraga);
            this.Controls.Add(this.lbPretraga);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.Name = "PrikazAutomobilaForm";
            this.Load += new System.EventHandler(this.PrikazAutomobilaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbPretraga;
        private System.Windows.Forms.TextBox tbPretraga;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemDetalji;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemZaduzi;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemRazduzi;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel tslDetalji;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel tslZaduzi;
        private System.Windows.Forms.ToolStripLabel tslRazduzi;
        private MySql.Data.MySqlClient.MySqlConnection mySqlConnection1;
        private System.Windows.Forms.CheckBox checkBoxSlobodniAutomobili;
        private System.Windows.Forms.CheckBox checkBoxIznajmljeniAutomobili;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel tslPrikazSvihIznajmljivanja;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdAutomobil;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNaziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBrojSjedista;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGodiste;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGorivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTransmisija;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn colZaduzen;
    }
}