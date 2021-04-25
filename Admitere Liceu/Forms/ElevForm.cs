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
    public partial class ElevForm : Form
        
    {
        public Elev elev;
        public ElevForm()
        {
            InitializeComponent();
            elev = new Elev();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string numeElev = tbNumeElev.Text;
            string prenumeElev = tbPrenumeElev.Text;
            string adresaElev = tbAdresaElev.Text;
            string sexElev = tbSexElev.Text;
            float medieScElev = float.Parse(tbMedieSc.Text);
            DateTime dataNasterii = tbDataNasterii.Value;
            string cnpElev = tbCNP.Text;

            Elev elevCopie = new Elev(numeElev, prenumeElev, sexElev, adresaElev, dataNasterii,medieScElev,cnpElev);

            elev = elevCopie;

            MessageBox.Show("Elevul cu numele " + numeElev + " " + prenumeElev + " a fost adaugat.");
        }

        private void btnEditElev_Click(object sender, EventArgs e)
        {
            EditElev eEl1 = new EditElev(elev);
            eEl1.ShowDialog();
            tbAdresaElev.Text= eEl1.elev.Adresa;
            tbCNP.Text = eEl1.elev.CNP;
            tbDataNasterii.Value = eEl1.elev.ZiDeNastere;
            tbNumeElev.Text = eEl1.elev.Nume;
            tbPrenumeElev.Text = eEl1.elev.Prenume;
            tbSexElev.Text = eEl1.elev.Sex;
            tbMedieSc.Text = eEl1.elev.MediePeScGenerala.ToString();
        }

        private void tbNumeElev_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back));
        }

        private void tbPrenumeElev_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back));
        }

        private void tbMedieSc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsPunctuation(e.KeyChar);
        }

        private void tbCNP_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tbNumeElev_Validating(object sender, CancelEventArgs e)
        {
            if (tbNumeElev.Text.Length < 3)
            {
                errorProvider.SetError(tbNumeElev, "Nume prea scurt !");
                e.Cancel = true;
            }
        }

        private void tbNumeElev_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(tbNumeElev, null);
        }

        private void tbPrenumeElev_Validating(object sender, CancelEventArgs e)
        {
            if (tbPrenumeElev.Text.Length < 3)
            {
                errorProvider.SetError(tbPrenumeElev, "Prenume prea scurt !");
                e.Cancel = true;
            }
        }

        private void tbPrenumeElev_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(tbPrenumeElev, null);
        }

        private void tbDataNasterii_Validating(object sender, CancelEventArgs e)
        {
            DateTime birthDate = tbDataNasterii.Value;
            int age = DateTime.Now.Year - birthDate.Year;
            if (birthDate >= DateTime.Today)
            {
                errorProvider.SetError(tbDataNasterii, "Zi de nastere invalida !");
                e.Cancel = true;
            }

            if(age < 13)
            {
                errorProvider.SetError(tbDataNasterii, "Varsta prea mica pentru a intra la liceu ! ");
                e.Cancel = true;
            }
        }

        private void tbDataNasterii_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(tbDataNasterii, null);
        }

        private void tbCNP_Validating(object sender, CancelEventArgs e)
        {
            // 13 caractere
        }

        private void tbCNP_Validated(object sender, EventArgs e)
        {

        }
    }
}
