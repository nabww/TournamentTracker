namespace TrackerLibrary
{
    public class SqlConnector : IDataConnection
    {
       ///TODO - make the createprize method to actually save to the database
        /// <summary>
       /// saves a new prize to the model
       /// </summary>
       /// <param name="model"></param>
       /// <returns>the prize information, including the unique identifier</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            model.id=1;
            return model;
        }
    }
}
