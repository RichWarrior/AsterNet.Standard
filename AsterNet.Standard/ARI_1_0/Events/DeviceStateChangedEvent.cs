using AsterNet.Standard.ARI_1_0.Models;

namespace AsterNet.Standard.ARI_1_0.Events
{
    /// <summary>
    /// Notification that a device state has changed.
    /// </summary>
    public class DeviceStateChangedEvent : Event
    {


        /// <summary>
        /// Device state object
        /// </summary>
        public DeviceState Device_state { get; set; }

    }
}
