namespace OOP_C_
{


    abstract class Sports
    {
        public string TeamName { get; set; }

        public abstract string DisplayInfo();

    }

   class Football : Sports
    {
        public string Owner { get; set; }
        public string Captain { get; set; }


        public Football(string name, string owner, string captain)
        {

            TeamName = name;
          
            Owner = owner;
            Captain = captain;
        }

        public override string DisplayInfo()
        {
            return ($"Team Name: {TeamName}, Owner: {Owner}, Captain: {Captain}");
        }


    }

    
    public class Management
    {
       
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {

            Football team1 = new Football("FC Hexclan", "Sayeduzzaman Islam","Al Momen");
            Football team2 = new Football("Thread Titans", "Tanvir Islam", "Asif Mahmud");


            Console.WriteLine(team1.DisplayInfo());
        }
    }
}
