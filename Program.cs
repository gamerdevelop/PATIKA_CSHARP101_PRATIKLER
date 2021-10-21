Console.WriteLine("Lütfen bir sayı giriniz =>");
double sayi = Convert.ToDouble(Console.ReadLine());
double a=1,toplam=0;
//1 den başlayarak konsoldan girilen sayıya kadar toplamını alıp ortalamasını alıp konsola yazdıran program.
while(a<=sayi)
{
    toplam+=a;
    a++;
}
Console.WriteLine(toplam/sayi);

//a' dan z' ye kadar bütün harfleri konsola yazdıran program.
char harf='a';
while(harf<='z')
{   
    Console.Write(harf+" ");
    harf++;
}
Console.WriteLine();
Console.WriteLine("***** Foreach *****");

string[] dizim= {"Ahmet", "Engin", "Yunus", "CIVAN","EKER","KAHRAMAN"};
foreach (string item in dizim)
{
    Console.WriteLine(item);   
}
