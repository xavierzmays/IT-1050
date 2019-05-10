namespace TheTwoCouples
{
    class Person
    {
        public int Age;
        public string FirstName;
        public string LastName;
        public Person Spouse;

        public static int Count;
        public static int SumOfAllAges;

        public void GatherDataFromPerson()
        {
            this.FirstName = Question.AskForString("Enter Your First Name");
            this.LastName = Question.AskForString("Enter Your Last Name");
            this.Age = Question.AskForInteger("Enter Your Age");
            this.Spouse.FirstName = Question.AskForString("Enter Your Spouse's Name");
            this.Spouse.Age = Question.AskForInteger("Enter Your Spouse's Age");
        }

        public string GetFullName()
        {
            return this.FirstName + " " + this.LastName;
        }

        public void PrintNameAndAge()
        {
            System.Console.WriteLine(GetFullName());
            System.Console.WriteLine(this.Age);
        }
    }
}
