using AsterNet.Standard.ARI_1_0.Models;

namespace AsterNet.Standard.ARI_1_0.Events
{
    /// <summary>
    /// The state of a peer associated with an endpoint has changed.
    /// </summary>
    public class PeerStatusChangeEvent : Event
    {


        /// <summary>
        /// no description provided
        /// </summary>
        public Endpoint Endpoint { get; set; }

        /// <summary>
        /// no description provided
        /// </summary>
        public Peer Peer { get; set; }

    }
}
