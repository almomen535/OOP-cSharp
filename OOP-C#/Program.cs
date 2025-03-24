namespace OOP_C_
{


    abstract class Team
    {
        public string Name { get; set; }
        public string ID { get; set; }

        public abstract string GetDetalis();

    }

   class Teams : Team
    {
        public string Owner { get; set; }
        public string Captain { get; set; }


        public Teams(string name,string id, string owner, string captain)
        {

            Name = name;
            ID = id;
            Owner = owner;
            Captain = captain;
        }

        public override string GetDetalis()
        {
            return ($"Team Name: {Name},  ID: {ID},  Owner: {Owner}, Captain: {Captain}");
        }


    }

    
    
    internal class Program
    {
        static void Main(string[] args)
        {

            Teams team1 = new Teams("FC Hexclan", "F153","Sayeduzzaman Islam","Al Momen");


            Console.WriteLine(team1.GetDetalis());
        }
    }
}
