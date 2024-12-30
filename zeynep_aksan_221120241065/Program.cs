using System;
using System.Collections.Generic;

namespace RüyaTabiriKonsol
{
    class Program
    {
        // Anahtar kelimelere ve bunların tabirlerine karşılık gelen bir Dictionary oluşturuyoruz
        private static Dictionary<string, string> rüyaTabirleri = new Dictionary<string, string>
        {
            { "uçmak", "Uçmak, özgürlüğün ve bağımsızlığın simgesidir. Ayrıca hayatta daha fazla kontrol arzusunu da gösterir." },
            { "su", "Su, duygusal bir durumu veya kişisel hayatınızdaki değişimleri temsil eder. Temiz su huzuru, kirli su ise zorlukları simgeler." },
            { "yılan", "Yılan, gizli tehlikeleri ve düşmanlıkları simgeler. Aynı zamanda yenilenme ve dönüşümün de sembolüdür." },
            { "ev", "Ev, genellikle kişinin iç dünyasını ve özel hayatını yansıtır. İçinde bulunduğunuz odalar ise hayatınızdaki farklı alanları gösterir." },
            { "araba", "Araba, kişinin yaşam yolculuğunu ve kontrolünü simgeler. Sürüş durumu ise hayatınızdaki yönü ve gücü gösterir." },
            { "uçurum", "Uçurum, büyük bir risk veya endişe durumunu simgeler. Hayatınızda bir karar aşamasında olduğunuzu gösterebilir." },
            { "deniz", "Deniz, bilinçaltınızı temsil eder. Sakin deniz huzuru simgelerken, dalgalı deniz duygusal karmaşayı işaret eder." },
            { "gömülü", "Gömülü bir şey, bastırılmış duyguları veya gizli kalmış sorunları simgeler. Bu, çözülmemiş meseleleri ortaya çıkarmaya işaret eder." }
        };

        static void Main(string[] args)
        {
            // Kullanıcıya rüya yazmasını söylüyoruz
            Console.WriteLine("Rüyanızı yazın:");

            // Kullanıcının girdiği rüya metnini alıyoruz
            string rüyaMetni = Console.ReadLine().ToLower();

            // Rüya tabirini başta bir hata mesajı olarak ayarlıyoruz
            string tabir = "Rüyanızla ilgili bir yorum bulunamadı.";

            // Rüya metnindeki anahtar kelimelere bakıyoruz
            foreach (var anahtarKelime in rüyaTabirleri.Keys)
            {
                // Eğer rüya metninde anahtar kelime geçiyorsa, karşılık gelen tabiri alıyoruz
                if (rüyaMetni.Contains(anahtarKelime))
                {
                    tabir = rüyaTabirleri[anahtarKelime]; // Tabiri alıyoruz
                    break; // İlk bulduğumuz anahtar kelimeye göre yorum yapıp döngüyü sonlandırıyoruz
                }
            }

            // Sonucu ekrana yazdırıyoruz
            Console.WriteLine("Rüya Tabiriniz: " + tabir);

            // Programın bitmesini beklemek için kullanıcıdan bir tuşa basmasını istiyoruz
            Console.ReadKey();
        }
    }
}
