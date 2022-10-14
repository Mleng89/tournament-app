using System;
namespace TrackerLibrary
{
    public class PrizeModel
    {
        /// <summary>
        /// Represents the place number the team recieved
        /// </summary>
        public int PlaceNumber{ get; set; }

        /// <summary>
        /// Represents the name that corresponds with place
        /// ie: champion, first runner up, second runner up
        /// </summary>
        public string? PlaceName { get; set; }

        /// <summary>
        /// Represents the prize pot 
        /// </summary>
        public decimal PrizeAmount { get; set; }

        /// <summary>
        /// Represents the percentage the team is receiving
        /// </summary>
        public double PrizePercentage { get; set; }
    }
}

