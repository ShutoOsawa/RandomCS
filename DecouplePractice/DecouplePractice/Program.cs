using System;

namespace DecouplePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            SportsTeam st = new SportsTeam("sport","team1");
            st.PrintTeamInfo();
        }
    }

    public class SportsTeam
    {
        public string Sport { get; set; }
        public string TeamName { get; set; }

        public SportsTeam(string sport, string teamName)
        {
            Sport = sport;
            TeamName = teamName;
        }

        public void PrintTeamInfo()
        {
            System.Console.WriteLine(Sport + " - " + TeamName);
        }

        public void UpdateTeam()
        {
            System.Console.Write("Enter new team name --> ");
            var newName = Console.ReadLine();
            TeamName = newName;
        }
    }
}
