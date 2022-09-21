using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prosjek

{
    internal class Program
    {
        static void Main(string[] args)
        {
            // varijable
            int ocjena, zbrojOcjena = 0;
            double prosjek = 0, brojOcjena = 0;

            // zaglavlje aplikacije
            Console.WriteLine("##############################");
            Console.WriteLine("#   Izračunavanje prosjeka   #");
            Console.WriteLine("##############################");
            Console.WriteLine("Za kraj unesi nulu.");
            try
            {
                do
                {
                    // unos ocjene
                    Console.WriteLine("Unesi ocjenu: ");


                    ocjena = Convert.ToInt32(Console.ReadLine());



                    // provjera ispravnosti unosa ocjena
                    if (ocjena <= 5 && ocjena > 1)
                    {
                        // dodavanje ocjene u zbrojOcjena
                        zbrojOcjena += ocjena;

                        // brojanje predmeta
                        brojOcjena++;

                        //izračunavanje prosjeka
                        prosjek = zbrojOcjena / brojOcjena;
                    }
                    else if (ocjena == 1)
                    {
                        prosjek = 1;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Molim upišite ispravnu ocjenu.");
                    }
                }

                while (ocjena != 0);
            }
            catch (Exception greska)
            {
                Console.WriteLine("Neispravan unos, pokušajte ponovno");
                Console.Write("Opis greške" + greska.Message);
                }
            // ispis prosjeka

            Console.WriteLine("Prosjek ocjena je: " + prosjek);

            // kraj aplikacije
            Console.ReadKey();
            
        }
    }
}