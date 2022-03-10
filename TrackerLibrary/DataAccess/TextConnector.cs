namespace TrackerLibrary
{
    public class TextConnector : IDataConnection
    {
        /// <summary>
        /// TODO - WIRE up the CreatePrize text files
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            model.id=1;
            return model;
        }
    }
}
