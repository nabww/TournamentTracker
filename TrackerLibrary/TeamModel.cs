using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
   public class TeamModel
    {
        /// <summary>
        /// list of persons within the team
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();
       /// <summary>
       /// the name of the team
       /// </summary>
        public string TeamName { get; set; }
    }
}
