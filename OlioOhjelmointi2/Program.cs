using System;

namespace OlioOhjelmointi2

{
    class Kirjasto
    {
        public string kirjanTyyppi { get; set; }
        public int sivujenMäärä { get; set; }
        public int painoVuosi { get; set; }
        public string kirjanKieli { get; set; }
        public bool luettu { get; set; }

        public void kirjaLuettu()
        {
            luettu = true;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tervetuloa kirjastoon!");

            Kirjasto eka = new Kirjasto();
            Kirjasto toka = new Kirjasto();

            eka.kirjanTyyppi = "tietokirja";
            eka.sivujenMäärä = 185;
            eka.painoVuosi = 1985;
            eka.kirjanKieli = "suomi";
            eka.luettu = false;

            toka.kirjanTyyppi = "romaani";
            toka.sivujenMäärä = 258;
            toka.painoVuosi = 2005;
            toka.kirjanKieli = "suomi";
            toka.luettu = true;

        }
    }
}
