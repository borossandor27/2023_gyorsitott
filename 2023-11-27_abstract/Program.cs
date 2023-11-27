using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_11_27_abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Sikidom> sikidomok=new List<Sikidom>();
            sikidomok.Add(new Negyzet("négyzet", 3.5));
            sikidomok.Add(new Teglalap("teglalap", 2.8, 7.2));
            sikidomok.Add(new Negyzet("négyzet", 3.6));
            sikidomok.Add(new Teglalap("teglalap", 4.0, 5.2));

            double osszesKerulet = 0;
            foreach (var item in sikidomok)
            {
                if (item.GetType()==typeof(Negyzet))
                {
                    Negyzet listabaHelyezettObjectum = (Negyzet)item;
                    Console.WriteLine($"{listabaHelyezettObjectum.oldal} oldalú négyzet kerülete: {listabaHelyezettObjectum.Kerulet()}");
                }
                else if(item.GetType()==typeof(Teglalap))
                {
                    Teglalap listabaHelyezettObjectum = (Teglalap)item;
                    Console.WriteLine($"{listabaHelyezettObjectum.oldalA} - {listabaHelyezettObjectum.oldalB} oldalú téglalap kerülete: {listabaHelyezettObjectum.Kerulet()}");
                }
                osszesKerulet += item.Kerulet();
            }
            Console.WriteLine($"Összesen: {osszesKerulet}");

            Console.WriteLine("\nProgram vége!");
            Console.ReadLine();
        }
    }
}
