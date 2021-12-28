using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doWhileProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 ile 10 arasında bir tane sayı giriniz: ");
            string s1 = Console.ReadLine();
            int s2 = int.Parse(s1);


            Random random = new Random();
            int s3 = 0;
            int sayac = 0;
            do
            {
                Console.Write("Yanlış Tahmin Tekrar: \n");
                s3 = random.Next(1, 10);
                sayac++;


            } while (s2 != s3);
            Console.WriteLine(sayac + " kere denediniz başardınız.");
            Console.ReadLine();
        }
    }
}
