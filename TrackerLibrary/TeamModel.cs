using System;
namespace TrackerLibrary
{
    public class TeamModel
    {

        /// <summary>
        /// Represents the team members within the team, information taken from the PersonModel table
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();

        /// <summary>
        /// Represents the team's name 
        /// </summary>
        public string? TeamName { get; set; }

       
    }
}

