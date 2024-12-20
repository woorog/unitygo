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
    /// Server breakdown for the fleet.
    /// </summary>
    [Preserve]
    [DataContract(Name = "multiplay.fleetGenericServers")]
    internal class MultiplayFleetGenericServers
    {
        /// <summary>
        /// Server breakdown for the fleet.
        /// </summary>
        /// <param name="total">Total count of servers of this type.</param>
        /// <param name="status">status param</param>
        [Preserve]
        public MultiplayFleetGenericServers(int total, ServerStatus status)
        {
            Total = total;
            Status = status;
        }

        /// <summary>
        /// Total count of servers of this type.
        /// </summary>
        [Preserve]
        [DataMember(Name = "total", IsRequired = true, EmitDefaultValue = true)]
        public int Total{ get; }
        
        /// <summary>
        /// Parameter status of MultiplayFleetGenericServers
        /// </summary>
        [Preserve]
        [DataMember(Name = "status", IsRequired = true, EmitDefaultValue = true)]
        public ServerStatus Status{ get; }
    
        /// <summary>
        /// Formats a MultiplayFleetGenericServers into a string of key-value pairs for use as a path parameter.
        /// </summary>
        /// <returns>Returns a string representation of the key-value pairs.</returns>
        internal string SerializeAsPathParam()
        {
            var serializedModel = "";

            serializedModel += "total," + Total.ToString() + ",";
            if (Status != null)
            {
                serializedModel += "status," + Status.ToString();
            }
            return serializedModel;
        }

        /// <summary>
        /// Returns a MultiplayFleetGenericServers as a dictionary of key-value pairs for use as a query parameter.
        /// </summary>
        /// <returns>Returns a dictionary of string key-value pairs.</returns>
        internal Dictionary<string, string> GetAsQueryParam()
        {
            var dictionary = new Dictionary<string, string>();

            var totalStringValue = Total.ToString();
            dictionary.Add("total", totalStringValue);
            
            return dictionary;
        }
    }
}