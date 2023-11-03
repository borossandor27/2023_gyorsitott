using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace async_demo
{
    internal class Program
    {
        //-- https://learn.microsoft.com/en-us/dotnet/csharp/asynchronous-programming/async-scenarios
        /*
         * Process (folyamat vagy program):
         *      A folyamat egy számítógépes program egy példánya, amely végrehajtás alatt áll. 
         *      Tartalmazza a programkódot és az aktuális tevékenységet. Az operációs rendszertől (OS) függően 
         *      egy folyamat több végrehajtási szálból állhat, amelyek párhuzamosan hajtják végre az utasításokat. 
         *      A folyamat alapú többfeladatos munkavégzés lehetővé teszi a Java fordító futtatását egyidejűleg, 
         *      amikor szövegszerkesztőt használ. 
         *      Több folyamat egyetlen CPU-val történő alkalmazásakor a különböző memóriakontextusok közötti kontextusváltást 
         *      használják. Minden folyamat változóinak saját tárhelye van. 
         *      A folyamat a hátértárolón futtatható fájlként jelenik meg.
         * 
         * Thread (szál):
         *      A szál a CPU-használat alapegysége, amely egy programszámlálóból, egy veremből és további regiszterekből áll. 
         *      A szálak és folyamatok megvalósítása operációs rendszerenként eltérő, de minden esetben egy folyamaton belül legalább
         *      egy szálnak kell lenni. 
         *      Több szál is létezhet, amelyek megoszthatják az erőforrásokat, például a memóriát, 
         *      míg a különböző folyamatok nem osztják meg ezeket az erőforrásokat. 
         *      Példa szálakra ugyanabban a folyamatban az automatikus helyesírás-ellenőrzés és a fájl automatikus mentése írás közben. 
         *      A szálak alapvetően olyan folyamatok, amelyek ugyanabban a memóriakörnyezetben futnak. 
         *      A szálak adataikat megoszthatják egymással a végrehajtás során.
         *  
         *  Task (feladat):
         *      A memóriába betöltött utasítások halmaza. A szálak maguk is feloszthatják magukat két vagy több egyidejűleg futó feladatra.
         *      A task lehet egy folyamt része, de van, amikor az egész folyamat szinonimájaként használják
         *      
         *  Mikor használjunk szinkron módszereket?
         *      A szinkron módszerek egyszerű, számításilag kötött műveletekre alkalmasak, amelyek nem tartalmaznak 
         *      IO-hoz kötött feladatokat vagy hosszan tartó műveleteket. Ideálisak akkor is, ha egy meghatározott 
         *      végrehajtási sorrendet kell fenntartani.
         *      
         *  Mikor használjunk aszinkron módszereket?
         *      Aszinkron módszereket kell használni az IO-hoz kötött feladatokhoz, hosszan tartó műveletekhez és 
         *      olyan helyzetekhez, ahol a válaszkészség vagy a skálázhatóság kulcsfontosságú. 
         *      A gyakori példák közé tartoznak a fájlműveletek, a hálózati kérések és a felhasználói felület frissítései
         *      
         *
         */

        static void Main(string[] args)
        {
            Method2();
            Method1();
            Method2();
            Console.ReadKey();
        }

        // Asynchronous method
        public static async Task Method1()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(" Method 1");
                    // Do something
                    Task.Delay(100).Wait();
                }
            });
        }


        // Asynchronous method
        public static void Method2()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(" Method 2");
                // Do something
                Task.Delay(100).Wait();
            }
        }
    }

}
