using System;
namespace ifElsePratik
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lutfen bir sayi giriniz: ");
            int sayi = int.Parse(Console.ReadLine());
            if (sayi == 10)
            {
                Console.WriteLine("Girilen Sayi 10'a esittir.");
                
            }
            else if (sayi > 10)
              {
                Console.WriteLine("Girilen sayi 10'dan buyuktur.");
            
              }
            else 
            {
                Console.WriteLine("Girilen Sayi 10'dan kucuktur.");
                
            }
            if (sayi % 2 == 0)
            {
                Console.WriteLine("Girilen sayi cifttir.");
            }
            else {
                Console.WriteLine("Girilen sayi tektir");
            }
            
            
        } 
    }
}
