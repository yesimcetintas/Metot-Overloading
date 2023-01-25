﻿// See https://aka.ms/new-console-template for more information

// out parametreler
string sayi = "999";

int outSayi;

bool sonuc = int.TryParse(sayi, out outSayi);

if(sonuc){
    Console.WriteLine("Başarılı!");
    Console.WriteLine(outSayi);
}else{
    Console.WriteLine("Başarısız!");
}

Metotlar instance = new Metotlar();
instance.Topla(4,5, out int toplamSonuc);
Console.WriteLine(toplamSonuc);

// metot aşırı yükleme-overloading

int ifade = 999;

instance.EkranaYazdir(ifade);
instance.EkranaYazdir(Convert.ToString(ifade));
instance.EkranaYazdir("Yeşim", "Çetintaş");

class Metotlar{
    public void Topla(int a, int b, out int toplam){
        toplam = a + b;
    }

    public void EkranaYazdir(string veri){
        Console.WriteLine(veri);
    }
    public void EkranaYazdir(int veri){
    Console.WriteLine(veri);
    }
    public void EkranaYazdir(string veri1, string veri2){
    Console.WriteLine(veri1 + veri2);
    }
}
