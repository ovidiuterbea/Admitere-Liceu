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
    public partial class VizualizareElevi : Form
    {
        public List<Elev> elevi;
        public VizualizareElevi(List<Elev> elevi)
        {
            InitializeComponent();
            this.elevi = elevi;
        }

        private void VizualizareElevi_Load(object sender, EventArgs e)
        {
            DisplayElevi();
        }
        public void DisplayElevi()
        {
            dgvElevi.Rows.Clear();

            foreach (Elev elev in elevi)
            {
                string numeLiceu;
                Liceu liceuAdmis = new Liceu();

                List<Liceu> sortedLicee = elev.Licee.OrderBy(o => o.MedieLiceu).ToList();

                foreach (Liceu liceu in sortedLicee)
                {

                    if (elev.medieElev() > liceu.MedieLiceu)
                    {
                        liceuAdmis = liceu;

                    }
                }

                if (liceuAdmis.NumeLiceu == null)
                    numeLiceu = "---------";
                else
                    numeLiceu = liceuAdmis.NumeLiceu;
                

                int rowIndex = dgvElevi.Rows.Add(new object[]
                {
                    elev.Nume,
                    elev.Prenume,
                    elev.medieElev(),
                    numeLiceu
                });

                dgvElevi.Rows[rowIndex].Tag = elev;
            }
        }

        private void dgvElevi_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvElevi.SelectedRows[0];
            Elev elev = (Elev)row.Tag;
            Liceu liceuAdmis = new Liceu();
            
            List<Liceu> sortedLicee = elev.Licee.OrderBy(o => o.MedieLiceu).ToList();
            
            foreach (Liceu liceu in sortedLicee)
            {
                
                if (elev.medieElev() > liceu.MedieLiceu)
                {
                    liceuAdmis = liceu;
                    
                }
            }
            if(elev.medieElev() < 6 || elev.Examen.NotaMatematica < 5 || elev.Examen.NotaRomana < 5)
            {
                MessageBox.Show("Din pacate elevul/eleva cu numele " + elev.Nume + " " + elev.Prenume + " nu a trecut examenul de bacalaureat.");
            }
            else if (liceuAdmis.NumeLiceu == null)
            {
                MessageBox.Show("Din pacate elevul cu numele " + elev.Nume + " " + elev.Prenume + " nu a fost admis/admisa la niciun liceu din cele alese. Elevul va fi repartizat aleator.");
            }
            else
                MessageBox.Show("Elevul cu numele " + elev.Nume + " " + elev.Prenume + " a fost admis la liceul " + liceuAdmis.NumeLiceu + "." );
        }
    }
}
