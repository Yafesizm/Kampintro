// See https://aka.ms/new-console-template for more information
using System;
//Dinamik olmayan yazılım sürekli veriler hem string hemde console olarak eklememiz gerekiyor iş gücü fazla 

string kurs1 = "Python";
string kurs2 = "C";
string kurs3 = "Java";
string kurs4 = "C#";
string kurs5 = "C++";

Console.WriteLine(kurs1);
Console.WriteLine(kurs2);   
Console.WriteLine(kurs3);   
Console.WriteLine(kurs4);   
Console.WriteLine(kurs5);


//Dinamik Yazulım : Burada sadece New stringedeki kurslar kısmına kurs eklememiz yeterli çünkü dizi Kursların uzunluğunda sayıyor (Kurslar Length)

string[] kurslar = new string [] {"Python","C","Java","C#","C++" };

for (int i = 0; i<kurslar.Length; i+=1)
{
    Console.WriteLine(kurslar[i]);
}
Console.WriteLine("For Bitti");

// Dizileri tek tek dolaşmaya yarar metin tabanlı kodlarda genelde foreach kullanılması daha kolaydır. 

foreach (string kurs in kurslar)
{
    Console.WriteLine(kurs);
}
Console.WriteLine("Kurslar bitti - footer");