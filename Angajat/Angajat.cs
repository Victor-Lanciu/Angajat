using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Angajat
{
    public class Angajat
    {
        public string Nume;
        public int Salariu;
        public string Departament;

        public Angajat(string nume, int salariu, string departament)
        {
            this.Nume = nume;
            this.Salariu = salariu;
            this.Departament = departament;
        }
        public void AfisareDetalii()
        {
            Console.WriteLine($"Numele angajatului:{Nume}, Salariul Angajatului: {Salariu}, Departamentul angajatului: {Departament}");
        }
    }
}
