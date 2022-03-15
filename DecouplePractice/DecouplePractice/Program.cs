using System;
using System.Collections.Generic;

namespace DecouplePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            var productionConsole = new ProductionConsole();

            SportsTeam st = new SportsTeam("sport","team1",productionConsole);
            st.PrintTeamInfo();

            st.UpdateTeam();
            st.PrintTeamInfo();

        }
    }

    public class SimpleSportsTeam
    {
        public string Sport { get; set; }
        public string TeamName { get; set; }

        public SimpleSportsTeam(string sport, string teamName)
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

    public class SportsTeam
    {
        public string Sport { get; set; }
        public string TeamName { get; set; }

        private IConsole Console { get; }
        public SportsTeam(string sport, string teamName, IConsole console)
        {

            if(console == null)
            {
                throw new ArgumentNullException(nameof(console));
            }
            Sport = sport;
            TeamName = teamName;
            Console = console;
        }

        public void PrintTeamInfo()
        {
            Console.WriteLine(Sport + " - " + TeamName);
        }

        public void UpdateTeam()
        {
            Console.Write("Enter new team name --> ");
            var newName = Console.ReadLine();
            TeamName = newName;
        }
    }

    public interface IConsole
    {
        void Write(string value);
        void WriteLine(string value);
        string ReadLine();
    }

    public class ProductionConsole : IConsole
    {
        public void Write(string value)
        {
            System.Console.Write(value);
        }

        public void WriteLine(string value)
        {
            System.Console.WriteLine(value);
        }

        public string ReadLine()
        {
            return System.Console.ReadLine();
        }
    }

    public class TestableConsole : IConsole
    {

        public TestableConsole()
        {
            WrittenLines = new List<string>();
        }

        public List<string> WrittenLines { get; set; }
        public void Write(string value)
        {
            WrittenLines.Add(value);
        }

        public void WriteLine(string value)
        {
            WrittenLines.Add(value);
        }

        public string LineToRead { get; set; }

        public string ReadLine()
        {
            return LineToRead;
        }
    }

}
