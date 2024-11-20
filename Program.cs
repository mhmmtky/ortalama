// 3 tane dersin not ortalaması alınacak ortalama değerin 50 üstü geçecek altı kalacak

int not1 ;
int not2 ;
int not3 ;

Console.WriteLine("İlk notu giriniz:");
    not1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("İkinci notu giriniz:");
    not2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Üçüncü notu giriniz:");
    not3 = Convert.ToInt32(Console.ReadLine());

int ort = (not1+not2+not3)/3;
if (ort>=50){
        Console.WriteLine("GEÇTİ");
}
else if(ort<50){
    Console.WriteLine("KALDI");
}
