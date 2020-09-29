using System;
using System.Collections.Generic;
using System.Text;

namespace AsterNet.Standard.ARI_1_0.Models
{
    /// <summary>
    /// Base type for errors and events
    /// </summary>
    public class Message
    {


        /// <summary>
        /// Indicates the type of this message.
        /// </summary>
        public string Type { get; set; }

    }
}
