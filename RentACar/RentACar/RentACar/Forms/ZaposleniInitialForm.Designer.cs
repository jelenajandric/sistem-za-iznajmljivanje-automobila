
namespace RentACar.Forms
{
    partial class ZaposleniInitialForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZaposleniInitialForm));
            this.btnPregledVoznogParka = new System.Windows.Forms.Button();
            this.btnAzurirajSvojProfil = new System.Windows.Forms.Button();
            this.cbTema = new System.Windows.Forms.ComboBox();
            this.lbTema = new System.Windows.Forms.Label();
            this.btnOdjaviSe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPregledVoznogParka
            // 
            resources.ApplyResources(this.btnPregledVoznogParka, "btnPregledVoznogParka");
            this.btnPregledVoznogParka.Name = "btnPregledVoznogParka";
            this.btnPregledVoznogParka.UseVisualStyleBackColor = true;
            this.btnPregledVoznogParka.Click += new System.EventHandler(this.btnPregledVoznogParka_Click);
            // 
            // btnAzurirajSvojProfil
            // 
            resources.ApplyResources(this.btnAzurirajSvojProfil, "btnAzurirajSvojProfil");
            this.btnAzurirajSvojProfil.Name = "btnAzurirajSvojProfil";
            this.btnAzurirajSvojProfil.UseVisualStyleBackColor = true;
            this.btnAzurirajSvojProfil.Click += new System.EventHandler(this.button2_Click);
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
            // lbTema
            // 
            resources.ApplyResources(this.lbTema, "lbTema");
            this.lbTema.Name = "lbTema";
            // 
            // btnOdjaviSe
            // 
            resources.ApplyResources(this.btnOdjaviSe, "btnOdjaviSe");
            this.btnOdjaviSe.Name = "btnOdjaviSe";
            this.btnOdjaviSe.UseVisualStyleBackColor = true;
            this.btnOdjaviSe.Click += new System.EventHandler(this.btnOdjaviSe_Click);
            // 
            // ZaposleniInitialForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnOdjaviSe);
            this.Controls.Add(this.lbTema);
            this.Controls.Add(this.cbTema);
            this.Controls.Add(this.btnAzurirajSvojProfil);
            this.Controls.Add(this.btnPregledVoznogParka);
            this.MaximizeBox = false;
            this.Name = "ZaposleniInitialForm";
            this.Load += new System.EventHandler(this.ZaposleniInitialForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPregledVoznogParka;
        private System.Windows.Forms.Button btnAzurirajSvojProfil;
        private System.Windows.Forms.ComboBox cbTema;
        private System.Windows.Forms.Label lbTema;
        private System.Windows.Forms.Button btnOdjaviSe;
    }
}