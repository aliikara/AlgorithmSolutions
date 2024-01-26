//Console.WriteLine("1. sayıyı giriniz : ");
//int sayi1 = int.Parse(Console.ReadLine());
//Console.WriteLine("2. sayıyı giriniz : ");
//int sayi2 = int.Parse(Console.ReadLine());

//int sonuc = (sayi1 * sayi1) + (sayi2 * sayi2);
//double sonuc = Math.Pow(sayi1, 2) + Math.Pow(sayi2, 2);

Console.WriteLine("1. ve 2. sayıları giriniz.");
double sonuc = Math.Pow(int.Parse(Console.ReadLine()), 2) + Math.Pow(int.Parse(Console.ReadLine()), 2);
Console.WriteLine(sonuc);
