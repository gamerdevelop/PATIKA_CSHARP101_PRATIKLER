
//dizi tanımlama

string[] renkler = new string[5];

string[] hayvanlar= {"Kedi","Köpek","Kuş","Maymun"};

int[] dizi;
dizi = new int[6];

//dizilere değer atama ve Erişim

renkler[0]= "Mavi";
Console.WriteLine(hayvanlar[2]);
dizi[3]=9;
Console.WriteLine("Renk = "+renkler[0]+ "| Evcil Hayvan = "+hayvanlar[2]+ "| Sevdiğim Sayı = "+dizi[3]);

//Dizilerle döngü kullanımı

//klavyeden girilen n tane sayının aritmetik ortalamasını alan program

Console.WriteLine("Dizi kaç elemanlı olsun? => ");
int n =Convert.ToInt32(Console.ReadLine());
int[] elemanlar = new int[n];
int toplam=0;
for (int i = 0; i < n; i++)
{
    Console.Write(i+1 + ".Elemanı girin=> ");
    int a = Convert.ToInt32(Console.ReadLine());
    elemanlar[i]= a; 
    toplam +=a;
}

Console.WriteLine("Dizinin aritmetik ortalaması => "+ toplam+"/"+"2 = "+ toplam/2);
