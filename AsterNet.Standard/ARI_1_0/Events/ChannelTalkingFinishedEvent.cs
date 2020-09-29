using AsterNet.Standard.ARI_1_0.Models;

namespace AsterNet.Standard.ARI_1_0.Events
{
    /// <summary>
    /// Talking is no longer detected on the channel.
    /// </summary>
    public class ChannelTalkingFinishedEvent : Event
    {


        /// <summary>
        /// The channel on which talking completed.
        /// </summary>
        public Channel Channel { get; set; }

        /// <summary>
        /// The length of time, in milliseconds, that talking was detected on the channel
        /// </summary>
        public int Duration { get; set; }

    }
}
