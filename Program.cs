using System;

namespace Hata_Yonetimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            try
            {
                Console.WriteLine("Bir Sayı Girin");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girilen Sayi :" + sayi);
            }
            catch (Exception ex )
            {
                Console.WriteLine("Hata: " + ex.Message.ToString());

            }
            finally
            {
                Console.WriteLine("İşlem tamam");
            }
            */

            
            try
            {
                int deger = int.Parse("2");
                Console.WriteLine("Girilen Deger :" + deger);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Boş Değer Girdiniz " + ex);
                

            }catch (FormatException ex)
            {
                Console.WriteLine("Veri Tipi Uygun Değil: " + ex);
            }
            finally
            {
                Console.WriteLine("işlem tamamlandı");
            }
        }
    }
}
