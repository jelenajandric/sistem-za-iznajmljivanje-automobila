
namespace RentACar.Forms
{
    partial class PrikazIznajmljivaca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrikazIznajmljivaca));
            this.lbIme = new System.Windows.Forms.Label();
            this.lbPrezime = new System.Windows.Forms.Label();
            this.lbJmb = new System.Windows.Forms.Label();
            this.lbBrojTelefona = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbAdresa = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbIme
            // 
            resources.ApplyResources(this.lbIme, "lbIme");
            this.lbIme.Name = "lbIme";
            // 
            // lbPrezime
            // 
            resources.ApplyResources(this.lbPrezime, "lbPrezime");
            this.lbPrezime.Name = "lbPrezime";
            // 
            // lbJmb
            // 
            resources.ApplyResources(this.lbJmb, "lbJmb");
            this.lbJmb.Name = "lbJmb";
            // 
            // lbBrojTelefona
            // 
            resources.ApplyResources(this.lbBrojTelefona, "lbBrojTelefona");
            this.lbBrojTelefona.Name = "lbBrojTelefona";
            // 
            // lbEmail
            // 
            resources.ApplyResources(this.lbEmail, "lbEmail");
            this.lbEmail.Name = "lbEmail";
            // 
            // lbAdresa
            // 
            resources.ApplyResources(this.lbAdresa, "lbAdresa");
            this.lbAdresa.Name = "lbAdresa";
            // 
            // PrikazIznajmljivaca
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbAdresa);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbBrojTelefona);
            this.Controls.Add(this.lbJmb);
            this.Controls.Add(this.lbPrezime);
            this.Controls.Add(this.lbIme);
            this.MaximizeBox = false;
            this.Name = "PrikazIznajmljivaca";
            this.Load += new System.EventHandler(this.PrikazIznajmljivaca_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbIme;
        private System.Windows.Forms.Label lbPrezime;
        private System.Windows.Forms.Label lbJmb;
        private System.Windows.Forms.Label lbBrojTelefona;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbAdresa;
    }
}