using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class MatchupModel
    {
        /// <summary>
        /// represents the matchup entry in the matchup list
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();
        /// <summary>
        /// represents the winning team in the matchup
        /// </summary>
        public TeamModel Winner { get; set; }
        /// <summary>
        /// /represents the current round
        /// </summary>
        public int MatchupRound { get; set; }

    }
}
