using System;

namespace string_metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string degisken = "Dersimiz CSharp, Hoşgeldiniz";
            string degisken1 = "dersimiz CSharp, Hoşgeldiniz";
            string degisken2 = "CSharp";
            string degisken3 = " Ders 1 ";

            // Lenght : Kaç karakter

            int kacHarf = degisken.Length;
            System.Console.WriteLine("Değişken {0} karakterden oluşmaktadır",kacHarf);

            // ToUpper : Bütün hepsini büyük harf yapar - ToLower : Bütün karakterlerin hepsini küçük harf yapar.

            degisken.ToUpper();
            System.Console.WriteLine(degisken);
            degisken.ToLower();
            System.Console.WriteLine(degisken);

            // Concat : iki stringi birleştirir. string.Concat(degisken1,degisken2)

            System.Console.WriteLine(string.Concat(degisken,degisken3));

            // Compare - CompareTo 

            System.Console.WriteLine(degisken.CompareTo(degisken2)); // Eğer değişken harf sayısı olarak degisken2 den fazla 
                                                                     // ise 1 değil ise -1 aynı ise 0 cevabını döndürür.
            System.Console.WriteLine(degisken);
            System.Console.WriteLine(string.Compare(degisken1,degisken,false)); // aynı şekilde harf sayısını kıyaslar. 
                                                                                // Fakat burada true ve false vererek
                                                                                // büyük küçük harf duyarlılığının olup olmamasını belirtebiliriz. 
                                                                                // False ken bire bir aynı ise 0 verir. True ken büyük küçük harf duyarlılığı yoktur.
                                                                                // degisken > degisken2 = 1
                                                                                // degisken < degisken2 = -1
                                                                                // degisken = degisken2 = 0

            // Contains : Verilen ifadeyi içeriyormu diye bakılır.

            System.Console.WriteLine(degisken.Contains(degisken2)); // True veya false verir. True VERİR.
            System.Console.WriteLine(degisken.Contains(degisken3)); // True veya false verir. false VERİR.
            System.Console.WriteLine(degisken.Contains("hoşgeldiniz")); // True veya false verir. false VERİR.
            System.Console.WriteLine(degisken.Contains("Hoşgeldiniz")); // True veya false verir.  True VERİR.
            System.Console.WriteLine(degisken.EndsWith("Hoşgeldiniz")); // True veya false verir.  True VERİR.
            System.Console.WriteLine(degisken.StartsWith("Dersimiz")); // True veya false verir.  True VERİR.
            System.Console.WriteLine(degisken.StartsWith("dersimiz")); // True veya false verir.  false VERİR.
            
            // IndexOf : String içerisinde bir kelime veya harf arama.

            System.Console.WriteLine(degisken.IndexOf("CS")); // CS'yi ilk gördüğü index'i geri döndürür.
            System.Console.WriteLine(degisken.IndexOf("res")); // string içerisinde yoksa -1 verir.

            // LastIndexOf : Sondan başlayarak i harfinin indexini verir.

            System.Console.WriteLine(degisken.LastIndexOf("i"));  // varsa index'ini yoksa -1 döndürür.
            System.Console.WriteLine(degisken.LastIndexOf("asa")); // -1 verir.
            System.Console.WriteLine(degisken.LastIndexOf("imiz")); // 4 verir.

            // Insert : String ifadeye yeni bir ek yapılacak ise index verilerek oraya ekleme yapılır.

            System.Console.WriteLine(degisken.Insert(0,"Merhaba! ")); // 0 index numarası.

            // PadLeft, PadRight : Verilen değer kadar 
            // ör/ 30 ve " "  verilirse 30 karaktere tamamlayana kadar soluna yada sağına boşluk bırakır.
 
            System.Console.WriteLine(degisken + degisken2.PadLeft(20)); // ( Dersimiz CSharp, Hoşgeldiniz              CSharp ) verir.
            System.Console.WriteLine(degisken + degisken2.PadRight(10,'*')); // ( Dersimiz CSharp, HoşgeldinizCSharp**** ) verir.
            System.Console.WriteLine(degisken + degisken2.PadLeft(10,'*')); // ( Dersimiz CSharp, Hoşgeldiniz****CSharp ) verir.
            System.Console.WriteLine(degisken.PadLeft(50,'-') + degisken2); // ( ----------------------Dersimiz CSharp, HoşgeldinizCSharp ) verir.

            // Remove : Verilen indexten itibaren kaç karakter çıkarılacaksa onun uzunuluğu verilir veya verilen indexten sona kadar siler.

            System.Console.WriteLine(degisken.Remove(15)); // ( Dersimiz CSharp ) verir.
            System.Console.WriteLine(degisken.Remove(15,5)); // ( Dersimiz CSharpgeldiniz ) verir. 

            // Replace : Stringteki karakter veya kelime yerine başka bir ifade ile değiştirmek için kullanılır.

            System.Console.WriteLine(degisken.Replace("CSharp","C#")); // ( Dersimiz C#, Hoşgeldiniz ) verir. 
            System.Console.WriteLine(degisken.Replace(" ","*")); // ( Dersimiz*CSharp,*Hoşgeldiniz ) verir. 

            // Split : Verilen string'i verilen ifade kapsamında string ifadeyi böler.

            System.Console.WriteLine(degisken.Split(" ")[0]); // ( Dersimiz ) verir. 
            System.Console.WriteLine(degisken.Split(" ")[1]); // ( CSharp, ) verir. 
            System.Console.WriteLine(degisken.Split(" ")[2]); // ( Hoşgeldiniz ) verir. 

            // Substring : Verilen indexten sonuna kadar bir string ifade oluşturmuş olur yada 
            // verilen indexten verilen uzunluk kadar string bir karakter elde edilebilir.

            System.Console.WriteLine(degisken.Substring(4));
            System.Console.WriteLine(degisken.Substring(4,5));

            



            



        }
    }
}

