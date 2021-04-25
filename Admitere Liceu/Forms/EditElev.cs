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
    }
}
