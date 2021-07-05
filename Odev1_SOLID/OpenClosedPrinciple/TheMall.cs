namespace OpenClosedPrinciple{

    public abstract class TheMall{
        public int Id {get;set;}
        public string StoreName{get;set;}
        public int Floor{get;set;}

        public abstract int TypeCount(int typeCount);
    }
}