using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admitere_Liceu.Clase
{
    public class Examen
    {
        public long ID { get; set; }
        public float NotaMatematica { get; set; }
        public float NotaRomana { get; set; }

        public Examen()
        {

        }

        public Examen(float notaMate, float notaRomana)
        {
            NotaMatematica = notaMate;
            NotaRomana = notaRomana;
        }

        public float medieExamen()
        {
            return (NotaMatematica + NotaRomana) / 2;
        }
    }
}
