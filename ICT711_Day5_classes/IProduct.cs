using System;
using System.Collections.Generic;
using System.Text;

namespace ICT711_Day5_classes
{
    public interface IProduct
    {

        int ProductId { get; set; }
        string ProductName { get; set; }
        string Description { get; set; }
        decimal Price { get; set; }
        /// <summary>
        /// Available quantity
        /// </summary>
        int Quantity { get; set; }
        /// <summary>
        /// Returns the sub total. Should be defined as virtual
        /// </summary>
        decimal GetSubTotal();
    }
}