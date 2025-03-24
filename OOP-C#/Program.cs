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
            return ($"Football Team Name: {TeamName}, Owner: {Owner}, Captain: {Captain}");
        }


    }


    class Cricket : Sports
    {
        public string Owner { get; set; }
        public string Captain { get; set; }


        public Cricket(string name, string owner, string captain)
        {

            TeamName = name;

            Owner = owner;
            Captain = captain;
        }

        public override string DisplayInfo()
        {
            return ($"Cricket Team Name: {TeamName}, Owner: {Owner}, Captain: {Captain}");
        }


    }



     class Management
    {
        private List<Sports> teams = new List<Sports>();
        

        public void AddTeam(Sports Team)
        {
           teams.Add(Team);
        }

        

        public void GetTeamDetails()
        {
            Console.WriteLine("Team List for Football: ");

            foreach(var i in teams)
            {
                Console.WriteLine(i.DisplayInfo());
            }
        }

      
       
    }
    
    public class Program
    {
        static void Main(string[] args)
        {

            Management m = new Management();

            Football team1 = new Football("FC Hexclan", "Sayeduzzaman Islam","Al Momen");
            Football team2 = new Football("Thread Titans", "Tanvir Islam", "Asif Mahmud");
            m.AddTeam(team1);
            m.AddTeam(team2);
           

            Console.WriteLine(" ");

            Cricket team3 = new Cricket("Binary Brain", "Umme Sarah", "Feroj Miah");
            Cricket team4 = new Cricket("Error 404", "Sadia Sazzad Kotha", "Samiul Islam");
            m.AddTeam(team3);
            m.AddTeam(team4);



            m.GetTeamDetails();



        }
    }
}
