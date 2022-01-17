﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class PrizeModel
    {
        /// <summary>
        /// represents the position of the team on the prize model
        /// </summary>
        public int PlaceNumber { get; set; }
        /// <summary>
        /// represents the name of the team on this prize model
        /// </summary>
        public string PlaceName { get; set; }
        /// <summary>
        /// represents the amount to be awarded to the winning team
        /// </summary>
        public decimal PrizeAmount { get; set; }
        /// <summary>
        /// represents the percentage of the total collected amount to be awarded to the winning team
        /// </summary>
        public double PrizePercentage { get; set; }

    }
}
