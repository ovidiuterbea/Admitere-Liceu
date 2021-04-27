﻿using Admitere_Liceu.Clase;
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
            dgvElevi.DataSource = elevi;
        }

        private void dgvElevi_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvElevi.SelectedRows[0];
            Elev elev = (Elev)row.DataBoundItem;
            Liceu liceuAdmis = new Liceu();
            
            List<Liceu> sortedLicee = elev.Licee.OrderBy(o => o.MedieLiceu).ToList();
            //int contor = 0;
            foreach (Liceu liceu in sortedLicee)
            {
                //contor++;
                if (elev.medieElev() > liceu.MedieLiceu)
                {
                    liceuAdmis = liceu;
                    
                }
            }
            if(elev.medieElev() < 6 || elev.Examen.NotaMatematica < 5 || elev.Examen.NotaRomana < 5)
            {
                MessageBox.Show("Din pacate elevul/eleva cu numele " + elev.Nume + " " + elev.Prenume + " nu a trecut examenul de bacalaureat.");
            }
            else if (/*contor == sortedLicee.Count  &&*/ liceuAdmis.NumeLiceu == null)
            {
                MessageBox.Show("Din pacate elevul cu numele " + elev.Nume + " " + elev.Prenume + " nu a fost admis/admisa la niciun liceu din cele alese. Elevul va fi repartizat aleator.");
            }
            else
                MessageBox.Show("Elevul cu numele " + elev.Nume + " " + elev.Prenume + " a fost admis la liceul " + liceuAdmis.NumeLiceu + "." );
        }
    }
}
