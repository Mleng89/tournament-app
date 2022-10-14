using System;
namespace TrackerLibrary
{
    public class PersonModel
    {
        /// <summary>
        /// Represents a player's first name
        /// </summary>
        public string? FirstName { get; set; }

        /// <summary>
        /// Represents a player's last name 
        /// </summary>
        public string? LastName { get; set; }

        /// <summary>
        /// Represents the player's email address  
        /// </summary>
        public string? EmailAddress { get; set; }

        /// <summary>
        /// Represents the player's contact number (cellphone ideally) 
        /// </summary>
        public string? CellphoneNumber { get; set; }
    }
}

