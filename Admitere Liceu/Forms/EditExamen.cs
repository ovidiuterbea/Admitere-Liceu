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
    public partial class EditExamen : Form
    {
        public Examen examen;
        public EditExamen(Examen examen)
        {
            InitializeComponent();
            this.examen = examen;
        }

        private void EditExamen_Load(object sender, EventArgs e)
        {
            tbNotaMate.Text = examen.NotaMatematica.ToString();
            tbNotaRomana.Text = examen.NotaRomana.ToString();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            examen.NotaMatematica = float.Parse(tbNotaMate.Text);
            examen.NotaRomana = float.Parse(tbNotaRomana.Text);
        }

        private void tbNotaMate_Validating(object sender, CancelEventArgs e)
        {
            if(tbNotaMate.Text == "")
            {
                errorProvider.SetError(tbNotaMate,"Introdu nota examenului !");
                e.Cancel = true;
            }
            else if( float.Parse(tbNotaMate.Text) < 1 || float.Parse(tbNotaMate.Text) > 10)
            {
                errorProvider.SetError(tbNotaMate, "Introdu o nota valida !");
                e.Cancel = true;
            }
            
        }

        private void tbNotaMate_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(tbNotaMate, null);
        }

        private void tbNotaRomana_Validating(object sender, CancelEventArgs e)
        {
            if (tbNotaRomana.Text == "")
            {
                errorProvider.SetError(tbNotaRomana, "Introdu nota examenului !");
                e.Cancel = true;
            }
            else if (float.Parse(tbNotaRomana.Text) < 1 || float.Parse(tbNotaRomana.Text) > 10)
            {
                errorProvider.SetError(tbNotaRomana, "Introdu o nota valida !");
                e.Cancel = true;
            }
        }

        private void tbNotaRomana_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(tbNotaRomana, null);
        }

        private void tbNotaMate_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsPunctuation(e.KeyChar);
        }

        private void tbNotaRomana_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsPunctuation(e.KeyChar);
        }
    }
}
