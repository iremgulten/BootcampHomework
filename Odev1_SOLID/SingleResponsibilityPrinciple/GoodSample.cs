namespace Odev1_SOLID{
    public class Car{
        public string Brand{get; set;}
        public string Model{get; set;}
        public string Color{get; set;}
    }
    public class Staff{
        public void Sell_RentCar(){
            //Çalışan tarafından gerçekleştirilen araba satma ve kiralama işlemleri
        }
        public void RecieveCar(){
            //Çalışan tarafından gerçekleştirilen araba teslim alma işlemi
        }
    }
    public class Customer{
        public void BuyCar(){
            //Müşteri tarafından gerçekleştirilen araba satın alma işlemi
        }
        public void RentCar(){
            //Müşteri tarafından gerçekleştirilen araba kiralama işlemi
        }
    }
}