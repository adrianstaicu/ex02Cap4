using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex02Cap4
{
    class Program
    {
        static void Main(string[] args)
        {

            //Create un obiect / clasa Imobil ce contine variabilele: tipCasa de tip String (apartament, casa, vila etc), nrEtaje de tip int, pret de tip double. 
            //Declarati variabilele, metodele accesor set si get si constructori care sa va ajute la crearea instantelor acestui obiect. 
            //Apelati clasa Imobil in Program.cs sau o clasa cu metoda Main, utilizand constructorii si metodele set si get din clasa Imobil.

            Imobil casa = new Imobil();
            casa.tipCasa = "Aparament decomandat";
            casa.nrEtaje = 1;
            casa.pret = 70000;

            Console.WriteLine();
            Console.WriteLine("Oferta pentru : " + casa.tipCasa + " etajul " + casa.nrEtaje + " are pretul de " + casa.pret + " euro");


            Imobil casa2 = new Imobil("casa");
            casa2.nrEtaje = 3;
            casa2.pret = 90000;

            Console.WriteLine();
            Console.WriteLine("Oferta pentru: " + casa2.tipCasa + " etajul " + casa2.nrEtaje + " are pretul de " + casa2.pret + " euro");

            Imobil casa3 = new Imobil("penthouse", 4, 240000);
            Console.WriteLine();
            Console.WriteLine("Oferta pentru : " + casa3.tipCasa + " etajul " + casa3.nrEtaje + " are pretul de " + casa3.pret + " euro");

            Console.ReadKey();
        }
    }
}
