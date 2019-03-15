using System;
using System.Collections.Generic;
using System.Text;

namespace ExpensesApp.Model
{
   public  class Expenses
    {
        /// <summary>
        /// Gets or sets the name of the expenses.
        /// </summary>
        /// <value>
        /// The name of the expenses.
        /// </value>
        public string ExpensesName { get; set; }
        /// <summary>
        /// Gets or sets the short description.
        /// </summary>
        /// <value>
        /// The short description.
        /// </value>
        public string ShortDescription { get; set; }
        /// <summary>
        /// Gets or sets the amount.
        /// </summary>
        /// <value>
        /// The amount.
        /// </value>
        public double Amount { get; set; }

        /// <summary>
        /// Gets or sets the type of the expenses.
        /// </summary>
        /// <value>
        /// The type of the expenses.
        /// </value>
        public string ExpensesType { get; set; }
        /// <summary>
        /// Gets or sets the date.
        /// </summary>
        /// <value>
        /// The date.
        /// </value>
        public DateTime date { get; set; }
    }
}
