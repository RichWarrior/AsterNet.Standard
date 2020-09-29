﻿using AsterNet.Standard.ARI_1_0.Models;

namespace AsterNet.Standard.ARI_1_0.Events
{

    /// <summary>
    /// Event showing the start of a recording operation.
    /// </summary>
    public class RecordingStartedEvent : Event
    {


        /// <summary>
        /// Recording control object
        /// </summary>
        public LiveRecording Recording { get; set; }

    }
}
