

int time;

Console.Write("Bir saat giriniz : ");
time = DateTime.Now.Hour;

if(time>18){
 Console.WriteLine("Rojbaş");
}
else if(time<18) {
    Console.WriteLine("Başe baş");
}
else{
    Console.WriteLine("Şevbaş lo!");

}
   string sonuc = time>=18 ?  "İyi günler!" : "İyi akşamlar!";
   Console.WriteLine(sonuc);

sonuc = time<19 && time>17 ? "Günaydın" : time>=18 ?  "İyi günler!" : "İyi akşamlar!";

Console.WriteLine(sonuc);






    

