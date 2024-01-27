Console.WriteLine("Doğum tarihinizi giriniz");

//DateTime dogumTarihi = Convert.ToDateTime(Console.ReadLine());
//TimeSpan sonuc = DateTime.Now - dogumTarihi;
//Console.WriteLine(sonuc.Days / 365);

//DateTime dogumTarihi = DateTime.Parse(Console.ReadLine());
//DateTime bugun = DateTime.Now;
//int yas = bugun.Year - dogumTarihi.Year;
//if (dogumTarihi > bugun.AddYears(-yas))
//    yas--;
//Console.WriteLine(yas);

DateTime dogumTarihi = DateTime.Parse(Console.ReadLine());
int gun = (DateTime.Now - dogumTarihi).Days;
int yas = gun / 365;
int kalan = gun % 365;
Console.WriteLine($"Yaş : {yas} | {yas + 1} yaşınıza kalan gün sayısı : {365 + (yas * 1 / 4) - kalan}");