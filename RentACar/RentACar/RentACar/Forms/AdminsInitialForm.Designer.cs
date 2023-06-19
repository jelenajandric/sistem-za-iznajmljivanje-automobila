
namespace RentACar.Forms
{
    partial class AdminsInitialForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminsInitialForm));
            this.btnPrikazVoznogParka = new System.Windows.Forms.Button();
            this.btnDodajNoviAutomobil = new System.Windows.Forms.Button();
            this.btnPrikazZaposlenih = new System.Windows.Forms.Button();
            this.btnDodajNovogZaposlenog = new System.Windows.Forms.Button();
            this.btnAzurirajSvojePodatke = new System.Windows.Forms.Button();
            this.btnPregledSvihIznajmljivanja = new System.Windows.Forms.Button();
            this.cbTema = new System.Windows.Forms.ComboBox();
            this.btnOdjaviSe = new System.Windows.Forms.Button();
            this.lbTema = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPrikazVoznogParka
            // 
            resources.ApplyResources(this.btnPrikazVoznogParka, "btnPrikazVoznogParka");
            this.btnPrikazVoznogParka.Name = "btnPrikazVoznogParka";
            this.btnPrikazVoznogParka.UseVisualStyleBackColor = true;
            this.btnPrikazVoznogParka.Click += new System.EventHandler(this.btnPrikazVoznogParka_Click);
            // 
            // btnDodajNoviAutomobil
            // 
            resources.ApplyResources(this.btnDodajNoviAutomobil, "btnDodajNoviAutomobil");
            this.btnDodajNoviAutomobil.Name = "btnDodajNoviAutomobil";
            this.btnDodajNoviAutomobil.UseVisualStyleBackColor = true;
            this.btnDodajNoviAutomobil.Click += new System.EventHandler(this.btnDodajNoviAutomobil_Click);
            // 
            // btnPrikazZaposlenih
            // 
            resources.ApplyResources(this.btnPrikazZaposlenih, "btnPrikazZaposlenih");
            this.btnPrikazZaposlenih.Name = "btnPrikazZaposlenih";
            this.btnPrikazZaposlenih.UseVisualStyleBackColor = true;
            this.btnPrikazZaposlenih.Click += new System.EventHandler(this.btnPrikazZaposlenih_Click);
            // 
            // btnDodajNovogZaposlenog
            // 
            resources.ApplyResources(this.btnDodajNovogZaposlenog, "btnDodajNovogZaposlenog");
            this.btnDodajNovogZaposlenog.Name = "btnDodajNovogZaposlenog";
            this.btnDodajNovogZaposlenog.UseVisualStyleBackColor = true;
            this.btnDodajNovogZaposlenog.Click += new System.EventHandler(this.btnDodajNovogZaposlenog_Click);
            // 
            // btnAzurirajSvojePodatke
            // 
            resources.ApplyResources(this.btnAzurirajSvojePodatke, "btnAzurirajSvojePodatke");
            this.btnAzurirajSvojePodatke.Name = "btnAzurirajSvojePodatke";
            this.btnAzurirajSvojePodatke.UseVisualStyleBackColor = true;
            this.btnAzurirajSvojePodatke.Click += new System.EventHandler(this.btnAzurirajSvojePodatke_Click);
            // 
            // btnPregledSvihIznajmljivanja
            // 
            resources.ApplyResources(this.btnPregledSvihIznajmljivanja, "btnPregledSvihIznajmljivanja");
            this.btnPregledSvihIznajmljivanja.Name = "btnPregledSvihIznajmljivanja";
            this.btnPregledSvihIznajmljivanja.UseVisualStyleBackColor = true;
            this.btnPregledSvihIznajmljivanja.Click += new System.EventHandler(this.btnPregledSvihIznajmljivanja_Click);
            // 
            // cbTema
            // 
            this.cbTema.FormattingEnabled = true;
            this.cbTema.Items.AddRange(new object[] {
            resources.GetString("cbTema.Items"),
            resources.GetString("cbTema.Items1"),
            resources.GetString("cbTema.Items2"),
            resources.GetString("cbTema.Items3")});
            resources.ApplyResources(this.cbTema, "cbTema");
            this.cbTema.Name = "cbTema";
            this.cbTema.SelectedIndexChanged += new System.EventHandler(this.cbTema_SelectedIndexChanged);
            // 
            // btnOdjaviSe
            // 
            resources.ApplyResources(this.btnOdjaviSe, "btnOdjaviSe");
            this.btnOdjaviSe.Name = "btnOdjaviSe";
            this.btnOdjaviSe.UseVisualStyleBackColor = true;
            this.btnOdjaviSe.Click += new System.EventHandler(this.btnOdjaviSe_Click);
            // 
            // lbTema
            // 
            resources.ApplyResources(this.lbTema, "lbTema");
            this.lbTema.Name = "lbTema";
            // 
            // AdminsInitialForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.lbTema);
            this.Controls.Add(this.btnOdjaviSe);
            this.Controls.Add(this.cbTema);
            this.Controls.Add(this.btnPregledSvihIznajmljivanja);
            this.Controls.Add(this.btnAzurirajSvojePodatke);
            this.Controls.Add(this.btnDodajNovogZaposlenog);
            this.Controls.Add(this.btnPrikazZaposlenih);
            this.Controls.Add(this.btnDodajNoviAutomobil);
            this.Controls.Add(this.btnPrikazVoznogParka);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaximizeBox = false;
            this.Name = "AdminsInitialForm";
            this.Load += new System.EventHandler(this.AdminsInitialForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrikazVoznogParka;
        private System.Windows.Forms.Button btnDodajNoviAutomobil;
        private System.Windows.Forms.Button btnPrikazZaposlenih;
        private System.Windows.Forms.Button btnDodajNovogZaposlenog;
        private System.Windows.Forms.Button btnAzurirajSvojePodatke;
        private System.Windows.Forms.Button btnPregledSvihIznajmljivanja;
        private System.Windows.Forms.ComboBox cbTema;
        private System.Windows.Forms.Button btnOdjaviSe;
        private System.Windows.Forms.Label lbTema;
    }
}