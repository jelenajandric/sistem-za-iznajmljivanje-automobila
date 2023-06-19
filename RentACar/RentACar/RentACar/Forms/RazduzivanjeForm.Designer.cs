
namespace RentACar.Forms
{
    partial class RazduzivanjeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RazduzivanjeForm));
            this.label1 = new System.Windows.Forms.Label();
            this.btnDa = new System.Windows.Forms.Button();
            this.btnNe = new System.Windows.Forms.Button();
            this.labelaVrijeme = new System.Windows.Forms.Label();
            this.labelacijena = new System.Windows.Forms.Label();
            this.lbvrijemeRazduzivanja = new System.Windows.Forms.Label();
            this.lbCijena = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // btnDa
            // 
            resources.ApplyResources(this.btnDa, "btnDa");
            this.btnDa.Name = "btnDa";
            this.btnDa.UseVisualStyleBackColor = true;
            this.btnDa.Click += new System.EventHandler(this.btnDa_Click);
            // 
            // btnNe
            // 
            resources.ApplyResources(this.btnNe, "btnNe");
            this.btnNe.Name = "btnNe";
            this.btnNe.UseVisualStyleBackColor = true;
            this.btnNe.Click += new System.EventHandler(this.btnNe_Click);
            // 
            // labelaVrijeme
            // 
            resources.ApplyResources(this.labelaVrijeme, "labelaVrijeme");
            this.labelaVrijeme.Name = "labelaVrijeme";
            // 
            // labelacijena
            // 
            resources.ApplyResources(this.labelacijena, "labelacijena");
            this.labelacijena.Name = "labelacijena";
            // 
            // lbvrijemeRazduzivanja
            // 
            resources.ApplyResources(this.lbvrijemeRazduzivanja, "lbvrijemeRazduzivanja");
            this.lbvrijemeRazduzivanja.Name = "lbvrijemeRazduzivanja";
            // 
            // lbCijena
            // 
            resources.ApplyResources(this.lbCijena, "lbCijena");
            this.lbCijena.Name = "lbCijena";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // RazduzivanjeForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbCijena);
            this.Controls.Add(this.lbvrijemeRazduzivanja);
            this.Controls.Add(this.labelacijena);
            this.Controls.Add(this.labelaVrijeme);
            this.Controls.Add(this.btnNe);
            this.Controls.Add(this.btnDa);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "RazduzivanjeForm";
            this.Load += new System.EventHandler(this.RazduzivanjeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDa;
        private System.Windows.Forms.Button btnNe;
        private System.Windows.Forms.Label labelaVrijeme;
        private System.Windows.Forms.Label labelacijena;
        private System.Windows.Forms.Label lbvrijemeRazduzivanja;
        private System.Windows.Forms.Label lbCijena;
        private System.Windows.Forms.Timer timer1;
    }
}