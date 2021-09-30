using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoInsuranceApp
{
    public class DevTeamRepo
    {
        public List<DevTeam> _listOfTeams = new List<DevTeam>();

        //create
        public void AddTeamsToList(DevTeam content)
        {
            _listOfTeams.Add(content);
        }

        //read
        public List<DevTeam> GetTeamList()
        {
            return _listOfTeams;
        }
       
        //update
        public bool UpdateExistingContent(string originalName, DevTeam newContent)
        {
            // finding the name in the list
            DevTeam oldContent = GetTeamByName(originalName);

            //updating the list of names
            if (oldContent != null)
            {
                oldContent.TeamName = newContent.TeamName;
                oldContent.TeamID = newContent.TeamID;
                return true;
            }
            else
            {
                return false;
            }
        }
        
        //delete
        public bool RemoveContentFromList(string name)
        {
            DevTeam content = GetTeamByName(name);

            if (content == null)
            {
                return false;
            }

            int initialCount = _listOfTeams.Count;
            _listOfTeams.Remove(content);

            if (initialCount > _listOfTeams.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        //helper method
        private DevTeam GetTeamByName(string name)
        {
            foreach (DevTeam content in _listOfTeams)
            {
                if (content.TeamName == name)
                {
                    return content;
                }
            }

            return null;
        }
    }
}