using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DPCellPhone
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// verify input and set the lbl results to the result by calling numerous methods
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSubmit_Clicked(object sender, EventArgs e)
        {
            // create new instance of CellPhone Class
            CellPhone cellPhone = new CellPhone();
            //if entry inputs are not empty strings, continue, else display alert
            if (EntryBrand.Text != "" && EntryModel.Text != "")
            {
                //set the variables in the cellphone class to the entry inputs
                cellPhone.Brand = EntryBrand.Text;
                cellPhone.Model = EntryBrand.Text;
                //check if price is a decimal
                if (ValidPrice(cellPhone))
                {
                    //if so, display phone details with this method
                    DisplayPhoneDetails(cellPhone);
                }
            }
            else
            {
                DisplayAlert("Invalid Input", "Please fill in the form", "Close");
            }
        }
        /// <summary>
        /// assigns the lblresults.text to the results of all the entries.
        /// </summary>
        /// <param name="cellPhone"></param>
        private void DisplayPhoneDetails(CellPhone cellPhone)
        {
            //assigns the results to lbl.results.text using line breaks.
            LblResults.Text = $"Brand: {cellPhone.Brand}\n" + $"Model: {cellPhone.Model}\n" + $"Price: {cellPhone.Price:c}";
        }
        /// <summary>
        /// checks if price is a decimal
        /// </summary>
        /// <param name="cellPhone"></param>
        /// <returns></returns>
        private bool ValidPrice(CellPhone cellPhone)
        {
            //if price is a decimal set the Price variable in CellPhone class to the input. 
            if (decimal.TryParse(EntryPrice.Text, out decimal price) && price >= 0)
            {
                //set the Price variable to our input value
                cellPhone.Price = price;
                //return true because this is a boolean method
                return true;
            } else
            {
                //if not a decimal, we display an alert
                DisplayAlert("Invalid Input", "Please fill in the form with a positive number for the price", "Close");
                return false;
            }
        }
    }
}
