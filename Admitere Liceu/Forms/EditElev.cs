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
    public partial class EditElev : Form
    {
        public Elev elev;
        public EditElev(Elev elev)
        {
            InitializeComponent();
            this.elev = elev;
        }


        private void btnOk_Click(object sender, EventArgs e)
        {
            elev.Adresa = tbAdresaElev.Text;
            elev.CNP = tbCNP.Text;
            elev.Nume = tbNumeElev.Text;
            elev.Prenume = tbPrenumeElev.Text;
            elev.ZiDeNastere = tbDataNasterii.Value;
            elev.MediePeScGenerala = float.Parse(tbMedieSc.Text);
            elev.Sex = tbSexElev.Text;
        }

        private void EditElev_Load(object sender, EventArgs e)
        {
            tbAdresaElev.Text = elev.Adresa;
            tbCNP.Text = elev.CNP;
            tbDataNasterii.Value = elev.ZiDeNastere;
            tbMedieSc.Text = elev.MediePeScGenerala.ToString();
            tbNumeElev.Text = elev.Nume;
            tbPrenumeElev.Text = elev.Prenume;
            tbSexElev.Text = elev.Sex;
        }

        private void tbNumeElev_Validating(object sender, CancelEventArgs e)
        {
            if (tbNumeElev.Text.Length < 3)
            {
                errorProvider.SetError(tbNumeElev, "Nume prea scurt !");
                e.Cancel = true;
            }
            if (tbNumeElev.Text == "")
            {
                errorProvider.SetError(tbNumeElev, "Adaugati numele !");
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
            if (tbPrenumeElev.Text == "")
            {
                errorProvider.SetError(tbPrenumeElev, "Adaugati numele !");
                e.Cancel = true;
            }
        }

        private void tbPrenumeElev_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(tbPrenumeElev, null);
        }

        private void tbMedieSc_Validating(object sender, CancelEventArgs e)
        {
            if(float.Parse(tbMedieSc.Text) < 1 || float.Parse(tbMedieSc.Text) > 10)
            {
                errorProvider.SetError(tbMedieSc, "Nota invalida !");
                e.Cancel = true;
            }
        }

        private void tbMedieSc_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(tbMedieSc, null);
        }

        private void tbCNP_Validating(object sender, CancelEventArgs e)
        {
            if (tbCNP.Text.Length != 13)
            {
                errorProvider.SetError(tbCNP, "CNP invalid !");
                e.Cancel = true;
            }
        }

        private void tbCNP_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(tbCNP, null);
        }

        private void tbNumeElev_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back));
        }

        private void tbPrenumeElev_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back));
        }

        private void tbCNP_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tbMedieSc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsPunctuation(e.KeyChar);
        }
    }
}
