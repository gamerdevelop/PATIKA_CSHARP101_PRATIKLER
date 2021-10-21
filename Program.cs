Console.Write("Bir sayı giriniz => ");

int sayi = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i <= sayi; i++)
{
    if (i % 2==1){
        Console.Write(i + " ");
    }    
}
Console.WriteLine();
int ciftToplam=0,tekToplam=0;
for (int i = 0; i <= 1000; i++)
{
    if(i%2==0){
        ciftToplam+=i;
    }
    else{
        tekToplam+=i;
    }
    if(i==5){
        break;
    }
    

}
Console.WriteLine("Tek sayıların toplamı => "+ tekToplam);
Console.WriteLine("Çift sayıların toplamı => "+ ciftToplam);