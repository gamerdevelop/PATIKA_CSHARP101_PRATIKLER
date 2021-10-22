//Sort

int[] sayiDizisi= {23,12,4,86,72,3,11,17};
Console.WriteLine("**** Sırasız Dizi ****");
foreach (int item in sayiDizisi)
{
    Console.Write(item+" ");
}
Console.WriteLine("");
Console.WriteLine("***** Sıralı Dizi *****");
Array.Sort(sayiDizisi);

foreach (int item in sayiDizisi)
{
    Console.Write(item + " ");
}
//Clear
Console.WriteLine("");
Console.WriteLine("***** Array Clear *****");

Array.Clear(sayiDizisi,2,2);  //sayiDizisi'nde 2.indexten başlayarak 2 elemanı 0'lar.
foreach (int item in sayiDizisi)
{
    Console.Write(item + " ");
}
//Reverse
Console.WriteLine("");
Console.WriteLine("***** Array Reverse *****");

Array.Reverse(sayiDizisi); //Diziyi ters çevirir.
foreach (int item in sayiDizisi)
{
    Console.Write(item + " ");
}

//IndexOf
Console.WriteLine("");
Console.WriteLine("***** Array IndexOf *****");

Console.WriteLine(Array.IndexOf(sayiDizisi,4)); //Dizideki bir elemanın index'ini verir.

//Resize
Console.WriteLine("***** Array Resize *****");
Array.Resize<int>(ref sayiDizisi,9);
sayiDizisi[8] = 77;
Console.WriteLine(sayiDizisi[8]);

