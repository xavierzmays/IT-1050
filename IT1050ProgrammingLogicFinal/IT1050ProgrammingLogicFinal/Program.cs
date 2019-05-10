namespace IT1050ProgrammingLogicFinal
{
    class Program
    {
        static void Main(string[] args)
        {


            Elevator elevator1 = new Elevator(2, 400);

            Passenger A1 = new Passenger("A1", 180);
            elevator1.AddOccupant(A1, 0);

            Passenger A2 = new Passenger("A2", 220);
            elevator1.AddOccupant(A2, 1);

            bool elevator1IsOverMaxCapacity = elevator1.IsOverMaxCapacity();


            Elevator elevator2 = new Elevator(3, 600);

            Passenger B1 = new Passenger("A1", 200);
            elevator2.AddOccupant(B1, 0);

            Passenger B2 = new Passenger("A2", 200);
            elevator2.AddOccupant(B2, 1);

            Passenger B3 = new Passenger("A3", 201);
            elevator2.AddOccupant(B3, 2);

            bool elevator2IsOverMaxCapacity = elevator2.IsOverMaxCapacity();

        }
    }
}
