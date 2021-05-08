using Admitere_Liceu.Clase;
using Admitere_Liceu.Forms;
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
    public partial class ExamenForm : Form
    {
        public Examen _examen;
        public Elev _elevEx;
        private string connectionString = "Data Source=database.db";
        public ExamenForm()
        {
            InitializeComponent();
            
        }

        private void btnAdaugareExamen_Click(object sender, EventArgs e)
        {
            float notaMate = float.Parse(tbNotaMate.Text.ToString());
            float notaRomana = float.Parse(tbNotaRomana.Text.ToString());
            _examen = new Examen(notaMate, notaRomana);

            tbMedieExamen.Text = _examen.medieExamen().ToString();

            
            
        }

        private void btnNextToExamen_Click(object sender, EventArgs e)
        {
            ElevForm el1 = new ElevForm();
            el1.ShowDialog();
            _elevEx = el1.elev;
         
            
        }

        private void tbNotaMate_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsPunctuation(e.KeyChar);
        }

        private void tbNotaRomana_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsPunctuation(e.KeyChar);
        }

        private void btnEditExamen_Click(object sender, EventArgs e)
        {

            EditExamen el1 = new EditExamen(_examen);
            el1.ShowDialog();
            tbNotaRomana.Text = el1.examen.NotaRomana.ToString();
            tbNotaMate.Text = el1.examen.NotaMatematica.ToString();
            _examen.NotaMatematica = el1.examen.NotaMatematica;
            _examen.NotaRomana = el1.examen.NotaRomana;
            tbMedieExamen.Text = _examen.medieExamen().ToString();


        }

        private void tbNotaMate_Validating(object sender, CancelEventArgs e)
        {
            if (tbNotaMate.Text == "")
            {
                errorProvider.SetError(tbNotaMate, "Introdu nota examenului !");
                e.Cancel = true;
            }
            else if (float.Parse(tbNotaMate.Text) < 1 || float.Parse(tbNotaMate.Text) > 10)
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
    }
}
