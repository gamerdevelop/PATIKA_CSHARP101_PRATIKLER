using System;
namespace console_programlama{
    class Program
    {
        static void Main(string[] args){
            
            Console.WriteLine("Adınızı giriniz: ");
            string adi = Console.ReadLine();
            Console.WriteLine("Soyadınızı giriniz: ");
            string soyadi = Console.ReadLine();
            Console.WriteLine("Selam " + adi + " " + soyadi);
        }
        
    }

}

