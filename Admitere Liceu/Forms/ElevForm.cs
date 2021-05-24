using Admitere_Liceu.Clase;
using Microsoft.Data.Sqlite;
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
        private string connectionString = "Data Source=database.db";
        public Examen examen;
        public ElevForm(Examen examen)
        {
            InitializeComponent();
            elev = new Elev();
            this.examen = examen;
        }

        private void AddElev(Elev elevdb)
        {
            string query = "INSERT INTO Elev(NUME, PRENUME, MEDIE_ADMITERE,ID_EXAMEN ) VALUES(@nume, @prenume, @medie, @id_examen); SELECT last_insert_rowid()";

            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                elevdb.Examen = new Examen(examen.NotaMatematica, examen.NotaRomana);

                elevdb.Examen.ID = examen.ID;
                
                
                SqliteCommand command = new SqliteCommand(query, connection);
                command.Parameters.AddWithValue("@nume", elevdb.Nume);
                command.Parameters.AddWithValue("@prenume", elevdb.Prenume);
                command.Parameters.AddWithValue("@medie", elevdb.medieElev());
                command.Parameters.AddWithValue("@id_examen", elevdb.Examen.ID);
                connection.Open();

                long id = (long)command.ExecuteScalar();
                elevdb.ID = id;

                elev = elevdb;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string numeElev = tbNumeElev.Text;
            string prenumeElev = tbPrenumeElev.Text;
            string adresaElev = tbAdresaElev.Text;
            string sexElev = comboBoxSex.Text;
            float medieScElev = float.Parse(tbMedieSc.Text);
            DateTime dataNasterii = tbDataNasterii.Value;
            string cnpElev = tbCNP.Text;

            Elev elevCopie = new Elev(numeElev, prenumeElev, sexElev, adresaElev, dataNasterii,medieScElev,cnpElev);

            AddElev(elevCopie);

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
            comboBoxSex.Text = eEl1.elev.Sex;
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
            if(tbCNP.Text.Length != 13)
            {
                errorProvider.SetError(tbCNP, "CNP invalid !");
                e.Cancel = true;
            }
        }

        private void tbCNP_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(tbCNP, null);
        }

        private void ElevForm_Load(object sender, EventArgs e)
        {
            comboBoxSex.Items.Add("Masculin");
            comboBoxSex.Items.Add("Feminin");
        }
    }
}
