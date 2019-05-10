
namespace NightAtTheMovies
{
    class TicketCost
    {
        public int ChildTicketCount;
        public int AdultTicketCount;
        public int SeniorTicketCount;
        public int TotalTicketCount;
        public bool TicketTypeMatinee;
        public double ChildCost;
        public double AdultCost;
        public double SeniorCost;

        public void GetTicketOrder()
        {
            this.ChildTicketCount = Questions.AskForInteger("How many child tickets would you like?");
            this.AdultTicketCount = Questions.AskForInteger("How many adult tickets would you like?");
            this.SeniorTicketCount = Questions.AskForInteger("How many senior tickets would you like?");
            this.TicketTypeMatinee = Questions.AskForBool("Will these be matinee tickets? (type 'yes' or 'no')");
            this.TotalTicketCount = ChildTicketCount + AdultTicketCount + SeniorTicketCount;
        }

        public double GetTicketCost()
        {
            
            if (TicketTypeMatinee)
            {
                ChildCost = 3.99;
                AdultCost = 5.99;
                SeniorCost = 4.50;

            }

            else
            {
                ChildCost = 6.99;
                AdultCost = 10.99;
                SeniorCost = 8.50;
            }

            

            return this.ChildTicketCount * ChildCost + this.AdultTicketCount * AdultCost + this.SeniorTicketCount * SeniorCost;
        }

        public int GetTicketInfoForDiscount1()
        {
            return SeniorTicketCount;

        }

    }
}
