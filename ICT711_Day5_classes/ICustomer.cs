using System;
using System.Collections.Generic;
using System.Text;

namespace ICT711_Day5_classes
{
    public interface ICustomer : IPerson
    {
        int CustomerId { get; set; }
        /// <summary>
        /// The Id of the main associate working with this customer
        /// </summary>
        int MainAssociateId { get; set; }
        /// <summary>
        /// When was the customer first registered. Auto=populate to the current date-time
        /// </summary>
        System.DateTime RegisteredOn { get; set; }
        /// <summary>
        /// Returns a list of all purchased products
        /// </summary>
        /// <param name="sales">List of all sales</param>
        /// <returns>List of all customer's purchases</returns>
        List<ISale> GetPurchases(List<ISale> sales);
        /// <summary>
        /// Gets the full name of the main associate
        /// </summary>
        /// <param name="associatesList">List of all associates</param>
        string GetAssociate(List<IAssociate> associatesList);
    }
}