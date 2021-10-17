// Atama ve İşlemli atama
int x = 5;
int y = 5;
y =y+3;

Console.WriteLine(y);
y +=2;
Console.WriteLine(y);
y/=1;
Console.WriteLine(y);
x *=2;
Console.WriteLine(x);

// Mantıksal Operatörler => ||, &&, !

bool isSuccess = true;
bool isComplated=false;

if(isSuccess && isComplated){
Console.WriteLine("Perfect");
}
if(isSuccess || isComplated){
Console.WriteLine("Great");
}
if(isSuccess &&  !isComplated){
Console.WriteLine("Fine!");
}

//İlişkisel Operatörler =>  <, >, <=, >=, ==, !=

int a = 3;
int b = 4;
bool sonuc= a<b;
Console.WriteLine(sonuc);
sonuc = a>b;
Console.WriteLine(sonuc);
sonuc = a<=b;
Console.WriteLine(sonuc);
sonuc = a>=b;
Console.WriteLine(sonuc);
sonuc = a!=b;
Console.WriteLine(sonuc);
sonuc = a==b;
Console.WriteLine(sonuc);

Console.WriteLine("******** Aritmetik Operatörler =>   *, +, -, / *********"); 

int sayi1 =10;
int sayi2 =6;
int sonuc1=sayi1+sayi2;
Console.WriteLine(sonuc1);
sonuc1=sayi1-sayi2;
Console.WriteLine(sonuc1);
sonuc1=sayi1*sayi2;
Console.WriteLine(sonuc1);
sonuc1=sayi1/sayi2;
Console.WriteLine(sonuc1);
 

// %(mod) => İŞARETİ KALANI BULMAK İÇİN KULLANILIR.

sonuc1= sayi1%sayi2;
Console.WriteLine(sonuc1);