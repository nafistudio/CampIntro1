using System;

namespace Donguler
{
    class Program
    {    //i++ iden başla birer birer arttır 
        static void Main(string[] args)
        {
            string kurs1 = "yazılımcı geliştirme kampı";
            string kurs2 = "programlamaya giriş";
            string kurs3 = "java";
            string kurs4 = "python";

            //array - dizi

            string[ ] kurslar = new string[] { "yazılımcı geliştirme kampı", "programlamaya giriş",
                "java", "python", "c#" };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]); 
            }

            Console.WriteLine("for bitti");

            //aşağıdaki kurs her bir elemanı dolaşırken verdiğimiz takma isim

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("sayfa sonu - footer");
        }
    }
}
