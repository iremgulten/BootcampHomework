using System;

namespace Odev2_Extension
{
    public static class MyExtensions
    {
        public static double FinalEtkisi(this double FinalEtki,double yuzde){   //Final notunun dönem notuna etkisinin hesaplanması

            return FinalEtki*yuzde;
        }
        public static double VizeEtkisi(this double VizeEtki,double yuzde){     //Vize notunun dönem notuna etkisinin hesaplanması

            return VizeEtki*yuzde;
        }
        public static int DogumYili(this int yil){  //Kullanıcıdan alınan yaş bilgisine göre doğum yılının hesaplanması
            DateTime sene = DateTime.Now;
            int gunumuz = Int32.Parse(sene.ToString("yyy"));
            return gunumuz-yil; 
       }
       public static double TLtoUSD(this double price){     //Türk lirasının Dolara çevrilmesi
           return price/8.7;
       }
       public static double USDtoTL(this double price){     //Doların Türk Lirasına çevrilmesi
           return price*8.7;
       }
       public static double TLtoEURO(this double price){    //Türk lirasının Euro'ya çevrilmesi
           return price/10.55;
       }
       public static double EUROtoTL(this double price){    //Euro'nun Türk Lirasına çevrilmesi
           return price*10.55;
       }
    }
}
