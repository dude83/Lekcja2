using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja2
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = 9, b = a / 2;

            //Console.WriteLine($"Wynk dzielena a /2 to {b}");

            //b = 8 / 3;

            //Console.WriteLine($"Wartość bo to {b}");

            // Przykład zaokrąglenia inta w dół. Wyniiem byoby normalnie 4,5 w 1 przypadku
            // i 2,66 w drugim

            // Zadanie 1

            //int a = 8, b = 4, c = 2;

            //int d = a % b % c;

            // Zadanie 2

            //int a = 256 << 2;

            // Przesunięcie bitowe to wielokrotność liczy 2. Czyli przesuwając 256 o 1 bit w lewo to będze 512 (256 * 2),
            // z kolei o 2 bity to 1024(256 * 2 * 2). Z Przesunięciem w prawo jest odwrotnie. Jest to zmniejszenie(256 / 2 / 2).

            // Zadanie 3

            //int i = 15, j = 20;

            //Console.WriteLine(i ^ j);

            //i ^= j;

            //Console.WriteLine(j);

            // Zadanie 4

            //int i = 1;

            // Console.WriteLine(i & 4); // 1 sposob

            //  Zadanie 5

            //int i = 2, b = 4;

            //b = i;

            //Console.WriteLine(b);

            //i = b / 2;

            // Tu miałem zamienć wartości zmiennych pomiędzy sobą. Zrobiłem to tak. Chyba nie do końca dobrze.

            Console.ReadKey();
        }
    }
}
