using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ortalama Hesaplama Programına Hoşgeldin, Robot Olmadığını Doğrulamak için narkoz Yaz! ");
            Console.WriteLine();
            string doğrulama = Console.ReadLine();
            string isim = "narkoz";
            Console.WriteLine();
            if (doğrulama == isim ) 
            {
                Console.WriteLine("Başarılı Giriş :)");
               
            }
            ssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssss
           else
            {
                Console.WriteLine("Başarısız  Giriş :(");
                
            }
            Console.WriteLine();
            Console.WriteLine("**** Not 1 **** ");
            string not1 = Console.ReadLine();
            int a = int.Parse(not1);

            Console.WriteLine();
            Console.WriteLine("****Not 2 **** ");
            string not2 = Console.ReadLine();
            int b = int.Parse(not2);

            Console.WriteLine();
            int sonuc = (a + b) / 2;
            Console.WriteLine("Ortalamanız : " + sonuc);
            Console.WriteLine();

            if (sonuc<50)
            {
                Console.WriteLine("G.O Kaldın");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Uwuu Zeki Ğ ");
                Console.ReadLine();
            }
        }
    }
}
