// See https://aka.ms/new-console-template for more information
using System;
// String metin kodu ile kategori etiketi takma adı bir koda dönüştürülüdü karşılığı ise kategoriler , İNT kodu ise sayısalar verilerde kullanılıyor veriyi "" içine yazmamıza gerek yok.
// double kodu ise ondalıklı sayılarda kullanılır veriyi "" içine yazmaya gerek yoktur
// if ve else ve else if kodu burada eğer dolar dünden yüksekse , dünden düşükse , dün ile aynı ise bunu yaz gibi bir ifade ile kullanılmuştır ve sisteme giriş yapıp yapmamışa göre çalıştırılmıştır

string kategoriEtiketi = "Kategoriler";
int OğrenciSayisi = 32000;
double FaizOranı = 1.45;
bool SistemeGirisYapmismi = true;
double DolarDun = 7.45;
double DolarBugun = 7.45;

if (DolarDun>DolarBugun)
{
    Console.WriteLine("Azalış butonu");
}

else if (DolarDun<DolarBugun)
{
    Console.WriteLine("Artış butonu");
}

else 
{
    Console.WriteLine("Değişmedi butonu");
}

if (SistemeGirisYapmismi == true)
{
    Console.WriteLine ("Kullanıcı ayarları butonu ");
}

else
{
    Console.WriteLine("Giris yap butonu");
}


