// See https://aka.ms/new-console-template for more information
using Metotlar;



string UrunAdi = "Elma";
double Fiyati = 15;
string Aciklama = "Amasya Elması";


string [] meyveler = new string[] {"Elma","Karpuz"};

Urun urun1 = new Urun ();

urun1.Adi = "Elma";
urun1.Fiyati = 15;
urun1.Aciklama = "Amasya Elması";

Urun urun2 = new Urun ();

urun2.Adi = "Karpuz";
urun2.Fiyati = 80;
urun2.Aciklama = "Diyerbakır Karpuzu";

Urun[] urunler = new Urun[] {urun1, urun2 };

foreach (Urun urun in urunler)
{
    Console.WriteLine(urun.Adi);
    Console.WriteLine(urun.Fiyati);
    Console.WriteLine (urun.Aciklama);
    Console.WriteLine("-----------------");

    Console.WriteLine("-----------------Metodlar--------------");

    SepetManager sepetManager = new SepetManager ();

    sepetManager.Ekle(urun1);
    sepetManager.Ekle(urun2);


    sepetManager.Ekle2("Elma", "Amasya Elması", 15);

    sepetManager.Ekle2("Karpuz", "Diyerbakır Karpuzu", 80);




}


