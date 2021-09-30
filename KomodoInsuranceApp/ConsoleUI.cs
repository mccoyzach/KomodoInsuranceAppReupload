using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoInsuranceApp
{
    class ConsoleUI
    {
        // repo info for seed informatoin
        private DevTeamRepo _teamRepo = new DevTeamRepo();
        private DeveloperRepo _devRepo = new DeveloperRepo();
        public void Run()
        {
            //load the seed information at program start up
            SeedContentList();

            //load up the menu
            MenuOptions();
        }

        
        //show the menu options
        private void MenuOptions()
        {
            bool keeplooping = true;

            while (keeplooping)
            {
                Console.Clear();
                Console.WriteLine("What would you like to do\n \n" +
                    "1. See Existing developers\n" +
                    "2. See Existing Teams\n" +
                    "3. Pluralsight Access List\n" +
                    "0. Quit");
                string response = Console.ReadLine();
                switch (response)
                {
                    case "1":
                        //display the list of devs that already exisit
                        ExistingDevs();
                        keeplooping = false;
                        break;
                    case "2":
                        //display the list of teams that already exisit
                        ExistingTeams();
                        keeplooping = false;
                        break;
                    case "3":
                        //display the list of developers who have pluralsight access
                        SightAccessList();
                        keeplooping = false;
                        break;
                    case "0":
                        //exit out of the program
                        Environment.Exit(0);
                        break;
                    default:
                        //give a message output if a selection is made that is not in the menu
                        Console.WriteLine("Please choose a valid selection. Press any key to continue");
                        Console.ReadLine();
                        break;
                }
            }
        }

        //list of existing developers
        private void ExistingDevs()
        {
            //display the menu options for dealng with the devs
            Console.Clear();
            Console.WriteLine("What would you like to do\n \n" +
                "1. View list of developers\n" +
                "2. Add a single developer\n" +
                "3. Add multiple developers\n" +
                "4. Remove a developer\n" +
                "0. Back");
            //take in the users response
            string response = Console.ReadLine();
            switch (response)
            {
                case "1":
                    //get and display the list of devs from devrepo
                    DisplayAllDevelopers();
                    break;
                case "2":
                    //add single dev to dev repo
                    AddDev();
                    break;
                case "3":
                    //add multiple devs dev repo
                    AddMultiDevs();
                    break;
                case "4":
                    //remove dev from dev repo
                    RemoveDev();
                    break;
                case "0":
                    //go back to the main menu
                    MenuOptions();
                    break;
                default:
                    //give a message output if a selection is made that is not in the menu
                    Console.WriteLine("Please choose a valid selection. Press any key to continue");
                    Console.ReadLine();
                    break;
            }

        }

        //list of existing teams
        private void ExistingTeams()
        {
            //display the menu options for dealng with the teams
            Console.Clear();
            Console.WriteLine("What would you like to do\n \n" +
                "1. View list of teams\n" +
                "2. Add developer to team\n" +
                "3. Remove developer from team\n" +
                "0. back");
            string response = Console.ReadLine();
            switch (response)
            {
                case "1":
                    //get and display the list of teams from team repo
                    DisplayAllTeams();
                    break;
                case "2":
                    //add single dev to the team repo
                    AddDevToTeam();
                    break;
                case "3":
                    //remove dev from the team repo
                    RemoveDevFromTeam();
                    break;
                case "0":
                    //go back to main menu
                    MenuOptions();
                    break;
                default:
                    //give a message output if a selection is made that is not in the menu
                    Console.WriteLine("Please choose a valid selection. Press any key to continue");
                    Console.ReadLine();
                    break;
            }
        }

        //create new teams
        private void CreateNewTeam()
        {
            Console.Clear();

            //creates a new team and stores it in the dev team repo

            //ask if would like to create a new team
            //input team name and team id
            //Add Dev to team repo and update team repo

            Console.WriteLine("this section is still being coded. Press any key to continue");
            Console.ReadLine();
            MenuOptions();

        }

        // add developers
        private void AddDev()
        {
            Console.Clear();

            //adds a developer to the developer repo

            //ask if would like to add a yes or no 
            Console.WriteLine("Would you like to add a new developer\n" +
                "1. Yes\n" +
                "2. No");
            string response = Console.ReadLine();
            switch (response)
            {
                case "1":
                    //get and display the list of teams from team repo
                    AddDeveloperInfo();
                    break;
                case "2":
                    //go back to dev menu
                    ExistingDevs();
                    break;
                default:
                    //give a message output if a selection is made that is not in the menu
                    Console.WriteLine("Please choose a valid selection. Press any key to continue");
                    Console.ReadLine();
                    break;
            }
            //if yes ask to input name id number and if they have access to pluralsight
            //store the infotmation in the dev repo

            Console.WriteLine("this section is still being coded. Press any key to continue");
            Console.ReadLine();
            MenuOptions();

        }


        //adding developer info to the dev repo
        private void AddDeveloperInfo()
        {
            Console.Clear();
            Console.WriteLine("Enter the name of the developer");
            string devname = Console.ReadLine();
            Console.WriteLine("What is this persons ID Number");
            int devid = int.Parse(Console.ReadLine());
            //take users input for 
            //developer name
            //id number
            //access
        }


        //remove  developer
        private void RemoveDev()
        {
            Console.Clear();

            //removes a developer from the dev repo

            //display a list of devs
            DisplayAllDevelopers();
            Console.WriteLine("Which Developer would you like to remove");
            string response = Console.ReadLine();


            //ask which dev to remove
            //remove dev info from dev repo and update the list

            Console.WriteLine("this section is still being coded. Press any key to continue");
            Console.ReadLine();
            MenuOptions();

        }

        // add multiple developers
        private void AddMultiDevs()
        {
            Console.Clear();

            //adds multiple devs to the dev repo at the same time

            //ask if would like to add a yes or no 

            //if yes ask to input name id number and if they have access to pluralsight
            //store the infotmation in the dev repo
            //ask if would like to enter another yes or no

            Console.WriteLine("this section is still being coded. Press any key to continue");
            Console.ReadLine();
            MenuOptions();

        }

        //add developer to a team
        private void AddDevToTeam()
        {
            Console.Clear();

            //adds a dev to a  team and updates the info in the dev team repo

            //show a list of developers not in a team
            //choose one in the menu
            //ask what team do they want to be put on
            //add them to that teams list

            Console.WriteLine("this section is still being coded. Press any key to continue");
            Console.ReadLine();
            MenuOptions();

        }

        //remove a developer from a team
        private void RemoveDevFromTeam()
        {
            Console.Clear();

            //removes a dev from a team and updates the info in the dev team repo

            //select a team member from the menu and ask yes or no if really want to remove and if yes remove them from team list

            Console.WriteLine("this section is still being coded. Press any key to continue");
            Console.ReadLine();
            MenuOptions();

        }

        //developers needing pluralsight access

        private void SightAccessList()
        {
            Console.Clear();

            //dispalays a list of devs who have access to pluralsight and gives an option to add or remove a dev from the list
            
            //run a check to see if developer has access if it is true add it to the list and display it
            
            Console.WriteLine("this section is still being coded. Press any key to continue");
            Console.ReadLine();
            MenuOptions();

        }

        //dev repo info
        private void DisplayAllDevelopers()
        {
            //gets and displays the info from the developer repo list
            Console.Clear();

            List<Developer> listOfDeveloper = _devRepo.GetDeveloperList();
            foreach(var content in listOfDeveloper)
            {
                Console.WriteLine($"{content.DevName}\n" +
                    $"{content.DevID}\n" +
                    $"{content.DevHasAccess}");
                
            }
            Console.ReadLine();
            ExistingDevs();
            
        }


        //team repo info
        private void DisplayAllTeams()
        {
            //gets and displays the info from the team repo list
            Console.Clear();

            List<DevTeam> listOfTeam = _teamRepo.GetTeamList();
            foreach (var content in listOfTeam)
            {
                Console.WriteLine($"{content.TeamName}\n" +
                    $"{content.TeamID}\n" +
                    $"{content.TeamMember}");

            }
            Console.ReadLine();
            ExistingTeams();
        }
                      
    
       

        //pre fill in information in the dev and team lists
        private void SeedContentList()
        {
            Developer sam = new Developer("Sam", 676, false);
            Developer george = new Developer("George", 943, false);
            Developer paul = new Developer("Paul", 134, true);
            Developer grace = new Developer("Grace", 876, true);
            Developer holly = new Developer("Holly", 234, false);

            _devRepo.AddDeveloperToList(sam);
            _devRepo.AddDeveloperToList(george);
            _devRepo.AddDeveloperToList(paul);
            _devRepo.AddDeveloperToList(grace);
            _devRepo.AddDeveloperToList(holly);

            DevTeam dev = new DevTeam("Team Red", 1, 876);
            DevTeam dev1 = new DevTeam("Team Blue", 2, 234);

            _teamRepo.AddTeamsToList(dev);
            _teamRepo.AddTeamsToList(dev1);
        }

        private void Placeholder()
        {
            Console.Clear();
            //dispalays a list of devs who have access to pluralsight and gives an option to add or remove a dev from the list
            //run a check to see if developer has access if it is true add it to the list and display it

            Console.WriteLine("this section is still being coded. Press any key to continue");
            Console.ReadLine();
            MenuOptions();
        }
    }
}
