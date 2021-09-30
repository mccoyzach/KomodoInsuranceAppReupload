using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoInsuranceApp
{
    public class DeveloperRepo
    {
        public List<Developer> _listOfDeveloper = new List<Developer>();
       
        //create
        public void AddDeveloperToList(Developer content)
        {
            _listOfDeveloper.Add(content);
        }

        //read
        public List<Developer> GetDeveloperList()
        {
            return _listOfDeveloper;
        }

        //update
        public bool UpdateExistingDeveloper(string originalName, Developer newContent)
        {
            // finding the name in the list
            Developer oldContent = GetDeveloperByName(originalName);

            //updating the list of names
            if (oldContent != null)
            {
                oldContent.DevName = newContent.DevName;
                oldContent.DevID = newContent.DevID;
                oldContent.DevHasAccess = newContent.DevHasAccess;
                return true;
            }
            else
            {
                return false;
            }
        }

        //delete
        public bool RemoveDeveloperFromList(string name)
        {
            Developer content = GetDeveloperByName(name);

            if(content == null)
            {
                return false;
            }

            int initialCount = _listOfDeveloper.Count;
            _listOfDeveloper.Remove(content);

            if (initialCount > _listOfDeveloper.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //helper method
        private Developer GetDeveloperByName(string name)
        {
            foreach (Developer content in _listOfDeveloper)
            {
                if (content.DevName == name)
                {
                    return content;
                }
            }

            return null;
        }
    }
}