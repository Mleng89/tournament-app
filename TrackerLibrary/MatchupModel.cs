using System;
namespace TrackerLibrary
{
    public class MatchupModel
    {
        /// <summary>
        /// Represents the list of matches from the MatchupEntryModel table
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();

        /// <summary>
        /// Represents the winner from the TeamModel table
        /// </summary>
        public TeamModel? Winner { get; set; }

        /// <summary>
        /// Represents what round tournament is in
        /// </summary>
        public int MatchupRound { get; set; }
    }
}

