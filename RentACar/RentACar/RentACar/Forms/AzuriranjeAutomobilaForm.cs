using RentACar.Data.DataAcces.Exceptions;
using RentACar.Data.Model;
using RentACar.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACar.Forms
{
    public partial class AzuriranjeAutomobilaForm : Form
    {
        Administrator admin;
        Automobil auto;
        string jezik;
        string tema;
        public AzuriranjeAutomobilaForm() : this(null, 0, "", "")
        {
        }
         public AzuriranjeAutomobilaForm(Administrator a, int id, string jezik, string tema)
        {
            InitializeComponent();
            admin = a;
            this.jezik = jezik;
            this.tema = tema;
            auto = Common.DataFactory.Automobili.getOne(id);
            tbNaziv.Text = auto.naziv;
            tbKubikaza.Text = auto.kubikaza.ToString();
            tbPotrosnja.Text = auto.potrosnja;
            tbGorivo.Text = auto.gorivo;
            comboBoxTransmisija.Text = auto.transmisija;
            tbGodinaProizvodnje.Text = auto.godinaProizvodnje.ToString();
            tbKapcitetRezervoara.Text = auto.kapacietetRezervoara.ToString();
            tbKonjskihSnaga.Text = auto.konjskihSnaga.ToString();
            tbBrojSjedista.Text = auto.brojSjedista.ToString();
            tbCijena.Text = auto.cijena.ToString();
        }

        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            StringBuilder errorMessage = new StringBuilder();
            string naziv = tbNaziv.Text.Trim();
            string kubikaza = tbKubikaza.Text.Trim();
            string potrosnja = tbPotrosnja.Text.Trim();
            string gorivo = tbGorivo.Text.Trim();
            string transmisija = (string)comboBoxTransmisija.SelectedItem;
            string godinaProizvodnje = tbGodinaProizvodnje.Text.Trim();
            string kapacitetRezervoara = tbKapcitetRezervoara.Text.Trim();
            string konjskihSnaga = tbKonjskihSnaga.Text.Trim();
            string brojSjedista = tbBrojSjedista.Text.Trim();
            string cijena = tbCijena.Text.Trim();

            if (string.IsNullOrEmpty(naziv) || string.IsNullOrEmpty(kubikaza) || string.IsNullOrEmpty(potrosnja) || string.IsNullOrEmpty(gorivo) ||
                string.IsNullOrEmpty(godinaProizvodnje) || string.IsNullOrEmpty(kapacitetRezervoara) || string.IsNullOrEmpty(konjskihSnaga) ||
                string.IsNullOrEmpty(brojSjedista) || string.IsNullOrEmpty(cijena))
            {
                if (jezik.Equals("Srpski"))
                {
                    errorMessage.AppendLine("Morate popuniti sva polja!");
                } 
                else
                {
                    errorMessage.AppendLine("You must enter data in all fields!");
                }
            }
            if (comboBoxTransmisija.SelectedIndex == -1)
            {
                if (jezik.Equals("Srpski"))
                {
                    errorMessage.AppendLine("Transmisija mora biti izabrana.");
                }
                else
                {
                    errorMessage.AppendLine("Transmission must be selected.");
                }
            }
            if (errorMessage.Length > 0)
            {
                new ObavjestenjeForm(errorMessage.ToString(), jezik, tema).ShowDialog();
                return;
            }

            Automobil a = new Automobil();
            a.idAutomobil = auto.idAutomobil;
            a.naziv = naziv;
            a.kubikaza = Int32.Parse(kubikaza);
            a.potrosnja = potrosnja;
            a.gorivo = gorivo;
            a.transmisija = transmisija;
            a.godinaProizvodnje = godinaProizvodnje;
            a.kapacietetRezervoara = Int32.Parse(kapacitetRezervoara);
            a.konjskihSnaga = Int32.Parse(konjskihSnaga);
            a.brojSjedista = Int32.Parse(brojSjedista);
            a.cijena = Int32.Parse(cijena);
            a.Administrator_jmb = admin.jmb;
            try
            {
                Common.DataFactory.Automobili.azurirajAutomobil(a);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (DataAccessException ex)
            {
                new ObavjestenjeForm(ex.InnerException.Message, jezik, tema).ShowDialog();
            }
        }

        private void AzuriranjeAutomobilaForm_Load(object sender, EventArgs e)
        {
            this.comboBoxTransmisija.DropDownStyle = ComboBoxStyle.DropDownList;
            if (jezik == "Srpski")
            {
                ChangeLanguage("sr-Latn-BA");
            }
            else
            {
                ChangeLanguage("en");
            }
            if (tema == "Tamna")
            {
                promjeniTemu(Color.DimGray, Color.White, Color.Gray, "Consolas", FontStyle.Bold, 9);
            }
            else if (tema == "Zelena")
            {
                promjeniTemu(Color.DarkSeaGreen, Color.Maroon, Color.Azure, "Reem Kufi", FontStyle.Regular, 9);
            }
            else if (tema == "Plava")
            {
                promjeniTemu(Color.LightSteelBlue, Color.SaddleBrown, Color.LightGray, "Lucida Handwriting", FontStyle.Bold, 9);
            }
            else
            {
                promjeniTemu(Color.WhiteSmoke, Color.Black, Color.Gainsboro, "Microsoft Sans Serif", FontStyle.Regular, 9);
            }

        }

        private void promjeniTemu(Color backColorForm, Color foreColor, Color backColor, String font, FontStyle fs, float velicinaFonta)
        {
            this.BackColor = backColorForm;
            this.ForeColor = foreColor;
            btnPotvrdi.BackColor = backColor;
            btnPotvrdi.ForeColor = foreColor;
            tbNaziv.BackColor = backColor;
            tbNaziv.ForeColor = foreColor;
            tbKubikaza.BackColor = backColor;
            tbKubikaza.ForeColor = foreColor;
            tbPotrosnja.BackColor = backColor;
            tbPotrosnja.ForeColor = foreColor;
            tbGorivo.BackColor = backColor;
            tbGorivo.ForeColor = foreColor;
            comboBoxTransmisija.BackColor = backColor;
            comboBoxTransmisija.ForeColor = foreColor;
            tbGodinaProizvodnje.BackColor = backColor;
            tbGodinaProizvodnje.ForeColor = foreColor;
            tbKapcitetRezervoara.BackColor = backColor;
            tbKapcitetRezervoara.ForeColor = foreColor;
            tbKonjskihSnaga.BackColor = backColor;
            tbKonjskihSnaga.ForeColor = foreColor;
            tbBrojSjedista.BackColor = backColor;
            tbBrojSjedista.ForeColor = foreColor;
            tbCijena.BackColor = backColor;
            tbCijena.ForeColor = foreColor;

            lbNaziv.Font = new Font(font, velicinaFonta, fs);
            lbKubikaza.Font = new Font(font, velicinaFonta, fs);
            lbPotrošnja.Font = new Font(font, velicinaFonta, fs);
            lbGorivo.Font = new Font(font, velicinaFonta, fs);
            lbTransmisija.Font = new Font(font, velicinaFonta, fs);
            lbGodinaProizvodnje.Font = new Font(font, velicinaFonta, fs);
            lbKapacitetRezervoara.Font = new Font(font, velicinaFonta, fs);
            lbKonjskihSnaga.Font = new Font(font, velicinaFonta, fs);
            lbBrojSjedista.Font = new Font(font, velicinaFonta, fs);
            lbCijena.Font = new Font(font, velicinaFonta, fs);

            tbNaziv.Font = new Font(font, velicinaFonta, fs);
            tbKubikaza.Font = new Font(font, velicinaFonta, fs);
            tbPotrosnja.Font = new Font(font, velicinaFonta, fs);
            tbGorivo.Font = new Font(font, velicinaFonta, fs);
            comboBoxTransmisija.Font = new Font(font, velicinaFonta, fs);
            tbGodinaProizvodnje.Font = new Font(font, velicinaFonta, fs);
            tbKapcitetRezervoara.Font = new Font(font, velicinaFonta, fs);
            tbKonjskihSnaga.Font = new Font(font, velicinaFonta, fs);
            tbBrojSjedista.Font = new Font(font, velicinaFonta, fs);
            tbCijena.Font = new Font(font, velicinaFonta, fs);
            btnPotvrdi.Font = new Font(font, velicinaFonta, fs);


        }
        private void ChangeLanguage(string lang)
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(lang);
            ComponentResourceManager resources = new ComponentResourceManager(typeof(AzuriranjeAutomobilaForm));
            resources.ApplyResources(this, "$this");
            applyResources(resources, this.Controls);
            ApplyResourceToControl(this, new ComponentResourceManager(typeof(AzuriranjeAutomobilaForm)), new CultureInfo(lang));

        }
        private void applyResources(ComponentResourceManager resources, Control.ControlCollection ctls)
        {
            foreach (Control ctl in ctls)
            {
                resources.ApplyResources(ctl, ctl.Name);
                applyResources(resources, ctl.Controls);
            }
        }
        private void ApplyResourceToControl(Control control, ComponentResourceManager cmp, CultureInfo cultureInfo)
        {
            cmp.ApplyResources(control, control.Name, cultureInfo);

            foreach (Control child in control.Controls)
            {
                ApplyResourceToControl(child, cmp, cultureInfo);
            }
        }


    }
}
