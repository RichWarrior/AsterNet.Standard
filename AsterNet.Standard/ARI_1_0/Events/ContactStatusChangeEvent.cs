using AsterNet.Standard.ARI_1_0.Models;

namespace AsterNet.Standard.ARI_1_0.Events
{
    /// <summary>
    /// The state of a contact on an endpoint has changed.
    /// </summary>
    public class ContactStatusChangeEvent : Event
    {


        /// <summary>
        /// no description provided
        /// </summary>
        public Endpoint Endpoint { get; set; }

        /// <summary>
        /// no description provided
        /// </summary>
        public ContactInfo Contact_info { get; set; }

    }
}
