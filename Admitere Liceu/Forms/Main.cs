using Admitere_Liceu.Clase;
using Admitere_Liceu.Forms;
using Microsoft.Data.Sqlite;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
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

        private void serializareXML(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Elev>));
            using (FileStream stream = File.Create("serialized.xml"))
            {
                serializer.Serialize(stream, _elevi);
            }
        }

        private void deserializareXML(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Elev>));
            using (FileStream stream = File.OpenRead("serialized.xml"))
            {
                _elevi = (List<Elev>)serializer.Deserialize(stream);
            }
        }

        private void serializareBinary(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream stream = File.Create("serialized.bin"))
            {
                formatter.Serialize(stream, _elevi);
            }
        }

        private void deserializareBinary(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream stream = File.OpenRead("serialized.bin"))
            {
                _elevi = (List<Elev>)formatter.Deserialize(stream);
                
            }
        }

        private void serializareJSON(object sender, EventArgs e)
        {
            JsonSerializer serializer = new JsonSerializer();

            using (FileStream stream = File.Create("serialized.json"))
            {
                StreamWriter sw = new StreamWriter(stream);
                JsonWriter writer = new JsonTextWriter(sw);
                serializer.Serialize(writer, _elevi);
                writer.Close();
                sw.Close();
            }
        }

        private void deserializareJSON(object sender, EventArgs e)
        {
            using (StreamReader file = File.OpenText("serialized.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                _elevi = (List<Elev>)serializer.Deserialize(file, typeof(List<Elev>));
            }
        }

        private void btnVisualizeElevi_Click(object sender, EventArgs e)
        {
            VizualizareElevi vizualizareElevi = new VizualizareElevi(_elevi);
            vizualizareElevi.ShowDialog();
        }

        // accelerator
        private void Main_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Control && e.KeyCode.ToString()=="O")
            {
                btnVisualizeElevi_Click(sender, e);
            }
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();


            sfd.Filter = "CSV File | *.csv";
            sfd.Title = "export csv";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = File.CreateText(sfd.FileName))
                {
                    writer.WriteLine("\"Nume\" , \"Prenume\" , \"Medie admitere\"");
                    foreach (Elev elev in _elevi)
                    {
                        writer.WriteLine($"{elev.Nume}\",{elev.Prenume}\",{elev.medieElev()}");
                    }
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VizualizareEleviSQLite v1 = new VizualizareEleviSQLite();
            v1.ShowDialog();
        }

        
       

        
        // print doc
        private void btnPrint_Click(object sender, EventArgs e)
        {
            if(printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        private void btnPrintPreview_Click(object sender, EventArgs e)
        {
            printPreviewDialog.ShowDialog();
        }

        private void btnPageSetup_Click(object sender, EventArgs e)
        {
            if (pageSetupDialog.ShowDialog() == DialogResult.OK)
                printDocument.DefaultPageSettings = pageSetupDialog.PageSettings;
        }

        private void printDocument_PrintPage_1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font font = new Font("Times New Roman", 24);

            var pageSettings = e.PageSettings;

            var printAreaHeight = e.MarginBounds.Height;
            var printAreaWidth = e.MarginBounds.Width;

            var marginLeft = e.MarginBounds.Left;
            var marginTop = e.MarginBounds.Top;

            int rowHeight = 40;
            var columnWidth = printAreaWidth / 3;

            var currentY = marginTop;
            while (printIndex < _elevi.Count)
            {
                var currentX = marginLeft;

                e.Graphics.DrawRectangle(
                    Pens.Black,
                    currentX,
                    currentY,
                    columnWidth,
                    rowHeight);

                e.Graphics.DrawString(
                    _elevi[printIndex].Nume,
                    font,
                    Brushes.Black,
                    currentX,
                    currentY
                    );

                currentX += columnWidth;
                e.Graphics.DrawRectangle(
                    Pens.Black,
                    currentX,
                    currentY,
                    columnWidth,
                    rowHeight);

                e.Graphics.DrawString(
                    _elevi[printIndex].Prenume,
                    font,
                    Brushes.Black,
                    new RectangleF(currentX, currentY, columnWidth, rowHeight));

                currentX += columnWidth;
                e.Graphics.DrawRectangle(
                    Pens.Black,
                    currentX,
                    currentY,
                    columnWidth,
                    rowHeight);

                e.Graphics.DrawString(
                   _elevi[printIndex].medieElev().ToString(),
                   font,
                   Brushes.Black,
                   new RectangleF(currentX, currentY, columnWidth, rowHeight));

                currentY += rowHeight;



                printIndex++;

                if (currentY - marginTop + rowHeight > printAreaHeight)
                {
                    e.HasMorePages = true;
                    break;
                }
            }
        }

        private int printIndex = 0;

        private void printDocument_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            printIndex = 0;
        }
    }
}
