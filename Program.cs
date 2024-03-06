


Console.WriteLine("Ogrenci sayisini giriniz : ");       
int ogrenciSayisi = Convert.ToInt32(Console.ReadLine());     //ogrenci sayisi aliniyor

double toplamNot = 0;
double sinifOrtalama; 

for(int i = 1;i <= ogrenciSayisi;i++)
{
    Console.WriteLine(i + " numarali ogrencinin bilgilerini girin");

    Console.WriteLine("Ogrencinin adi: ");
    string ad = Console.ReadLine();

    Console.WriteLine("Ogrencinin soyadi: ");
    string soyad = Console.ReadLine();

    Console.WriteLine("1. sinav notu");
    double not1 = Convert.ToDouble(Console.ReadLine());
    
    Console.WriteLine("2. sinav notu");
    double not2 = Convert.ToDouble(Console.ReadLine());
    
    Console.WriteLine("3. sinav notu");
    double not3 = Convert.ToDouble(Console.ReadLine());

    double notOrtalama = (not1+not2+not3)/3;

    toplamNot += notOrtalama;   // not ortalamasina ekleme

    Console.WriteLine(ad + soyad + " in not ortalamasi: " + notOrtalama + " dir ");
}

sinifOrtalama = toplamNot / ogrenciSayisi;   //sinif ortalamasinin hesaplanmasi
Console.WriteLine("Sinifin ortalama notu: " + sinifOrtalama);