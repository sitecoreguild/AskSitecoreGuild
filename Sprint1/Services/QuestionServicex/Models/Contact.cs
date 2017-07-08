using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuestionService.Models
{
    /// <summary>
    /// General Contact Record
    /// </summary>
    public class Contact //  TO DO: Should use general CRM IContact Interface but for now use it here.
    {
        /// <summary>
        /// Unique ID representing this contact
        /// </summary>
        public virtual string Id { get; set; }

        #region Tombstone

        /// <summary>
        /// Contact Full Name (Prefix + FirstName + MiddleName + LastName + Suffix)
        /// </summary>
        public virtual string ContactName { get; set; }

        /// <summary>
        /// Contact Prefix (eg. Dr, etc) 
        /// </summary>
        public virtual string Prefix { get; set; }

        /// <summary>
        /// First Name of Contact (eg. Tom, Dick, Jane)
        /// </summary>
        public virtual string FirstName { get; set; }

        /// <summary>
        /// Middle Name of Contact
        /// </summary>
        public virtual string MiddleName { get; set; }

        /// <summary>
        /// Last Name of Contact
        /// </summary>
        public virtual string LastName { get; set; }

        /// <summary>
        /// Contact Suffix
        /// </summary>
        public virtual string Suffix { get; set; }

        #endregion
    }
}