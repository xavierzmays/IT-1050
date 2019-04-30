using System;

namespace NightAtTheMovies
{
    class Program

    {
        static void Main(string[] args) {


            ConcessionCost concessionOrder1 = new ConcessionCost();
            concessionOrder1.GetOrderInfo();

            TicketCost ticketOrder1 = new TicketCost();
            ticketOrder1.GetTicketOrder();

           double Discount1 = System.Math.Min(concessionOrder1.GetConcessionInfoForDiscount1(), ticketOrder1.GetTicketInfoForDiscount1()) * 2;

           double Discount2;

            if (!ticketOrder1.TicketTypeMatinee && (ticketOrder1.TotalTicketCount >= 3) && concessionOrder1.PopCornCount >= 1)
            {
              Discount2 = concessionOrder1.PopCornCost;
            }

            else
            {
               Discount2 = 0;
            }

            double Discount3;

            if (concessionOrder1.CandyCount == 3)
            {
                Discount3 = 0;
                System.Console.Write("You recieve a free candy because you bought 3!");
            }

            else if (concessionOrder1.CandyCount >= 4)
            {
                Discount3 = (concessionOrder1.CandyCount / 4) * concessionOrder1.CandyCost;
                System.Console.Write("You recieve a discount for buying more than 3 candies!");
            }

            else
            {
                Discount3 = 0;

            }
            
            double PriceTotal = (concessionOrder1.GetSubTotalConcession() + ticketOrder1.GetTicketCost() - Discount1 - Discount2 - Discount3);
            
            System.Console.Write("Your total is:" + PriceTotal); 
            System.Console.ReadKey();
        }

    }
}
