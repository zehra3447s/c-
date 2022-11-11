using System;

namespace gumus/**gumus adında bir ad alanı oluşturduk bu kod satırının amacı aynı amaca hizmet eden özellikleri, sınıfları ve fonksiyonları bir çatı altında toplamak. **/
{
   class zehra 
   {
       static void Main (string[] args) {
        string KD = "", alanCevre = ""; /**KD VE alanceve-re adında iki değişkenimizi tanımladık bunlara değer atamadık kullanıcıdan almak için**/
        int a, b, cevre, alan; /** a b ve cevre alan ı da int olarak tanıladık.**/
        Console.WriteLine("1- Kare");/** ekrana 1 kare ve 2 dikdörtgen seçenklerini yazdırdık ve seçinini 1 ve 2 şeklinde yazmasını istedik**/
        Console.WriteLine("2- Diktörtgen");
        Console.Write("Seçiminiz (1-2) : ");
        KD = Console.ReadLine();

        if (KD == "1") /** eğer kullanıcı 1 i seçtiyse diğer soruya geç ikinic soruyu sorduk alan mı çevre mi diye sorduk**/
       {
        Console.WriteLine("1- Alan");
        Console.WriteLine("2- Çevre");
        Console.Write("Yapmak istediğiniz işlemi girin (1-2) : ");
        alanCevre = Console.ReadLine();
       }
        if (alanCevre == "1") /** kullanacı 1 seçerse alan hesapla dedik**/
       
       {
        Console.Write("Kenar uzunluğunu giriniz = "); /** kenar uzunluğunu istedik kullanıcıdan alanı da a*a şeklinde tanımladık. alanın başlangıç değerine sıfır verdik.**/ 
        a = int.Parse(Console.ReadLine()); /** string türündeki veriyi int çevirdik.**/
        alan = a * a;
        Console.WriteLine("Alan = {0}", alan);
        }
        if (alanCevre == "2") /** kullanıcı ikiyi seçerse çevreyi hesapladık karenin çevresisini 4*a şeklinde tanımladık ve çevrenin ilk değerini sıfırdan başlattık.**/
        {
         Console.Write("Kenar uzunluğunu giriniz = ");
         a = int.Parse(Console.ReadLine());
         cevre = 4 * a;
         Console.WriteLine("Çevre={0}", cevre);
        }
        if (KD== "2") /** eğer kullanıcı dikdörtgeni seçerse alan mı çevre mi seçmesini istedik.**/
         {
        Console.WriteLine("1- Alan");
        Console.WriteLine("2- Çevre");
        Console.Write("Yapmak istediğiniz işlemi girin (1-2) : ");
        alanCevre = Console.ReadLine();
         }         
        if (alanCevre == "1") /** alanı seçerse uzun ve kısa kenar uzunluğunu istedik alan hesaplaması içiç a*b diye tanımladık alanı çevre için ise 2*(a+b) tanımladık **/
        {
        Console.Write("Uzun Kenar uzunluğunu giriniz = ");
        a = int.Parse(Console.ReadLine());
        Console.Write("Kısa Kenar uzunluğunu giriniz = ");
        b = int.Parse(Console.ReadLine());
        alan = a * b;
        Console.WriteLine("Alan = {0}", alan);/** sonucu ekrana yazdırdık.**/
        }
        if (alanCevre == "2")
        {
         Console.Write("Uzun Kenar uzunluğunu giriniz = ");
         a = int.Parse(Console.ReadLine());
         Console.Write("Kısa Kenar uzunluğunu girinizz = ");
         b = int.Parse(Console.ReadLine());
         cevre = 2 * (a + b);
         Console.WriteLine("Çevre = {0}", cevre); /** sonucu ekrana yazdırdık.**/
        }
        }

    }    
        
}