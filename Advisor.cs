using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedObjects
{
    internal class Advisor
    {
        public string FullName { get; set; }
        /// <summary>
        /// Employees full legal name
        /// </summary>
        public string SchoolEmail { get; set; }
        /// <summary>
        /// employees assigned work email
        /// </summary>
        public string OfficeLocation { get; set; }
        /// <summary>
        /// Where the employees personal office is located
        /// </summary>
        public string PhoneNumber { get; set; }
        /// <summary>
        /// The employees work phone number
        /// </summary>
        public Advisor AssignedAdvisor { get; set; }
        /// <summary>
        /// The employees Assigned Advisor
        /// </summary>


    }
}
