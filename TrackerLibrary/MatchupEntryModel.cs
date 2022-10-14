using System;
namespace TrackerLibrary
{
    public class MatchupEntryModel
    {
        /// <summary>
        /// Represents 1 team 
        /// </summary>
        public TeamModel? TeamCompeting { get; set; }

        /// <summary>
        /// Represents score for particular team
        /// </summary>
        public double Score { get; set; }

        /// <summary>
        /// Represents matcup that this team came from as the winner
        /// </summary>
        public MatchupModel? ParentMatchup { get; set; }
    }
}

