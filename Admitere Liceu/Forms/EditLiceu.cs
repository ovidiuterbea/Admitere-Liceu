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
            _liceu.Specializare = tbSpecializare.Text;
        }

        private void EditLiceu_Load(object sender, EventArgs e)
        {
            tbNumeLiceu.Text = _liceu.NumeLiceu;
            tbMedieLiceu.Text = _liceu.MedieLiceu.ToString();
            tbSpecializare.Text = _liceu.Specializare;
        }
    }
}
