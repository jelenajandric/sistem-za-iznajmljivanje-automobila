
namespace RentACar.Forms
{
    partial class PrikazZaposlenihForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrikazZaposlenihForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colPrezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colJmb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBrojTelefona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKorisnickoIme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOnemogucen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.onemoguciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.omoguciNalogZaposlenomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajnovogZaposlenogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbPretraga = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPrezime,
            this.colIme,
            this.colJmb,
            this.colBrojTelefona,
            this.colEmail,
            this.colKorisnickoIme,
            this.colOnemogucen});
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // colPrezime
            // 
            resources.ApplyResources(this.colPrezime, "colPrezime");
            this.colPrezime.Name = "colPrezime";
            // 
            // colIme
            // 
            resources.ApplyResources(this.colIme, "colIme");
            this.colIme.Name = "colIme";
            // 
            // colJmb
            // 
            resources.ApplyResources(this.colJmb, "colJmb");
            this.colJmb.Name = "colJmb";
            // 
            // colBrojTelefona
            // 
            resources.ApplyResources(this.colBrojTelefona, "colBrojTelefona");
            this.colBrojTelefona.Name = "colBrojTelefona";
            // 
            // colEmail
            // 
            resources.ApplyResources(this.colEmail, "colEmail");
            this.colEmail.Name = "colEmail";
            // 
            // colKorisnickoIme
            // 
            resources.ApplyResources(this.colKorisnickoIme, "colKorisnickoIme");
            this.colKorisnickoIme.Name = "colKorisnickoIme";
            // 
            // colOnemogucen
            // 
            resources.ApplyResources(this.colOnemogucen, "colOnemogucen");
            this.colOnemogucen.Name = "colOnemogucen";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ContextMenuStrip = this.contextMenuStrip1;
            this.label1.Name = "label1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.onemoguciToolStripMenuItem,
            this.omoguciNalogZaposlenomToolStripMenuItem,
            this.dodajnovogZaposlenogToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            // 
            // onemoguciToolStripMenuItem
            // 
            this.onemoguciToolStripMenuItem.Image = global::RentACar.Properties.Resources._132192_delete_icon;
            this.onemoguciToolStripMenuItem.Name = "onemoguciToolStripMenuItem";
            resources.ApplyResources(this.onemoguciToolStripMenuItem, "onemoguciToolStripMenuItem");
            this.onemoguciToolStripMenuItem.Click += new System.EventHandler(this.obrisiToolStripMenuItem_Click);
            // 
            // omoguciNalogZaposlenomToolStripMenuItem
            // 
            this.omoguciNalogZaposlenomToolStripMenuItem.Image = global::RentACar.Properties.Resources._132306_properties_icon;
            this.omoguciNalogZaposlenomToolStripMenuItem.Name = "omoguciNalogZaposlenomToolStripMenuItem";
            resources.ApplyResources(this.omoguciNalogZaposlenomToolStripMenuItem, "omoguciNalogZaposlenomToolStripMenuItem");
            this.omoguciNalogZaposlenomToolStripMenuItem.Click += new System.EventHandler(this.omoguciNalogZaposlenomToolStripMenuItem_Click);
            // 
            // dodajnovogZaposlenogToolStripMenuItem
            // 
            this.dodajnovogZaposlenogToolStripMenuItem.Image = global::RentACar.Properties.Resources._132335_add_icon;
            this.dodajnovogZaposlenogToolStripMenuItem.Name = "dodajnovogZaposlenogToolStripMenuItem";
            resources.ApplyResources(this.dodajnovogZaposlenogToolStripMenuItem, "dodajnovogZaposlenogToolStripMenuItem");
            this.dodajnovogZaposlenogToolStripMenuItem.Click += new System.EventHandler(this.dodajnovogZaposlenogToolStripMenuItem_Click);
            // 
            // tbPretraga
            // 
            resources.ApplyResources(this.tbPretraga, "tbPretraga");
            this.tbPretraga.Name = "tbPretraga";
            this.tbPretraga.TextChanged += new System.EventHandler(this.tbPretraga_TextChanged_1);
            // 
            // PrikazZaposlenihForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPretraga);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.Name = "PrikazZaposlenihForm";
            this.Load += new System.EventHandler(this.PrikazZaposlenihForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPretraga;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem onemoguciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajnovogZaposlenogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem omoguciNalogZaposlenomToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIme;
        private System.Windows.Forms.DataGridViewTextBoxColumn colJmb;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBrojTelefona;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKorisnickoIme;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOnemogucen;
    }
}