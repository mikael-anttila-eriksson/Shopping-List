using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A7_Shopping_List
{
    /// <summary>
    /// Products for the Shopping list. 
    /// amount, quantity and units are optional
    /// </summary>
    class Product
    {
        //Fields
        private string name;
        private decimal amount;
        private double quantity;
        //private string comment;
        private Units unit;
        //---------------------------------------------------------------
        #region Constructor
        public Product() : this(string.Empty)
        {

        }
        /// <summary>
        /// Constructor, Product woth default values
        /// </summary>
        /// <param name="name"></param>
        public Product(string name) : this(name, 1, 0.0, (Units)0)
        {
            
        }
        public Product(string name, decimal amount, double quantity, Units unit)
        {
            this.name = name;
            this.amount = amount;
            this.quantity = quantity;
            //this.comment = comment;
            this.unit = unit;
        }
        /// <summary>
        /// Copy constructor
        /// </summary>
        /// <param listName="copy"></param>
        public Product(Product copy)
        {
            this.name = copy.name;
            this.amount = copy.amount;
            this.quantity = copy.quantity;
            //this.comment = copy.comment;
            this.unit = copy.unit;
        }
        #endregion
        //---------------------------------------------------------------
        #region Properties
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    name = value;
                }
            }
        }
        public decimal Amount
        {
            get { return amount; }
            set { amount = value; }
        }
        public double Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        
        
        public Units Unit
        {
            get { return unit; }
            set { unit = value; }
        }
        #endregion
        //---------------------------------------------------------------
        #region Methods
        /// <summary>
        /// My type of string ;P
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string Amount = amount.ToString();
            string Quantity = quantity.ToString();
            string Unit = unit.ToString();
            if (amount == 1)
            {
                Amount = string.Empty;
            }
            if (quantity == 0)
            {
                Quantity = string.Empty;
            }
            if (unit == Units.Select)
            {
                Unit = string.Empty;
            }
            
            string strOut = string.Format("{0, -2} {1, -14} {2, -4} {3, -4}",
                Amount, name, Quantity, Unit);
            return strOut;
        }
        #endregion
        //---------------------------------------------------------------
    }
}
