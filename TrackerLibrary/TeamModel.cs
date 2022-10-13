using System;
namespace TrackerLibrary
{
    public class TeamModel
    {
        public List<PersonModel> TeamMembers { get; set; } = new List<Person>();
        public string TeamName { get; set; }

       
    }
}

