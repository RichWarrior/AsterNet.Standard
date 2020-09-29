using AsterNet.Standard.ARI_1_0.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AsterNet.Standard.ARI_1_0.Events
{
    /// <summary>
    /// A text message was received from an endpoint.
    /// </summary>
    public class TextMessageReceivedEvent : Event
    {


        /// <summary>
        /// no description provided
        /// </summary>
        public TextMessage Message { get; set; }

        /// <summary>
        /// no description provided
        /// </summary>
        public Endpoint Endpoint { get; set; }

    }
}
