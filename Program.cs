Console.WriteLine("***** While *****");
Console.Write("Lütfen bir sayı giriniz => ");
double sayi = Convert.ToDouble(Console.ReadLine());
double a=1,toplam=0;
//1 den başlayarak konsoldan girilen sayıya kadar toplamının ortalamasını alıp konsola yazdıran program.
while(a<=sayi)
{
    if(a<sayi)
    Console.Write(a + "+");
    else{
        Console.Write(a);
    }
    toplam+=a;
    a++;
    
}
Console.WriteLine("=" + toplam + " => " + toplam + "/" + sayi+"=" + toplam/sayi);

//a' dan z' ye kadar türkçe karakterler dahil harfleri konsola yazdıran program.
char harf='a';
while(harf<='z')
{   
    
    Console.Write(harf+" ");
    switch (harf)
    {
        case 'c':
            Console.Write("ç ");
        break;
        case 'g':
            Console.Write("ğ ");
        break;
        case 'h':
            Console.Write("ı ");
        break;
        case 'o':
            Console.Write("ö ");
        break;
        case 's':
            Console.Write("ş ");
        break;
        case 'u':
            Console.Write("ü ");
        break;

        default:
        break;
    }
    harf++;
}
Console.WriteLine();
Console.WriteLine("***** Foreach *****");

string[] dizim= {"Ahmet", "Engin", "Yunus"};
foreach (string item in dizim)
{
    Console.WriteLine(item);   
}


