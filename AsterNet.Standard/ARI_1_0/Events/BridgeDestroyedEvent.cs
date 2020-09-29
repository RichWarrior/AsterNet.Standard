﻿using AsterNet.Standard.ARI_1_0.Models;

namespace AsterNet.Standard.ARI_1_0.Events
{
    /// <summary>
    /// Notification that a bridge has been destroyed.
    /// </summary>
    public class BridgeDestroyedEvent : Event
    {


        /// <summary>
        /// no description provided
        /// </summary>
        public Bridge Bridge { get; set; }

    }
}
