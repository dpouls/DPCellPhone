using System;
using System.Collections.Generic;
using System.Text;

namespace DPCellPhone
{
    class CellPhone
    {
        private string _brand;
        private string _model;
        private decimal _price;
        /// <summary>
        /// constructor method
        /// </summary>
        public CellPhone()
        {
            _brand = "";
            _model = "";
            _price = 0;
        }
        // set the Price variable with get and set methods
        public decimal Price
        {
            get { return _price; }
            set { _price = value; }
        }
        // set the Model variable with get and set methods

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        // set the Brand variable with get and set methods

        public string Brand
        {
            get { return _brand; }
            set { _brand = value; }
        }
    }
}
