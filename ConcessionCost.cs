namespace NightAtTheMovies
{
    class ConcessionCost
    {
        public int SmallSodaCount;
        public int LargeSodaCount;
        public int HotDogCount;
        public int PopCornCount;
        public int CandyCount;
        public int ConcessionInfoForDiscount1;
        

        public double SmallSodaCost = 3.5;
        public double LargeSodaCost = 5.99;
        public double HotDogCost = 3.99;
        public double PopCornCost = 4.50;
        public double CandyCost = 1.99;
        
        

        public void GetOrderInfo()
        {
            this.SmallSodaCount = Questions.AskForInteger("How many small sodas?");
            this.LargeSodaCount = Questions.AskForInteger("How many large sodas?");
            this.HotDogCount = Questions.AskForInteger("How many hot dogs?");
            this.PopCornCount = Questions.AskForInteger("How many popcorns?");
            this.CandyCount = Questions.AskForInteger("How many candies?");
            
        }

        public int GetConcessionInfoForDiscount1()
        {
            return this.ConcessionInfoForDiscount1 = System.Math.Min(this.PopCornCount, this.LargeSodaCount);
        }

        public double GetSubTotalConcession()
        {
            
        return this.SmallSodaCount*SmallSodaCost + this.LargeSodaCount*LargeSodaCost + this.HotDogCount*HotDogCost + this.PopCornCount*PopCornCost + this.CandyCount*CandyCost;
        }
       
    }

}

