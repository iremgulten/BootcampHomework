namespace OpenClosedPrinciple{

    public class Clothing : TheMall{
        public override int TypeCount(int clothingTypeCount){
            return clothingTypeCount++;
        }
    }
    public class Shoe_Bag : TheMall{
        public override int TypeCount(int shoeBagTypeCount){
            return shoeBagTypeCount++;
        }
    }
    public class Cosmetic : TheMall{
        public override int TypeCount(int cosmeticTypeCount){
            return cosmeticTypeCount++;
        }
    }
    public class Food : TheMall{
        public override int TypeCount(int foodTypeCount){
            return foodTypeCount++;
        }
    }
    public class Furniture : TheMall{
        public override int TypeCount(int furniturTypeCount){
            return furniturTypeCount++;
        }
    }
}