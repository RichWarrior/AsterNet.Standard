namespace AsterNet.Standard.ARI_1_0.Models
{
    /// <summary>
    /// A key/value pair that makes up part of a configuration object.
    /// </summary>
    public class ConfigTuple
    {


        /// <summary>
        /// A configuration object attribute.
        /// </summary>
        public string Attribute { get; set; }

        /// <summary>
        /// The value for the attribute.
        /// </summary>
        public string Value { get; set; }

    }
}
