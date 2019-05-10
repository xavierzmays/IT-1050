namespace IT1050ProgrammingLogicFinal
{
    class Passenger
    {
        private string Name { get; set; }
        private double Weight { get; set; }

        public Passenger(string name, double weight)
        {
            this.Name = name;
            this.Weight = weight;
        }
        public string GetName()
        {
            return this.Name;
        }

        public double GetWeight()
        {
            return this.Weight;
        }
    }
}
