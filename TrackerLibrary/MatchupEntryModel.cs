namespace TrackerLibrary
{
    public class MatchupEntryModel
    {
        /// <summary>
        /// repsresents one team in the matchup
        /// </summary>
        public TeamModel TeamCompeting { get; set; }
        /// <summary>
        /// represents the score for this partclular team
        /// </summary>
        public double Score { get; set; }
        /// <summary>
        /// represents the matchup that this team came from as a winner
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }
               
        
    }
}
