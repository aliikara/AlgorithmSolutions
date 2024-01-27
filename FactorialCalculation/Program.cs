Console.WriteLine("Sayı Giriniz");
int sayi = int.Parse(Console.ReadLine());
int sonuc = 1;

//for (int i = sayi; i > 0; i--)
//{
//    sonuc *= i;
//}

//while (sayi > 0)
//{
//    sonuc *= sayi;
//    sayi--;
//}

do
{
    if (sayi == 0) break;
    sonuc *= sayi;
    sayi--;
    //if (sayi == 0) break;
} while (true);

Console.WriteLine(sonuc);