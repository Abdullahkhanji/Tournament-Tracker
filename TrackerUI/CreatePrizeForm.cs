using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.DataAccess;
using TrackerLibrary.Modals;


namespace TrackerUI
{
    public partial class CreatePrizeForm : Form
    {
        IPrizeRequester callingForm;
        public CreatePrizeForm(IPrizeRequester caller)
        {
            InitializeComponent();

            callingForm = caller;
        }

        private void createPrizeBtn_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PrizeModel model = new PrizeModel(
                    placeNameValue.Text,
                    placeNumValue.Text,
                    prizeAmountValue.Text,
                    prizePerValue.Text);


                GlobalConfig.Connection.CreatePrize(model);

                callingForm.PrizeComplete(model);

                placeNameValue.Text = "";
                placeNumValue.Text = "";
                prizeAmountValue.Text = "0";
                prizePerValue.Text = "0";

                this.Close();

            }
            else
            {
                MessageBox.Show("This form has invalid information");
            }
        }

        private bool ValidateForm()
        {
            bool output = true;
            int PlaceNumber = 0;
            bool PlaceNumValidNum = int.TryParse(placeNumValue.Text, out PlaceNumber);

            if (!PlaceNumValidNum)
            {
                output = false;
            }
            if (PlaceNumber < 1)
            {
                output = false;
            }
            if (placeNameValue.Text.Length == 0)
            {
                output = false;
            }

            decimal PrizeAmount = 0;
            double PrizePer = 0;

            bool PrizeAmountValid = decimal.TryParse(prizeAmountValue.Text, out PrizeAmount);
            bool PrizePerValid = double.TryParse(prizePerValue.Text, out PrizePer);

            if (!PrizeAmountValid || !PrizePerValid)
            {
                output = false;
            }
            if (PrizeAmount <= 0 && PrizePer <= 0)
            {
                output = false;
            }
            return output;
        }

        private void CreatePrizeForm_Load(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
