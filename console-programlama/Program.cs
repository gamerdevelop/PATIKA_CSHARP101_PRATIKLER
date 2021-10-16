using System;
namespace console_programlama{
    class Program
    {
        static void Main(string[] args){
            
            Console.WriteLine("Adınızı giriniz: ");
            string name = Console.ReadLine();
            Console.WriteLine("Soyadınızı giriniz: ");
            string surname = Console.ReadLine();
            Console.WriteLine("Selam " + name + " " + surname);
            Console.ReadKey();
        }
        
    }

}

