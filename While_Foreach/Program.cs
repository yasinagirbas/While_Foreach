namespace While_foreach
{
    class While_foreach
    {
        static void Main(string[] args)
        {
            //while
            //1 den başlayarak console dan girilen sayı kadar (sayı dahil) ortalama hesaplayıp conseole yazdıran program.
            Console.Write("Bir sayı giriniz:");
            int sayi =int.Parse(Console.ReadLine());
            int sonuc = 1;
            int toplam=0;
            while (sonuc<=sayi)
            {
                toplam += sonuc;
                sonuc++;

            }
            Console.WriteLine(toplam/sonuc);
            
            // a dan z ye kadar olan kelimeleri yazdıran komut;

            char character = 'a';
            while (character<='z')
            {
                Console.Write(character);
                character++;
            }
            
            Console.WriteLine("*************** foreach ***********");
            string[] arabalar = {"ford", "bmw", "audi"};
            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }
        }
    }
    
}

