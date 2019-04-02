using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Teamwork_Project
{
    class Team
    {
        // Fields
        string creator = null;
        string teamName = null;
        List<string> teamMembersList;
        public static List<Team> allTeamsList = new List<Team>();

        // Constructor
        public Team(string creator, string teamName)
        {
            this.creator = creator;
            this.teamName = teamName;
            teamMembersList = new List<string>();
            teamMembersList.Add(this.creator);
            allTeamsList.Add(this);
        }

        // Properties
        public string Creator
        {
            get { return creator; }
            set { creator = value; }
        }
        public string TeamName
        {
            get { return teamName; }
            set { teamName = value; }
        }
        public List<string> Members
        {
            get { return teamMembersList; }
        }

        // Methods

        // Create Team
        public static void CreateTeam(string creatorName, string teamName)
        {
            bool creatorUnique = true;
            bool teamUnique = true;

            for (int i = 0; i < allTeamsList.Count; i++)
            {
                if (allTeamsList[i].TeamName == teamName)
                {
                    teamUnique = false;
                }

                for (int j = 0; j < allTeamsList[i].Members.Count; j++)
                {
                    if (allTeamsList[i].Members[j] == creatorName)
                    {
                        creatorUnique = false;
                    }
                }
            }

            if (teamUnique == false)
            {
                Console.WriteLine("Team {0} was already created!", teamName);
            }
            else if (creatorUnique == false)
            {
                Console.WriteLine("{0} cannot create another team!", creatorName);
            }
            else if (teamUnique == true && creatorUnique == true)
            {
                Console.WriteLine("Team {0} has been created by {1}!", teamName, creatorName);
                new Team(creatorName, teamName);
            }
        }

        // Add Members
        public static void AddMembers(string memberName, string teamName)
        {
            bool memberExists = false;
            bool teamExists = false;

            for (int i = 0; i < allTeamsList.Count; i++)
            {
                // Check if team exists
                if (allTeamsList[i].TeamName == teamName)
                {
                    teamExists = true;
                }

                // Check if member exists + check creators
                for (int j = 0; j < allTeamsList[i].Members.Count; j++)
                {
                    if (allTeamsList[i].Members[j] == memberName)
                    {
                        memberExists = true;
                    }
                    if (allTeamsList[i].Creator == memberName)
                    {
                        memberExists = true;
                    }
                }
            }

            if (teamExists == false)
            {
                Console.WriteLine("Team {0} does not exist!", teamName);
            }
            else if (memberExists == true)
            {
                Console.WriteLine("Member {0} cannot join team {1}!", memberName, teamName);
            }

            else if (teamExists == true && memberExists == false)
            {
                for (int i = 0; i < allTeamsList.Count; i++)
                {
                    if (allTeamsList[i].TeamName == teamName)
                    {
                        allTeamsList[i].Members.Add(memberName);
                    }
                }
            }
        }

        // Print All Teams, include teams to disband (SORTED)
        public static void PrintAllTeamsSorted()
        {
            // Get a list with all teams with more than 1 team member
            List<Team> teamsToPrint = new List<Team>();
            for (int i = 0; i < allTeamsList.Count; i++)
            {
                if (allTeamsList[i].Members.Count > 1)
                {
                    teamsToPrint.Add(allTeamsList[i]);
                }
            }
            // Get a list with all teams to disband
            List<Team> teamsToDisband = new List<Team>();
            for (int i = 0; i < allTeamsList.Count; i++)
            {
                if (allTeamsList[i].Members.Count <= 1)
                {
                    teamsToDisband.Add(allTeamsList[i]);
                }
            }

            var sortedToPrint = teamsToPrint.Where(x => x.Members.Count > 0).OrderByDescending(x => x.Members.Count).ThenBy(x => x.TeamName).ToList();   //.OrderByDescending(x => x.Members.Count).ThenBy(x => x.TeamName);
            var sortedToDisband = teamsToDisband.OrderBy(x => x.TeamName);

            // Print the list of valid teams
            foreach (var team in sortedToPrint)
            {
                Console.WriteLine("{0}", team.TeamName);
                Console.WriteLine("- {0}", team.Creator);
                for (int j = 1; j < team.Members.Count; j++)
                {
                    Console.WriteLine("-- {0}", team.Members[j]);
                }
            }
            // Print the list of teams to disband
            Console.WriteLine("Teams to disband:");
            foreach (var team in teamsToDisband)
            {
                Console.WriteLine("{0}", team.TeamName);
            }
        }
    }

    class TeamworkProject
    {
        static void Main()
        {
            int numberOfTeams = int.Parse(Console.ReadLine());
            //if (numberOfTeams > 0)
            // Get Teams - and team leaders
            for (int i = 0; i < numberOfTeams; i++)
            {
                string creatorInput = Console.ReadLine();
                char[] separator = new char[] { '-' };
                string[] commandArray = creatorInput.Split(separator, StringSplitOptions.RemoveEmptyEntries);
                Team.CreateTeam(commandArray[0], commandArray[1]);
            }
            // Get all team members
            bool isRunning = true;
            while (isRunning == true)
            {
                string membersInput = Console.ReadLine();
                if (membersInput == "end of assignment")
                {
                    isRunning = false;
                    break;
                }
                else
                {
                    char[] separators = new char[] { '-', '>' };
                    string[] membersInputArray = membersInput.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                    Team.AddMembers(membersInputArray[0], membersInputArray[1]);
                }

            }
            // Print the shit sorted
            Team.PrintAllTeamsSorted();
        }
    }
}
