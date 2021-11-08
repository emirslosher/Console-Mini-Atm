using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonsolMiniAtm
{
    class Program
    {
        static void Main(string[] args)
        {

            int bakiye = 2000;

            Console.WriteLine("Merhaba ATM'ye hoşgeldiniz.");
            Console.WriteLine("Lütfen İstediğiniz işlemi seçiniz");

            string secim = Console.ReadLine();

            if (secim == "1")
            {
                Console.WriteLine("Şuanki bakiyeniz : " + bakiye);
            }

            else if (secim == "2")
            {
                Console.WriteLine("Lütfen Çekmek İstediğiniz tutarı giriniz.");
                int cekilecek_tutar = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Kalan Tutar : " + (bakiye - cekilecek_tutar));
            }


            else if (secim == "3")
            {
                Console.WriteLine("Yatırmak İstediğiniz Tutarı Giriniz");

                int yatirilacak_tutar = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Yeni Bakiyeniz : " + (bakiye + yatirilacak_tutar));
            }


            else if (secim == "q")
            {
                Console.WriteLine("ATM'den Çıkış Yapılıyor");
                Console.WriteLine("Çıkış Yapıldı İyi Günler...");
            }

            Console.ReadLine();  //slosher ke

        }
    }
}
