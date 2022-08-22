using System;
using System.Collections.Generic;
using System.Text;

namespace ICT711_Day5_classes
{
    public interface IAssociate : IPerson
    {
        int AssociateId { get; set; }
        /// <summary>
        /// The department
        /// </summary>
        string Department { get; set; }
        /// <summary>
        /// The job description
        /// </summary>
        string JobDescription { get; set; }
        /// <summary>
        /// The manager Id
        /// </summary>
        int ManagerId { get; set; }
        /// <summary>
        /// Gets the manager full name
        /// </summary>
        /// <param name="associateList">List of all associates</param>
        string GetManager(List<IAssociate> associateList);
    }
}