using System;

namespace Odev2_Extension
{
    class Program
    {
        static void Main(string[] args)
        {
            TLtoUSD();

            USDtoTL();

            TLtoEURO();

            EUROtoTL();

            DonemNotu();

            DogumYiliBul();
        }
        static void DonemNotu()
        {
            Console.Write("Vize notunuzu giriniz: ");
            double vize = double.Parse(Console.ReadLine());

            double vizeEtki = vize.VizeEtkisi(0.4);

            Console.Write("Final notunuzu giriniz: ");
            double final = double.Parse(Console.ReadLine());

            double finalEtki = final.FinalEtkisi(0.6);

            Console.WriteLine("Dönem Notunuz : {0}", vizeEtki + finalEtki);
        }
        static void DogumYiliBul()
        {
            Console.Write("Yaşınızı giriniz: ");
            int yas = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} yılında doğmuşsunuz", yas.DogumYili());
        }
        static void TLtoUSD()
        {
            Console.Write("Dolar kuruna çevirmek istediğiniz miktarı giriniz:");
            double price = double.Parse(Console.ReadLine());

            Console.WriteLine("{0} TL'nin dolar kuru karşılığı : {0}", price, price.TLtoUSD());
        }
        static void USDtoTL()
        {
            Console.Write("Türk Lirası kuruna çevirmek istediğiniz miktarı giriniz:");
            double price = double.Parse(Console.ReadLine());

            Console.WriteLine("{0} USD'nin türk lirası kuru karşılığı : {0}", price, price.TLtoUSD());
        }
        static void TLtoEURO()
        {
            Console.Write("Euro kuruna çevirmek istediğiniz miktarı giriniz:");
            double price = double.Parse(Console.ReadLine());

            Console.WriteLine("{0} TL'nin euro kuru karşılığı : {0}", price, price.TLtoUSD());
        }
        static void EUROtoTL()
        {
            Console.Write("Türk lirası kuruna çevirmek istediğiniz miktarı giriniz:");
            double price = double.Parse(Console.ReadLine());

            Console.WriteLine("{0} TL'nin türk lirası kuru karşılığı : {0}", price, price.TLtoUSD());
        }
    }
}
