using AsterNet.Standard.ARI_1_0.Models;

namespace AsterNet.Standard.ARI_1_0.Events
{
    /// <summary>
    /// Notification that one bridge has merged into another.
    /// </summary>
    public class BridgeMergedEvent : Event
    {


        /// <summary>
        /// no description provided
        /// </summary>
        public Bridge Bridge { get; set; }

        /// <summary>
        /// no description provided
        /// </summary>
        public Bridge Bridge_from { get; set; }

    }
}
