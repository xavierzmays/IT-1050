namespace IT1050ProgrammingLogicFinal
{
    class Elevator
    {
        private double MaxWeight { get; set; }
        private Passenger[] Occupants;



        public Elevator(int maxOccupants, double maxWeight)
        {
            this.MaxWeight = maxWeight;
            this.Occupants = new Passenger[maxOccupants];
        }

        public void AddOccupant(Passenger passenger, int index)
        {

                Occupants[index] = passenger;
    
        }

        public double GetCurrentWeight()
        {
            double TotalCurrentWeight = 0;

            for (int i = 0; i < Occupants.Length; i++)
            {
                TotalCurrentWeight = TotalCurrentWeight + Occupants[i].GetWeight(); 
            }
            return TotalCurrentWeight;

        }
        public bool IsOverMaxCapacity()
        {
            if (this.GetCurrentWeight() > this.MaxWeight)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
