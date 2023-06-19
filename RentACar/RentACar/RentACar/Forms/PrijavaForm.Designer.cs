
namespace RentACar.Forms
{
    partial class PrijavaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrijavaForm));
            this.lbKorisnickoIme = new System.Windows.Forms.Label();
            this.tbKorisnickoIme = new System.Windows.Forms.TextBox();
            this.lbLozinka = new System.Windows.Forms.Label();
            this.tbLozinka = new System.Windows.Forms.TextBox();
            this.btnPrijaviSe = new System.Windows.Forms.Button();
            this.cbJezik = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbKorisnickoIme
            // 
            resources.ApplyResources(this.lbKorisnickoIme, "lbKorisnickoIme");
            this.lbKorisnickoIme.Name = "lbKorisnickoIme";
            // 
            // tbKorisnickoIme
            // 
            resources.ApplyResources(this.tbKorisnickoIme, "tbKorisnickoIme");
            this.tbKorisnickoIme.BackColor = System.Drawing.SystemColors.Window;
            this.tbKorisnickoIme.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbKorisnickoIme.Name = "tbKorisnickoIme";
            // 
            // lbLozinka
            // 
            resources.ApplyResources(this.lbLozinka, "lbLozinka");
            this.lbLozinka.Name = "lbLozinka";
            // 
            // tbLozinka
            // 
            resources.ApplyResources(this.tbLozinka, "tbLozinka");
            this.tbLozinka.BackColor = System.Drawing.SystemColors.Window;
            this.tbLozinka.Name = "tbLozinka";
            // 
            // btnPrijaviSe
            // 
            resources.ApplyResources(this.btnPrijaviSe, "btnPrijaviSe");
            this.btnPrijaviSe.BackColor = System.Drawing.SystemColors.Control;
            this.btnPrijaviSe.Name = "btnPrijaviSe";
            this.btnPrijaviSe.UseVisualStyleBackColor = true;
            this.btnPrijaviSe.Click += new System.EventHandler(this.btnPrijaviSe_Click);
            // 
            // cbJezik
            // 
            resources.ApplyResources(this.cbJezik, "cbJezik");
            this.cbJezik.FormattingEnabled = true;
            this.cbJezik.Items.AddRange(new object[] {
            resources.GetString("cbJezik.Items"),
            resources.GetString("cbJezik.Items1")});
            this.cbJezik.Name = "cbJezik";
            this.cbJezik.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // PrijavaForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbJezik);
            this.Controls.Add(this.btnPrijaviSe);
            this.Controls.Add(this.tbLozinka);
            this.Controls.Add(this.lbLozinka);
            this.Controls.Add(this.tbKorisnickoIme);
            this.Controls.Add(this.lbKorisnickoIme);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaximizeBox = false;
            this.Name = "PrijavaForm";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Load += new System.EventHandler(this.PrijavaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbKorisnickoIme;
        private System.Windows.Forms.TextBox tbKorisnickoIme;
        private System.Windows.Forms.Label lbLozinka;
        private System.Windows.Forms.TextBox tbLozinka;
        private System.Windows.Forms.Button btnPrijaviSe;
        private System.Windows.Forms.ComboBox cbJezik;
        private System.Windows.Forms.Label label1;
    }
}