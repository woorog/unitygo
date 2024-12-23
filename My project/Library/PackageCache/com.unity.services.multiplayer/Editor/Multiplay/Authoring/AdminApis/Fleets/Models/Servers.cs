//-----------------------------------------------------------------------------
// <auto-generated>
//     This file was generated by the C# SDK Code Generator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//-----------------------------------------------------------------------------


using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.Scripting;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Unity.Services.Multiplay.Authoring.Editor.AdminApis.Fleets.Http;



namespace Unity.Services.Multiplay.Authoring.Editor.AdminApis.Fleets.Models
{
    /// <summary>
    /// Server data for the fleet.
    /// </summary>
    [Preserve]
    [DataContract(Name = "Servers")]
    internal class Servers
    {
        /// <summary>
        /// Server data for the fleet.
        /// </summary>
        /// <param name="all">all param</param>
        /// <param name="cloud">cloud param</param>
        /// <param name="metal">metal param</param>
        [Preserve]
        public Servers(FleetServerBreakdown all, FleetServerBreakdown cloud, FleetServerBreakdown metal)
        {
            All = all;
            Cloud = cloud;
            Metal = metal;
        }

        /// <summary>
        /// Parameter all of Servers
        /// </summary>
        [Preserve]
        [DataMember(Name = "all", IsRequired = true, EmitDefaultValue = true)]
        public FleetServerBreakdown All{ get; }
        
        /// <summary>
        /// Parameter cloud of Servers
        /// </summary>
        [Preserve]
        [DataMember(Name = "cloud", IsRequired = true, EmitDefaultValue = true)]
        public FleetServerBreakdown Cloud{ get; }
        
        /// <summary>
        /// Parameter metal of Servers
        /// </summary>
        [Preserve]
        [DataMember(Name = "metal", IsRequired = true, EmitDefaultValue = true)]
        public FleetServerBreakdown Metal{ get; }
    
        /// <summary>
        /// Formats a Servers into a string of key-value pairs for use as a path parameter.
        /// </summary>
        /// <returns>Returns a string representation of the key-value pairs.</returns>
        internal string SerializeAsPathParam()
        {
            var serializedModel = "";

            if (All != null)
            {
                serializedModel += "all," + All.ToString() + ",";
            }
            if (Cloud != null)
            {
                serializedModel += "cloud," + Cloud.ToString() + ",";
            }
            if (Metal != null)
            {
                serializedModel += "metal," + Metal.ToString();
            }
            return serializedModel;
        }

        /// <summary>
        /// Returns a Servers as a dictionary of key-value pairs for use as a query parameter.
        /// </summary>
        /// <returns>Returns a dictionary of string key-value pairs.</returns>
        internal Dictionary<string, string> GetAsQueryParam()
        {
            var dictionary = new Dictionary<string, string>();

            return dictionary;
        }
    }
}
