// See https://aka.ms/new-console-template for more information
Console.WriteLine("İlk Sayıyı Seçiniz: ");
int sayi = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("İkinci Sayıyı Seçiniz: ");
int sayi2 = Convert.ToInt32(Console.ReadLine());
double sonuc = 0;
Console.WriteLine("Yapılacak İşlemi Seçiniz: ( * )Çarpma, ( / ) bölme, ( + )Toplama, ( - )Çıkartma");
string islem = Console.ReadLine();
if (islem == "+")
{
    sonuc = sayi + sayi2;
    Console.WriteLine("Sonuç: " + sonuc);
}
else if (islem == "-")
{
    sonuc = sayi - sayi2;
    Console.WriteLine("Sonuç: " + sonuc);
}
else if (islem == "*")
{
    sonuc = sayi * sayi2;
    Console.WriteLine("Sonuç: " + sonuc);
}
else if (islem == "/")
{
    sonuc = sayi / sayi2;
    Console.WriteLine("Sonuç: " + sonuc);
}