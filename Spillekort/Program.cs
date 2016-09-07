using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpillekortNameSpace
{
    class CSDemo
    {
        public static void Main()
        {
            //Hjerter dame
            //bla bla
            //SpilleKort Kort1 = new SpilleKort();
            //Kort1.Farve = SpilleKort_Farve.Hjerter;
            //Kort1.Værdi = 12;
            //Console.WriteLine(Kort1.Info());

            ////Spar 5
            //SpilleKort Kort2 = new SpilleKort();
            //Kort2.Farve = SpilleKort_Farve.Spar;
            //Kort2.Værdi = 5;
            //Console.WriteLine(Kort2.Info());

            CanastaSpillekort Kort1 = new CanastaSpillekort();
            Kort1.Farve = SpilleKort_Farve.Spar;
            Kort1.Værdi = 14;
            Console.WriteLine(Kort1.Info());
            Console.WriteLine("Er es: {0}", Kort1.ErEs());
            Console.WriteLine("Er billedkort: {0}", Kort1.ErBilledKort());
            Console.WriteLine("Er vildkort: {0}", Kort1.ErVildkort());
        }
    }

    public enum SpilleKort_Farve
    { // Repræsentere et spillekorts farve (samt joker)
    Joker = 0,
    Spar = 1,
    Hjerter = 2,
    Ruder = 3,
    Klør = 4,
    }

    public class SpilleKort
    {
        private SpilleKort_Farve _Farve;
        private byte _Værdi;

        public byte Værdi
        {
            get
            {
                return _Værdi;
            }
            set
            {
                if (value >= 1 & value <= 14)
                    _Værdi = value;
                else
                    throw new Exception("Forkert værdi");
            }
        }

        public SpilleKort_Farve Farve
        {
            get
            {
                return _Farve;
            }
            set
            {
                _Farve = value;
            }
        }

        //ErEs fortæller om kortet er et Es (1 eller 14)
        public bool ErEs()
        {
            if (_Værdi == 1)
                return true;
            else
                return false;
        }

        // ErJoker returnerer true, hvis kortet er joker (15)
        public bool ErJoker()
        {
            if (_Værdi == 14)
                return true;
            else
                return false;
        }

        // ErBilledkort returnerer true, hvis kortet er en knægt, dame eller konge
        public bool ErBilledKort()
        {
            switch (Værdi)
            {
                case 11:
                    return true;
                case 12:
                    return true;
                case 13:
                    return true;
                default:
                    return false;
            }
        }

        public string Info()
        {
            return _Farve.ToString() + " " + _Værdi;
        }
    }

    public class CanastaSpillekort : SpilleKort
    {
        public bool ErVildkort()
        {
            if (Værdi == 2 | Værdi == 14)
                return true;
            else
                return false;
        }
    }
}
