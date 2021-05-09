using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admitere_Liceu.Clase
{
    public class Elev
    {
        public long ID { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string CNP { get; set; }

        
        public String Adresa { get; set; }
        public String Sex { get; set; }

        public float MediePeScGenerala { get; set; }

        public Examen Examen { get; set; }

        public List<Liceu> Licee { get; set; }
        public DateTime ZiDeNastere { get; set; }
        public double MedieFinalaForSQL { get; set; }

        public Elev()
        {
            Licee = new List<Liceu>();
        }


        public Elev(string name,string prenume, string sex, string address,DateTime dateTime,float medie,string cnp)
        {
            Nume = name;
            Prenume = prenume;
            Licee = new List<Liceu>();
            Sex = sex;
            MediePeScGenerala = medie;
            Adresa = address;
            ZiDeNastere = dateTime;
            CNP = cnp;


        }

        public Elev(string name, string prenume, string sex, string address, DateTime dateTime,List<Liceu> licee,Examen examen,float medie,string cnp)
            : this(name,prenume,sex,address, dateTime,medie,cnp)
        {
            Licee.AddRange(licee);
            Examen = examen;
        }

        public Elev(long id,string nume,string prenume,double medie)
        {
            this.ID = id;
            this.Nume = nume;
            this.Prenume = prenume;
            this.MedieFinalaForSQL = medie;
        }


        public float medieElev()
        {
            float medieExamen = Examen.medieExamen();

            float medieAdmitere = medieExamen * 0.8f + MediePeScGenerala * 0.2f;

            return medieAdmitere;
        }
    }

}
