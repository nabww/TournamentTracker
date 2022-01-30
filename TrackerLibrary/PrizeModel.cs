namespace TrackerLibrary
{
    public class PrizeModel
    {
        
        
        
        
        /// <summary>
        /// unique identifier for price
        /// </summary>
        public int id { get; set; }

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


        public PrizeModel()
        {
                    
        }
        public PrizeModel(string placeName, string placeNumber, string prizeAmount, string prizePercentage)
        {
            placeName = placeName;
            int placeNumberValue = 0;
            int.TryParse(placeNumber, out placeNumberValue);
            PlaceNumber = placeNumberValue;

            decimal PrizeAmountValue = 0;
            decimal.TryParse(prizeAmount, out PrizeAmountValue);
            PrizeAmount = PrizeAmountValue;

            double PrizePercentageValue = 0;
            double.TryParse(prizePercentage, out PrizePercentageValue);
            PrizePercentage = PrizePercentageValue;


        }
    }
}
