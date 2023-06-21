// Beden Kitle Indeksi Uygulamasi
// Beden kitle indeksi = Kilo / boy * boy
//Beden kitle indeksi 18'e eşit veya düşükse "ZAYIF"
//Beden kitle indeksi 18 ile 25 arasındaysa "NORMAL"
// Beden kitle indeksi 25'ten büyükse "OBEZ" 

namespace BedenKitleIndeksi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kilonuzu giriniz");
            int kilo = Convert.ToInt32((Console.ReadLine()));
            
            Console.WriteLine("Boyunuzu giriniz");
            double boy = Convert.ToDouble((Console.ReadLine()));

            double bke = kilo / boy * boy;

            if (bke <= 18) {
                Console.WriteLine("ZAYIF");
                Console.ReadLine();
            }
            else if (bke > 18 && bke < 25)
            {
                Console.WriteLine("NORMAL");
                Console.ReadLine();
            }
            else if (bke>25)
            {
                Console.WriteLine("OBEZ");
                Console.ReadLine();
            }
        }
    }
}