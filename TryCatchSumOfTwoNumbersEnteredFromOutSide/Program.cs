try
{
    Console.WriteLine("1. Sayıyı Giriniz : ");
    int sayi1 = int.Parse(Console.ReadLine());
    Console.WriteLine("2. Sayıyı Giriniz : ");
    int sayi2 = int.Parse(Console.ReadLine());

    Console.WriteLine(sayi1 + sayi2);
}
catch 
{
    Console.WriteLine("Lütfen doğru bir sayı giriniz.");

}