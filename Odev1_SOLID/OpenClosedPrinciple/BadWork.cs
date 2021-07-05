namespace OpenClosedPrinciple{

    public class TheMalll{
        public int Id {get;set;}
        public string StoreName{get;set;}
        public string StoreType{get;set;}
        public int Floor{get;set;}

        public int TypeCount(string StoreType, int typeCount){
            if(StoreType == "Clothing"){
                return typeCount++;
            }else if(StoreType == "Shoe&Bag"){
                return typeCount++;
            }else if(StoreType == "Cosmetic"){
                return typeCount++;
            }else if(StoreType == "Food"){
                return typeCount++;
            }else if(StoreType == "Furniture"){
                return typeCount++;
            }else {
                return typeCount;
            }
        }
    }
}