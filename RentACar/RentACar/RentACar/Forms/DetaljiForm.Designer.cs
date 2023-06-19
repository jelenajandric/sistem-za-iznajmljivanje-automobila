
namespace RentACar.Forms
{
    partial class DetaljiForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetaljiForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbKubikaza = new System.Windows.Forms.Label();
            this.lbPotrosnja = new System.Windows.Forms.Label();
            this.lbGorivo = new System.Windows.Forms.Label();
            this.lbTransmisija = new System.Windows.Forms.Label();
            this.lbGodinaProizvodnje = new System.Windows.Forms.Label();
            this.lbKapacitetRezervoara = new System.Windows.Forms.Label();
            this.lbKonjskihSnaga = new System.Windows.Forms.Label();
            this.lbBrojSjedista = new System.Windows.Forms.Label();
            this.lbNazivICijena = new System.Windows.Forms.Label();
            this.pbSlikaAuta = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlikaAuta)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.lbKubikaza, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbPotrosnja, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbGorivo, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbTransmisija, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbGodinaProizvodnje, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbKapacitetRezervoara, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbKonjskihSnaga, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbBrojSjedista, 1, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // lbKubikaza
            // 
            resources.ApplyResources(this.lbKubikaza, "lbKubikaza");
            this.lbKubikaza.Name = "lbKubikaza";
            // 
            // lbPotrosnja
            // 
            resources.ApplyResources(this.lbPotrosnja, "lbPotrosnja");
            this.lbPotrosnja.Name = "lbPotrosnja";
            // 
            // lbGorivo
            // 
            resources.ApplyResources(this.lbGorivo, "lbGorivo");
            this.lbGorivo.Name = "lbGorivo";
            // 
            // lbTransmisija
            // 
            resources.ApplyResources(this.lbTransmisija, "lbTransmisija");
            this.lbTransmisija.Name = "lbTransmisija";
            // 
            // lbGodinaProizvodnje
            // 
            resources.ApplyResources(this.lbGodinaProizvodnje, "lbGodinaProizvodnje");
            this.lbGodinaProizvodnje.Name = "lbGodinaProizvodnje";
            // 
            // lbKapacitetRezervoara
            // 
            resources.ApplyResources(this.lbKapacitetRezervoara, "lbKapacitetRezervoara");
            this.lbKapacitetRezervoara.Name = "lbKapacitetRezervoara";
            // 
            // lbKonjskihSnaga
            // 
            resources.ApplyResources(this.lbKonjskihSnaga, "lbKonjskihSnaga");
            this.lbKonjskihSnaga.Name = "lbKonjskihSnaga";
            // 
            // lbBrojSjedista
            // 
            resources.ApplyResources(this.lbBrojSjedista, "lbBrojSjedista");
            this.lbBrojSjedista.Name = "lbBrojSjedista";
            // 
            // lbNazivICijena
            // 
            resources.ApplyResources(this.lbNazivICijena, "lbNazivICijena");
            this.lbNazivICijena.Name = "lbNazivICijena";
            // 
            // pbSlikaAuta
            // 
            resources.ApplyResources(this.pbSlikaAuta, "pbSlikaAuta");
            this.pbSlikaAuta.Name = "pbSlikaAuta";
            this.pbSlikaAuta.TabStop = false;
            // 
            // DetaljiForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbNazivICijena);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pbSlikaAuta);
            this.MaximizeBox = false;
            this.Name = "DetaljiForm";
            this.Load += new System.EventHandler(this.DetaljiForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlikaAuta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbSlikaAuta;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbKubikaza;
        private System.Windows.Forms.Label lbPotrosnja;
        private System.Windows.Forms.Label lbGorivo;
        private System.Windows.Forms.Label lbTransmisija;
        private System.Windows.Forms.Label lbGodinaProizvodnje;
        private System.Windows.Forms.Label lbKapacitetRezervoara;
        private System.Windows.Forms.Label lbKonjskihSnaga;
        private System.Windows.Forms.Label lbBrojSjedista;
        private System.Windows.Forms.Label lbNazivICijena;
    }
}