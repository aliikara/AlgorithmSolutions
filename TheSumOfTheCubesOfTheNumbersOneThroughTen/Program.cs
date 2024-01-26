//double toplamSonuc = 0;

//for (int i = 1; i <= 10; i++)
//{
//    toplamSonuc += Math.Pow(i, 3);
//}
//Console.WriteLine(toplamSonuc);

double toplamSonuc = 0;
int sayac = 1;
while (true)
{
    toplamSonuc += Math.Pow(sayac, 3);
    if (sayac == 10) break;
    sayac++;

}
Console.WriteLine(toplamSonuc);