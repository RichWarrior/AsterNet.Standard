using AsterNet.Standard.ARI_1_0.Models;
using System.Collections.Generic;

namespace AsterNet.Standard.ARI_1_0.Events
{
    /// <summary>
    /// Notification that a channel has entered a Stasis application.
    /// </summary>
    public class StasisStartEvent : Event
    {


        /// <summary>
        /// Arguments to the application
        /// </summary>
        public List<string> Args { get; set; }

        /// <summary>
        /// no description provided
        /// </summary>
        public Channel Channel { get; set; }

        /// <summary>
        /// no description provided
        /// </summary>
        public Channel Replace_channel { get; set; }

    }
}
