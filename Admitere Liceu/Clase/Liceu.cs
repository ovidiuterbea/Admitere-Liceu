using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admitere_Liceu.Clase
{
    public class Liceu
    {
        public string NumeLiceu { get; set; }

        public float MedieLiceu { get; set; }
        public string Specializare { get; set; }
        public string Profil { get; set; }

       

        public Liceu()
        {

        }

        public Liceu(string numeLiceu, float medieLiceu, string specializare,string profil)
        {
            NumeLiceu = numeLiceu;

            MedieLiceu = medieLiceu;
            Specializare = specializare;
            Profil = profil;
        }
    }
    class LiceuEqualityComparer : IEqualityComparer<Liceu>
    {
        public bool Equals(Liceu x, Liceu y)
        {
            
            return x.NumeLiceu == y.NumeLiceu;
        }

        public int GetHashCode(Liceu obj)
        {
            return obj.NumeLiceu.GetHashCode();
        }
    }
}
