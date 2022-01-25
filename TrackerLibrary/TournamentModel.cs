namespace TrackerLibrary
{
    public class TournamentModel
    {
        /// <summary>
        /// represents the name of the tournament
        /// </summary>
        public string TournamentName { get; set; }
        /// <summary>
        /// the amount paid in to join the tournament
        /// </summary>
        public decimal EntryFee { get; set; }
        /// <summary>
        /// a list of teams currently in the torunament
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();
        /// <summary>
        /// the prize to be awarded
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();
        /// <summary>
        /// a list of lists of matchups
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
    }
}
