using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayiTahminOyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            int uretilenSayi = 0;
            Random random = new Random();
            uretilenSayi = random.Next(1, 5);
            int sayac = 1;

            while (true)
            {
                Console.Write("Tahmininiz: ");
                string s1 = Console.ReadLine();
                int s2 = Convert.ToInt32(s1);
                if (s2 == uretilenSayi)
                {
                    break;
                }
                else
                {
                    sayac++;

                }


            }
            Console.WriteLine(" Bildiniz, Toplam Deneme: " + sayac);
            Console.ReadLine();



        }
            
    }
}
