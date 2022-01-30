using System;
using System.Windows.Forms;
using TrackerLibrary;

namespace TrackerUI
{
    public partial class CreatePrizeForm : Form
    {
        public CreatePrizeForm()
        {
            InitializeComponent();
        }

        private void CreatePrizeForm_Load(object sender, EventArgs e)
        {

        }

        private void PlaceNumberLabel_Click(object sender, EventArgs e)
        {

        }


        private void createPrizeButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PrizeModel model = new PrizeModel(placeNameValue.Text,
                    placeNumberValue.Text,
                    PrizeAmountValue.Text,
                    PrizePercentageValue.Text);

                foreach (IDataConnection db in GlobalConfig.Connections)
                {
                    db.CreatePrize(model);
                }
            }
            else
            {
                MessageBox.Show("This form has invalid information. Please Check and try Again!");
            }
        } 
        private bool ValidateForm()
        {
            bool output = true;
            int placeNumber = 0;
            bool placeNumberValidnumber = int.TryParse(placeNumberValue.Text, out placeNumber);
            if (placeNumberValidnumber==false)
            {
                output = false;
            }
            if(placeNumber<1)
            {
                output =false;
            }
            if (placeNameValue.Text.Length==0)
            {
                output = false;
            }
            decimal prizeAmount = 0;
            double prizePercentage = 0;


            bool prizeAmountValid = decimal.TryParse(PrizeAmountValue.Text, out prizeAmount);
            bool prizePercentageValid =double.TryParse(PrizePercentageValue.Text, out prizePercentage);

            if (prizeAmountValid==false||prizePercentageValid==false)
            {
                output = false;
            }
            if(prizeAmount<=0&&prizePercentage<=0)
            {
                output =false; 
            }
            if(prizePercentage<0||prizePercentage>100)
            {
                output=false;
            }
            return output;
            

        }
        

    }
}
