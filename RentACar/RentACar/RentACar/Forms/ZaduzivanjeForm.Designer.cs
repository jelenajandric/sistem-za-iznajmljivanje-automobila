
namespace RentACar.Forms
{
    partial class ZaduzivanjeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZaduzivanjeForm));
            this.label1 = new System.Windows.Forms.Label();
            this.lbIme = new System.Windows.Forms.Label();
            this.lbPrezime = new System.Windows.Forms.Label();
            this.lbJmb = new System.Windows.Forms.Label();
            this.lbBrojTelefona = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbAdresa = new System.Windows.Forms.Label();
            this.tbIme = new System.Windows.Forms.TextBox();
            this.tbPrezime = new System.Windows.Forms.TextBox();
            this.tbJmb = new System.Windows.Forms.TextBox();
            this.tbBrojTelefona = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbAdresa = new System.Windows.Forms.TextBox();
            this.labelaVrijeme = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.tmrTimer = new System.Windows.Forms.Timer(this.components);
            this.lbVrijemeZaduzenja = new System.Windows.Forms.Label();
            this.cbIznajmljivaci = new System.Windows.Forms.ComboBox();
            this.btnZaduzi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
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
            // tbIme
            // 
            resources.ApplyResources(this.tbIme, "tbIme");
            this.tbIme.Name = "tbIme";
            // 
            // tbPrezime
            // 
            resources.ApplyResources(this.tbPrezime, "tbPrezime");
            this.tbPrezime.Name = "tbPrezime";
            // 
            // tbJmb
            // 
            resources.ApplyResources(this.tbJmb, "tbJmb");
            this.tbJmb.Name = "tbJmb";
            // 
            // tbBrojTelefona
            // 
            resources.ApplyResources(this.tbBrojTelefona, "tbBrojTelefona");
            this.tbBrojTelefona.Name = "tbBrojTelefona";
            // 
            // tbEmail
            // 
            resources.ApplyResources(this.tbEmail, "tbEmail");
            this.tbEmail.Name = "tbEmail";
            // 
            // tbAdresa
            // 
            resources.ApplyResources(this.tbAdresa, "tbAdresa");
            this.tbAdresa.Name = "tbAdresa";
            // 
            // labelaVrijeme
            // 
            resources.ApplyResources(this.labelaVrijeme, "labelaVrijeme");
            this.labelaVrijeme.Name = "labelaVrijeme";
            // 
            // btnDodaj
            // 
            resources.ApplyResources(this.btnDodaj, "btnDodaj");
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnZaduzi_Click);
            // 
            // tmrTimer
            // 
            this.tmrTimer.Enabled = true;
            this.tmrTimer.Interval = 1000;
            this.tmrTimer.Tick += new System.EventHandler(this.tmrTimer_Tick);
            // 
            // lbVrijemeZaduzenja
            // 
            resources.ApplyResources(this.lbVrijemeZaduzenja, "lbVrijemeZaduzenja");
            this.lbVrijemeZaduzenja.Name = "lbVrijemeZaduzenja";
            // 
            // cbIznajmljivaci
            // 
            this.cbIznajmljivaci.FormattingEnabled = true;
            resources.ApplyResources(this.cbIznajmljivaci, "cbIznajmljivaci");
            this.cbIznajmljivaci.Name = "cbIznajmljivaci";
            // 
            // btnZaduzi
            // 
            resources.ApplyResources(this.btnZaduzi, "btnZaduzi");
            this.btnZaduzi.Name = "btnZaduzi";
            this.btnZaduzi.UseVisualStyleBackColor = true;
            this.btnZaduzi.Click += new System.EventHandler(this.btnZaduzi_Click_1);
            // 
            // ZaduzivanjeForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnZaduzi);
            this.Controls.Add(this.cbIznajmljivaci);
            this.Controls.Add(this.lbVrijemeZaduzenja);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.labelaVrijeme);
            this.Controls.Add(this.tbAdresa);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbBrojTelefona);
            this.Controls.Add(this.tbJmb);
            this.Controls.Add(this.tbPrezime);
            this.Controls.Add(this.tbIme);
            this.Controls.Add(this.lbAdresa);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbBrojTelefona);
            this.Controls.Add(this.lbJmb);
            this.Controls.Add(this.lbPrezime);
            this.Controls.Add(this.lbIme);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "ZaduzivanjeForm";
            this.Load += new System.EventHandler(this.ZaduzivanjeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbIme;
        private System.Windows.Forms.Label lbPrezime;
        private System.Windows.Forms.Label lbJmb;
        private System.Windows.Forms.Label lbBrojTelefona;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbAdresa;
        private System.Windows.Forms.TextBox tbIme;
        private System.Windows.Forms.TextBox tbPrezime;
        private System.Windows.Forms.TextBox tbJmb;
        private System.Windows.Forms.TextBox tbBrojTelefona;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbAdresa;
        private System.Windows.Forms.Label labelaVrijeme;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Timer tmrTimer;
        private System.Windows.Forms.Label lbVrijemeZaduzenja;
        private System.Windows.Forms.Button btnZaduzi;
        private System.Windows.Forms.ComboBox cbIznajmljivaci;
    }
}