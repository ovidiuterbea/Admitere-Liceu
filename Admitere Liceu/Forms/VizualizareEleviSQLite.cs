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
    public partial class VizualizareEleviSQLite : Form
    {
        private string connectionString = "Data Source=database.db";
        List<Elev> _elevi = new List<Elev>();
        public VizualizareEleviSQLite()
        {
            InitializeComponent();
        }

        private void LoadElevi()
        {
            string query = "SELECT * FROM Elev";

            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                SqliteCommand command = new SqliteCommand(query, connection);

                connection.Open();
                using (SqliteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        long id = (long)reader["ID"];
                        string nume = (string)reader["NUME"];
                        string prenume = (string)reader["PRENUME"];
                        double medieAdmitere = (double)reader["MEDIE_ADMITERE"];

                        Elev elev = new Elev(id, nume, prenume,medieAdmitere);
                        _elevi.Add(elev);
                    }
                }
            }
        }

        private void UpdateElevi()
        {
            string query = "Update Elev set MEDIE_ADMITERE = @medie where ID = @id";

            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                SqliteCommand command = new SqliteCommand(query, connection);
                command.Parameters.AddWithValue("@medie", tbMedie.Text);
                command.Parameters.AddWithValue("@id", tbID.Text);

                connection.Open();

                int i = command.ExecuteNonQuery();

                if (i == 1)
                {
                    MessageBox.Show("Medie schimbata cu succes !");
                }



            }
        }
        private void DeleteElevi()
        {
            string query = "Delete from Elev where ID = @id";

            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                SqliteCommand command = new SqliteCommand(query, connection);
                command.Parameters.AddWithValue("@id", tbIDDelete.Text);

                connection.Open();

                int i = command.ExecuteNonQuery();

                if (i == 1)
                {
                    MessageBox.Show("Rand sters cu succes !");
                }



            }
        }

        public void DisplayElevi()
        {
            dgvEleviSQLite.Rows.Clear();

            foreach (Elev elev in _elevi)
            {
                int rowIndex = dgvEleviSQLite.Rows.Add(new object[]
                {
                    elev.ID,
                    elev.Nume,
                    elev.Prenume,
                    elev.MedieFinalaForSQL
                });

                dgvEleviSQLite.Rows[rowIndex].Tag = elev;
            }
        }

        private void VizualizareEleviSQLite_Load(object sender, EventArgs e)
        {
            LoadElevi();
            DisplayElevi();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateElevi();
            
            DisplayElevi();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteElevi();
            
            DisplayElevi();
        }
    }
}
