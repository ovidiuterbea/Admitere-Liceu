using Admitere_Liceu.Clase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admitere_Liceu.Forms
{
    public partial class EditLiceu : Form
    {
        #region Attributes
        private Liceu _liceu;
        #endregion
        public EditLiceu(Liceu liceu)
        {
             _liceu = liceu;
            InitializeComponent();
        }

        

        private void btnOk_Click(object sender, EventArgs e)
        {
            _liceu.NumeLiceu = tbNumeLiceu.Text;
            _liceu.MedieLiceu = float.Parse(tbMedieLiceu.Text);
            _liceu.Profil = comboBoxProfil.Text;
            _liceu.Specializare = comboBoxSpecializare.Text;
        }

        private void EditLiceu_Load(object sender, EventArgs e)
        {
            tbNumeLiceu.Text = _liceu.NumeLiceu;
            tbMedieLiceu.Text = _liceu.MedieLiceu.ToString();
           

            comboBoxProfil.Items.Add("Arte plastice si vizuale");
            comboBoxProfil.Items.Add("Artistic");
            comboBoxProfil.Items.Add("Militar");
            comboBoxProfil.Items.Add("Muzica");
            comboBoxProfil.Items.Add("Real");
            comboBoxProfil.Items.Add("Resurse naturale si protectia mediului");
            comboBoxProfil.Items.Add("Servicii");
            comboBoxProfil.Items.Add("Sportiv");
            comboBoxProfil.Items.Add("Tehnic");
            comboBoxProfil.Items.Add("Teologic");
            comboBoxProfil.Items.Add("Uman");
            comboBoxProfil.Items.Add("Pedagogic");

            comboBoxProfil.Text = _liceu.Profil;
            if (comboBoxProfil.SelectedItem.ToString() == "Real")
            {
                comboBoxSpecializare.Items.Clear();
                comboBoxSpecializare.Items.Add("Matematica-Informatica");
                comboBoxSpecializare.Items.Add("Stiinte ale naturii");

            }
            if (comboBoxProfil.SelectedItem.ToString() == "Arte plastice si vizuale")
            {
                comboBoxSpecializare.Items.Clear();
                comboBoxSpecializare.Items.Add("Arhitectura");
                comboBoxSpecializare.Items.Add("Arte plastice");
                comboBoxSpecializare.Items.Add("Arte vizuale");

            }
            if (comboBoxProfil.SelectedItem.ToString() == "Artistic")
            {
                comboBoxSpecializare.Items.Clear();
                comboBoxSpecializare.Items.Add("Arhitectura,Arte ambientale si Design");
                comboBoxSpecializare.Items.Add("Arta actorului");
                comboBoxSpecializare.Items.Add("Arte plastice si decorative");
                comboBoxSpecializare.Items.Add("Conservare-restaurare bunuri culturale");
                comboBoxSpecializare.Items.Add("Coregrafie");

            }
            if (comboBoxProfil.SelectedItem.ToString() == "Muzica")
            {
                comboBoxSpecializare.Items.Clear();
                comboBoxSpecializare.Items.Add("Muzica");
            }
            if (comboBoxProfil.SelectedItem.ToString() == "Resurse naturale si protectia mediului")
            {
                comboBoxSpecializare.Items.Clear();
                comboBoxSpecializare.Items.Add("Agricultura");
                comboBoxSpecializare.Items.Add("Industrie alimentara");
                comboBoxSpecializare.Items.Add("Protectia mediului");
                comboBoxSpecializare.Items.Add("Sivicultura");
            }
            if (comboBoxProfil.SelectedItem.ToString() == "Servicii")
            {
                comboBoxSpecializare.Items.Clear();
                comboBoxSpecializare.Items.Add("Comert");
                comboBoxSpecializare.Items.Add("Economic");
                comboBoxSpecializare.Items.Add("Estetica si igiena corpului omenesc");
                comboBoxSpecializare.Items.Add("Turism si alimentatie");
            }
            if (comboBoxProfil.SelectedItem.ToString() == "Sportiv")
            {
                comboBoxSpecializare.Items.Clear();
                comboBoxSpecializare.Items.Add("Sportiv");
            }
            if (comboBoxProfil.SelectedItem.ToString() == "Tehnic")
            {
                comboBoxSpecializare.Items.Clear();
                comboBoxSpecializare.Items.Add("Chimie industriala");
                comboBoxSpecializare.Items.Add("Constructii, instalatii si lucrari publice");
                comboBoxSpecializare.Items.Add("Electric");
                comboBoxSpecializare.Items.Add("Electromecanica");
                comboBoxSpecializare.Items.Add("Electronica automatizari");
                comboBoxSpecializare.Items.Add("Fabricarea produselor din lemn");
                comboBoxSpecializare.Items.Add("Industrie textila si pielarie");
                comboBoxSpecializare.Items.Add("Materiale de constructii");
                comboBoxSpecializare.Items.Add("Mecanica");
                comboBoxSpecializare.Items.Add("Productie media");
                comboBoxSpecializare.Items.Add("Tehnici poligrafice");

            }
            if (comboBoxProfil.SelectedItem.ToString() == "Teologic")
            {
                comboBoxSpecializare.Items.Clear();
                comboBoxSpecializare.Items.Add("Ghid turism religios catolic");
                comboBoxSpecializare.Items.Add("Ghid turism religios ortodox");
                comboBoxSpecializare.Items.Add("Muzica bisericeasca");
                comboBoxSpecializare.Items.Add("Patrimoniu cultural");
                comboBoxSpecializare.Items.Add("Teologie adventista");
                comboBoxSpecializare.Items.Add("Teologie baptista");
                comboBoxSpecializare.Items.Add("Teologie greco-catolica");
                comboBoxSpecializare.Items.Add("Teologie musulmana");
                comboBoxSpecializare.Items.Add("Teologie ortodoxa");
                comboBoxSpecializare.Items.Add("Teologie penticostala");
                comboBoxSpecializare.Items.Add("Teologie reformata");
                comboBoxSpecializare.Items.Add("Teologie romano-catolica");
                comboBoxSpecializare.Items.Add("Teologie unitariana");

            }
            if (comboBoxProfil.SelectedItem.ToString() == "Uman")
            {
                comboBoxSpecializare.Items.Clear();
                comboBoxSpecializare.Items.Add("Filologie");
                comboBoxSpecializare.Items.Add("Stiinte sociale");
            }
            if (comboBoxProfil.SelectedItem.ToString() == "Pedagogic")
            {
                comboBoxSpecializare.Items.Clear();
                comboBoxSpecializare.Items.Add("Bibliotecar documentarist");
                comboBoxSpecializare.Items.Add("Educator - invatator");
                comboBoxSpecializare.Items.Add("Educator - puericultor");
                comboBoxSpecializare.Items.Add("Instructor de educatie extrascolara");
            }
            if (comboBoxProfil.SelectedItem.ToString() == "Militar")
            {
                comboBoxSpecializare.Items.Clear();
                comboBoxSpecializare.Items.Add("Militar");
            }
            comboBoxSpecializare.Text = _liceu.Specializare;
        }

        private void comboBoxProfil_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBoxProfil.SelectedItem.ToString() == "Real")
            {
                comboBoxSpecializare.Items.Clear();
                comboBoxSpecializare.Items.Add("Matematica-Informatica");
                comboBoxSpecializare.Items.Add("Stiinte ale naturii");

            }
            if (comboBoxProfil.SelectedItem.ToString() == "Arte plastice si vizuale")
            {
                comboBoxSpecializare.Items.Clear();
                comboBoxSpecializare.Items.Add("Arhitectura");
                comboBoxSpecializare.Items.Add("Arte plastice");
                comboBoxSpecializare.Items.Add("Arte vizuale");

            }
            if (comboBoxProfil.SelectedItem.ToString() == "Artistic")
            {
                comboBoxSpecializare.Items.Clear();
                comboBoxSpecializare.Items.Add("Arhitectura,Arte ambientale si Design");
                comboBoxSpecializare.Items.Add("Arta actorului");
                comboBoxSpecializare.Items.Add("Arte plastice si decorative");
                comboBoxSpecializare.Items.Add("Conservare-restaurare bunuri culturale");
                comboBoxSpecializare.Items.Add("Coregrafie");

            }
            if (comboBoxProfil.SelectedItem.ToString() == "Muzica")
            {
                comboBoxSpecializare.Items.Clear();
                comboBoxSpecializare.Items.Add("Muzica");
            }
            if (comboBoxProfil.SelectedItem.ToString() == "Resurse naturale si protectia mediului")
            {
                comboBoxSpecializare.Items.Clear();
                comboBoxSpecializare.Items.Add("Agricultura");
                comboBoxSpecializare.Items.Add("Industrie alimentara");
                comboBoxSpecializare.Items.Add("Protectia mediului");
                comboBoxSpecializare.Items.Add("Sivicultura");
            }
            if (comboBoxProfil.SelectedItem.ToString() == "Servicii")
            {
                comboBoxSpecializare.Items.Clear();
                comboBoxSpecializare.Items.Add("Comert");
                comboBoxSpecializare.Items.Add("Economic");
                comboBoxSpecializare.Items.Add("Estetica si igiena corpului omenesc");
                comboBoxSpecializare.Items.Add("Turism si alimentatie");
            }
            if (comboBoxProfil.SelectedItem.ToString() == "Sportiv")
            {
                comboBoxSpecializare.Items.Clear();
                comboBoxSpecializare.Items.Add("Sportiv");
            }
            if (comboBoxProfil.SelectedItem.ToString() == "Tehnic")
            {
                comboBoxSpecializare.Items.Clear();
                comboBoxSpecializare.Items.Add("Chimie industriala");
                comboBoxSpecializare.Items.Add("Constructii, instalatii si lucrari publice");
                comboBoxSpecializare.Items.Add("Electric");
                comboBoxSpecializare.Items.Add("Electromecanica");
                comboBoxSpecializare.Items.Add("Electronica automatizari");
                comboBoxSpecializare.Items.Add("Fabricarea produselor din lemn");
                comboBoxSpecializare.Items.Add("Industrie textila si pielarie");
                comboBoxSpecializare.Items.Add("Materiale de constructii");
                comboBoxSpecializare.Items.Add("Mecanica");
                comboBoxSpecializare.Items.Add("Productie media");
                comboBoxSpecializare.Items.Add("Tehnici poligrafice");

            }
            if (comboBoxProfil.SelectedItem.ToString() == "Teologic")
            {
                comboBoxSpecializare.Items.Clear();
                comboBoxSpecializare.Items.Add("Ghid turism religios catolic");
                comboBoxSpecializare.Items.Add("Ghid turism religios ortodox");
                comboBoxSpecializare.Items.Add("Muzica bisericeasca");
                comboBoxSpecializare.Items.Add("Patrimoniu cultural");
                comboBoxSpecializare.Items.Add("Teologie adventista");
                comboBoxSpecializare.Items.Add("Teologie baptista");
                comboBoxSpecializare.Items.Add("Teologie greco-catolica");
                comboBoxSpecializare.Items.Add("Teologie musulmana");
                comboBoxSpecializare.Items.Add("Teologie ortodoxa");
                comboBoxSpecializare.Items.Add("Teologie penticostala");
                comboBoxSpecializare.Items.Add("Teologie reformata");
                comboBoxSpecializare.Items.Add("Teologie romano-catolica");
                comboBoxSpecializare.Items.Add("Teologie unitariana");

            }
            if (comboBoxProfil.SelectedItem.ToString() == "Uman")
            {
                comboBoxSpecializare.Items.Clear();
                comboBoxSpecializare.Items.Add("Filologie");
                comboBoxSpecializare.Items.Add("Stiinte sociale");
            }
            if (comboBoxProfil.SelectedItem.ToString() == "Pedagogic")
            {
                comboBoxSpecializare.Items.Clear();
                comboBoxSpecializare.Items.Add("Bibliotecar documentarist");
                comboBoxSpecializare.Items.Add("Educator - invatator");
                comboBoxSpecializare.Items.Add("Educator - puericultor");
                comboBoxSpecializare.Items.Add("Instructor de educatie extrascolara");
            }
            if (comboBoxProfil.SelectedItem.ToString() == "Militar")
            {
                comboBoxSpecializare.Items.Clear();
                comboBoxSpecializare.Items.Add("Militar");
            }
        }

        private void tbNumeLiceu_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space));
        }

        private void tbMedieLiceu_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsPunctuation(e.KeyChar);
        }
    }
}
