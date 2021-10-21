
//int sayi = DateTime.Now.Month;
int sayi = 12;

switch(sayi)
 {
    case 1:
    Console.WriteLine("*** OCAK ***");
    break;

    case 2:
    Console.WriteLine("*** ŞUBAT ***");
    break;

    case 3:
    Console.WriteLine("*** MART ***");
    break;

    case 4:
    Console.WriteLine("*** NİSAN ***");
    break;

    case 5:
    Console.WriteLine("*** MAYIS ***");
    break;

    case 6:
    Console.WriteLine("*** HAZİRAN ***");
    break;

    case 7:
    Console.WriteLine("*** TEMMUZ ***");
    break;

    case 8:
    Console.WriteLine("*** AĞUSTOS ***");
    break;

    case 9:
    Console.WriteLine("*** EYLÜL ***");
    break;

    case 10:
    Console.WriteLine("*** EKİM *** ");
    break;

    case 11:
    Console.WriteLine("*** KASIM ***");
    break;

    case 12:
    Console.WriteLine("*** ARALIK ***");
    break;

    default:
    Console.WriteLine("Hangi gezegenden geliyorsun!");
    break;
 }
  
    switch (sayi)
    {
        
        case 1:
        case 2:
        case 3:
        case 4:
        Console.WriteLine("KIŞ MEVSİMİNDESİNİZ");
        break;

        case 5:
        case 6:
        Console.WriteLine("İLKBAHAR MEVSİMİNDESİNİZ");
        break;

        case 7:
        case 8:
        case 9:
        Console.WriteLine("YAZ MEVSİMİNDESİNİZ");
        break;

        case 10:
        case 11:
        case 12:
        Console.WriteLine("SONBAHAR MEVSİMİNDESİNİZ");
        break;
        
    }
