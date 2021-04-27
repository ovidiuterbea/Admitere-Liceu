using Admitere_Liceu.Clase;
using Admitere_Liceu.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Admitere_Liceu
{
    public partial class Main : Form
    {
        public List<Liceu> _liceeMain;
        public Elev _elevConst;
        public Elev _elevMain;
        public Examen _examenMain;
        public List<Elev> _elevi;
        public Main()
        {
            InitializeComponent();
            _liceeMain = new List<Liceu>();
            _examenMain = new Examen();
            _elevConst = new Elev();
            _elevi = new List<Elev>();
        }

        private void btnInscriere_Click(object sender, EventArgs e)
        {
            LiceuForm l1 = new LiceuForm();
            l1.ShowDialog();
            _liceeMain.AddRange(l1._liceeBune);
            _examenMain = l1._examen;
            _elevConst = l1._elev;

            _elevMain = new Elev(_elevConst.Nume, _elevConst.Prenume, _elevConst.Sex, _elevConst.Adresa, _elevConst.ZiDeNastere, _liceeMain, _examenMain,_elevConst.MediePeScGenerala,_elevConst.CNP);
            _elevi.Add(_elevMain);


        }

        private void serializareToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Elev>));
            using (FileStream stream = File.Create("serialized.xml"))
            {
                serializer.Serialize(stream, _elevi);
                //serializer.Serialize(stream, _examenMain);
            }
        }
    }
}
