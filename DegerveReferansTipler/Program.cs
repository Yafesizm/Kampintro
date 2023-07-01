// See https://aka.ms/new-console-template for more information

int sayi1 = 10;
int sayi2  = 30;

sayi1 = sayi2;

sayi2 = 65;

Console.WriteLine( sayi1);

// sayı1 ?? 30


int[] sayilar1 = new int[] { 10, 20, 30 };

int[] sayilar2 = new int[] { 100, 200, 300 };

sayilar1 = sayilar2;
sayilar2 [0] = 999;

Console.WriteLine( sayilar1[0] );

//sayiylar1[0]=?? 999


// int, decimal, float, double(true, false) bunlar Değer Tiplerdir
// Array, class, interface ise Referans Tiplerdir
//sistem verileri 2 şekilde tutar 1.:Stock 2.:Heap
//STOCK'a örnek Sayi1 , Sayi2 , Sayilar1, Sayilar2
//HEAP'a örnek new intdeki verileri örnek olarak gösterilebilir

