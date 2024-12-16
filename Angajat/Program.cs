namespace Angajat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Angajat Igor = new Angajat("Igor", 1000, "IT");
            Igor.AfisareDetalii();
            Angajat Gabi = new Angajat("Gabi", 2000, "Marketing");
            Gabi.AfisareDetalii();
            Angajat Victor = new Angajat("Victor", 1200, "Departament Juridic");
            Victor.AfisareDetalii();
        }
    }
}
