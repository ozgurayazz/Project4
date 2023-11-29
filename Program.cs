namespace Proje4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string msg1 = "Hava nasıl ? İYİ / KÖTÜ ";
                Console.WriteLine(msg1);
                string hava = Console.ReadLine().ToUpper();

                if (hava == "İYİ")
                {
                    Console.WriteLine("Kaç derece ? ");
                    sbyte derece = sbyte.Parse(Console.ReadLine());
                    if (derece < 15)
                    {
                        Console.WriteLine("Hava soğuk evde otur");
                    }
                    else if (15 <= derece && derece < 35)
                    {
                        Console.WriteLine("Hava güzel dışarı çıkabilirsin");
                    }
                    else if (derece > 35)
                    {
                        Console.WriteLine("Hava çok sıcak evde otur ");
                    }
                }
                else if (hava == "KÖTÜ")
                {
                    Console.WriteLine("Dışarı çıkma evde kal");
                }
                else
                {
                    Console.WriteLine("Yanlış giriş yaptınız");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Bir sayı ile giriş yapınız.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("-255 ile +255 arasında bir değer giriniz.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Bir hata oluştu");
                Console.WriteLine($"Hata Detayları: \nTarih Saat:{DateTime.Now}\nHata Mesajı:{ex.Message}\nStack Trace: {ex.StackTrace}");
            }
        }
    }
}