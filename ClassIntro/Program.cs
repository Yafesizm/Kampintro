// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System.Diagnostics.Tracing;
using System.Net.Security;
using System.Security.Principal;

string İsim = "Yafes";
int yas = 22;

//yukarıdaki gibi tek tek string ile tanımlamak yerine class ike bir kurs kodu yarattık bu kurs kodunun içerisinede verileri (kurs adı,eğitmeni vs.) yazıp bilgi haline getirdik ardından
// bu bilgileri bir foreach döngüsüyle programa okuttuk bu kurs kodu sayesinde string ile tek tek tanımlamak yerine class kodu ile bir kurs kodu oluşturduk ve kurs kodunun içine gerekli
// bütün verileri tanımladık böylece tek tek bilgi eklemek ile uğraşmak yerine kurs ekliyip new kurs bölümüne o kursun adını yazıyoruz  

Kurs kurs1 = new Kurs ();
kurs1.KursAdi = "C#";
kurs1.Egitmen = "Yafes Suer";
kurs1.IzlenmeOrani = 31;

Kurs kurs2 = new Kurs();
kurs2.KursAdi = "Java";
kurs2.Egitmen = "Yavuz Selim Oztas";
kurs2.IzlenmeOrani = 62;

Kurs kurs3 = new Kurs();
kurs3.KursAdi = "Html";
kurs3.Egitmen = "Burak Ozturk";
kurs3.IzlenmeOrani = 93;

Kurs kurs4 = new Kurs();
kurs4.KursAdi = "Python";
kurs4.Egitmen = "Enes Durmus";
kurs4.IzlenmeOrani = 93;


//Console.WriteLine (kurs1.KursAdi + ":" + kurs1.IzlenmeOrani + kurs1.Egitmen);

Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3, kurs4 };
foreach (Kurs kurs in kurslar)
{
    Console.WriteLine (kurs.KursAdi +  ":"  + kurs.Egitmen);
}

class Kurs
{
    public string KursAdi { get; set; }
    public string Egitmen{ get; set; }
    public int IzlenmeOrani { get; set; }
}