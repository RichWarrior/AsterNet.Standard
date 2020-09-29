using AsterNet.Standard.ARI_1_0.Models;

namespace AsterNet.Standard.ARI_1_0.Events
{
    /// <summary>
    /// Endpoint state changed.
    /// </summary>
    public class EndpointStateChangeEvent : Event
    {


        /// <summary>
        /// no description provided
        /// </summary>
        public Endpoint Endpoint { get; set; }

    }
}
