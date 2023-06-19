
namespace RentACar.Forms
{
    partial class PredgledSvihIznajmljivanjaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PredgledSvihIznajmljivanjaForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colIdIznajmljivanje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdAutomobila = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNazivAutomobila = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colImeIPrezimeIznajmljivaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colJmbIznajmljivaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colImeIPrezimeZaduzivaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colJmbZaduzivaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colImeIPrezimeRazduzivaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colJmbRazduzivaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDatumZaduzenja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDatumRazduzenja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPretraga = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsPregledIznajmljivaca = new System.Windows.Forms.ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdIznajmljivanje,
            this.colIdAutomobila,
            this.colNazivAutomobila,
            this.colImeIPrezimeIznajmljivaca,
            this.colJmbIznajmljivaca,
            this.colImeIPrezimeZaduzivaca,
            this.colJmbZaduzivaca,
            this.colImeIPrezimeRazduzivaca,
            this.colJmbRazduzivaca,
            this.colDatumZaduzenja,
            this.colDatumRazduzenja});
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // colIdIznajmljivanje
            // 
            resources.ApplyResources(this.colIdIznajmljivanje, "colIdIznajmljivanje");
            this.colIdIznajmljivanje.Name = "colIdIznajmljivanje";
            // 
            // colIdAutomobila
            // 
            resources.ApplyResources(this.colIdAutomobila, "colIdAutomobila");
            this.colIdAutomobila.Name = "colIdAutomobila";
            // 
            // colNazivAutomobila
            // 
            resources.ApplyResources(this.colNazivAutomobila, "colNazivAutomobila");
            this.colNazivAutomobila.Name = "colNazivAutomobila";
            // 
            // colImeIPrezimeIznajmljivaca
            // 
            resources.ApplyResources(this.colImeIPrezimeIznajmljivaca, "colImeIPrezimeIznajmljivaca");
            this.colImeIPrezimeIznajmljivaca.Name = "colImeIPrezimeIznajmljivaca";
            // 
            // colJmbIznajmljivaca
            // 
            resources.ApplyResources(this.colJmbIznajmljivaca, "colJmbIznajmljivaca");
            this.colJmbIznajmljivaca.Name = "colJmbIznajmljivaca";
            // 
            // colImeIPrezimeZaduzivaca
            // 
            resources.ApplyResources(this.colImeIPrezimeZaduzivaca, "colImeIPrezimeZaduzivaca");
            this.colImeIPrezimeZaduzivaca.Name = "colImeIPrezimeZaduzivaca";
            // 
            // colJmbZaduzivaca
            // 
            resources.ApplyResources(this.colJmbZaduzivaca, "colJmbZaduzivaca");
            this.colJmbZaduzivaca.Name = "colJmbZaduzivaca";
            // 
            // colImeIPrezimeRazduzivaca
            // 
            resources.ApplyResources(this.colImeIPrezimeRazduzivaca, "colImeIPrezimeRazduzivaca");
            this.colImeIPrezimeRazduzivaca.Name = "colImeIPrezimeRazduzivaca";
            // 
            // colJmbRazduzivaca
            // 
            resources.ApplyResources(this.colJmbRazduzivaca, "colJmbRazduzivaca");
            this.colJmbRazduzivaca.Name = "colJmbRazduzivaca";
            // 
            // colDatumZaduzenja
            // 
            resources.ApplyResources(this.colDatumZaduzenja, "colDatumZaduzenja");
            this.colDatumZaduzenja.Name = "colDatumZaduzenja";
            // 
            // colDatumRazduzenja
            // 
            resources.ApplyResources(this.colDatumRazduzenja, "colDatumRazduzenja");
            this.colDatumRazduzenja.Name = "colDatumRazduzenja";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // tbPretraga
            // 
            resources.ApplyResources(this.tbPretraga, "tbPretraga");
            this.tbPretraga.Name = "tbPretraga";
            this.tbPretraga.TextChanged += new System.EventHandler(this.tbPretraga_TextChanged);
            // 
            // checkBox1
            // 
            resources.ApplyResources(this.checkBox1, "checkBox1");
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // toolStrip1
            // 
            resources.ApplyResources(this.toolStrip1, "toolStrip1");
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsPregledIznajmljivaca});
            this.toolStrip1.Name = "toolStrip1";
            // 
            // tsPregledIznajmljivaca
            // 
            resources.ApplyResources(this.tsPregledIznajmljivaca, "tsPregledIznajmljivaca");
            this.tsPregledIznajmljivaca.Name = "tsPregledIznajmljivaca";
            this.tsPregledIznajmljivaca.Click += new System.EventHandler(this.tsPregledIznajmljivaca_Click);
            // 
            // PredgledSvihIznajmljivanjaForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.tbPretraga);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.Name = "PredgledSvihIznajmljivanjaForm";
            this.Load += new System.EventHandler(this.PredgledSvihIznajmljivanjaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPretraga;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel tsPregledIznajmljivaca;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdIznajmljivanje;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdAutomobila;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNazivAutomobila;
        private System.Windows.Forms.DataGridViewTextBoxColumn colImeIPrezimeIznajmljivaca;
        private System.Windows.Forms.DataGridViewTextBoxColumn colJmbIznajmljivaca;
        private System.Windows.Forms.DataGridViewTextBoxColumn colImeIPrezimeZaduzivaca;
        private System.Windows.Forms.DataGridViewTextBoxColumn colJmbZaduzivaca;
        private System.Windows.Forms.DataGridViewTextBoxColumn colImeIPrezimeRazduzivaca;
        private System.Windows.Forms.DataGridViewTextBoxColumn colJmbRazduzivaca;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDatumZaduzenja;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDatumRazduzenja;
    }
}