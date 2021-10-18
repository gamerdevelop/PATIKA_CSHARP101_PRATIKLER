
try{

    Console.WriteLine("Bir sayı giriniz: ");
    int sayi= Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Girmiş olduğunuz sayi: "+ sayi);

}
catch(Exception ex){
     
     Console.WriteLine("Hata: "+ ex.Message.ToString());
}
finally{
    Console.WriteLine("Tamamlandı");
}
