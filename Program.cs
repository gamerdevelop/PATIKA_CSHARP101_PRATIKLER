

int time;

Console.Write("Bir saat giriniz : ");
time = DateTime.Now.Hour;

if(time>14){
    Console.WriteLine("Rojbaş");
}
else if(time<15) {
    Console.WriteLine("Başe baş");
}
else{
    Console.WriteLine("Şevbaş lo!");
}




    

