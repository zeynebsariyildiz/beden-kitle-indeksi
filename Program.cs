using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beden_kitle_indeksi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adınızı giriniz:");
            Console.ReadLine();
            Console.WriteLine ("Kilonuzu Giriniz");
            int kilo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Boyunuzu Giriniz");
            double boy =  Convert.ToDouble(Console.ReadLine());

            double bke = kilo / (boy * boy);

            if (bke < 18)
            {
                Console.WriteLine("Zayıfsınız...");
                Console.ReadLine();
            }
            else if (bke > 18 && bke < 25)
            {
                Console.WriteLine("Normalsiniz...");
                Console.ReadLine();
            }

            else if (bke > 25)
            {
                Console.WriteLine("Obezsiniz...");
            }        Console.ReadLine(); 
            }
    }
}
