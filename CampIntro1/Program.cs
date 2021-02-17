using System;

namespace CampIntro1
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güvenliği
            //Do not repeat yourself -  Kendini tekrarlama
            //değer tutucu, alias

            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 3200;
            double faizOranı = 1.45;
            bool sistemeGrisYapmisMi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış butonu");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi butonu");
            }

            if ( sistemeGrisYapmisMi ==  true)
            {
                Console.WriteLine("Kulanıcı Ayrları Butonu");



            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }

           Console.WriteLine(kategoriEtiketi);

        }
    }
}
