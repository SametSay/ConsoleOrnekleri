using System;

namespace Kampİntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güvenliği
            //Do not repeat yourself - Kendini tekrarlama
            //değer tutucu, alias
            
            string kategoriEtiketi = "Katagori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.55;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış butonu");
            }
            else if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("değişmedi butonu");
            }
            //Console.WriteLine(kategoriEtiketi);
            //Console.ReadLine();
        }
    }
}
