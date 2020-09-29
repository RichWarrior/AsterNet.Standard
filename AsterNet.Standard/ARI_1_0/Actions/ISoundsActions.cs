﻿using AsterNet.Standard.ARI_1_0.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AsterNet.Standard.ARI_1_0.Actions
{
    public interface ISoundsActions
    {
        /// <summary>
        /// List all sounds.. 
        /// </summary>
        /// <param name="lang">Lookup sound for a specific language.</param>
        /// <param name="format">Lookup sound in a specific format.</param>
        List<Sound> List(string lang = null, string format = null);
        /// <summary>
        /// Get a sound's details.. 
        /// </summary>
        /// <param name="soundId">Sound's id</param>
        Sound Get(string soundId);

        /// <summary>
        /// List all sounds.. 
        /// </summary>
        /// <param name="lang">Lookup sound for a specific language.</param>
        /// <param name="format">Lookup sound in a specific format.</param>
        Task<List<Sound>> ListAsync(string lang = null, string format = null);
        /// <summary>
        /// Get a sound's details.. 
        /// </summary>
        /// <param name="soundId">Sound's id</param>
        Task<Sound> GetAsync(string soundId);
    }
}
