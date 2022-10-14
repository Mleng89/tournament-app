using System;
namespace TrackerLibrary
{
    public class TournamentModel
    {
        /// <summary>
        /// Represents the name of the Tournament
        /// </summary>
        public string? TournamentName { get; set; }

        /// <summary>
        /// Represents the entry fee in order to participate
        /// </summary>
        public decimal EntryFee { get; set; }

        /// <summary>
        /// Represents a list of eligible/entered teams from the TeamModel table
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();

        /// <summary>
        /// Represents a list of prizes for the tournament, from PrizeModel table
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();

        /// <summary>
        /// Represents a 2D list of rounds that will be taking place in the tournment
        /// information taken from the MatchUpModel table
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
    }
}
