﻿/*
	AsterNET ARI Framework
	Automatically generated file @ 9/22/2016 4:43:49 PM
*/
using System;
using System.Collections.Generic;
using AsterNet.Standard.Actions;

namespace AsterNet.Standard.Models
{
    /// <summary>
    /// Notification that a channel has left a bridge.
    /// </summary>
    public class ChannelLeftBridgeEvent : Event
    {


        /// <summary>
        /// no description provided
        /// </summary>
        public Bridge Bridge { get; set; }

        /// <summary>
        /// no description provided
        /// </summary>
        public Channel Channel { get; set; }

    }
}
