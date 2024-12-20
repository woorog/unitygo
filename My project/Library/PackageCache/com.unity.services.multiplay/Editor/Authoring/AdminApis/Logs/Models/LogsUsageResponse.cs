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
using Unity.Services.Multiplay.Authoring.Editor.AdminApis.Logs.Http;



namespace Unity.Services.Multiplay.Authoring.Editor.AdminApis.Logs.Models
{
    /// <summary>
    /// Usage information for the project.
    /// </summary>
    [Preserve]
    [DataContract(Name = "Logs_Usage_Response")]
    internal class LogsUsageResponse
    {
        /// <summary>
        /// Usage information for the project.
        /// </summary>
        /// <param name="usage">Current usage in bytes</param>
        /// <param name="capacity">Total available capacity in bytes</param>
        /// <param name="remaining">Remaining capacity in bytes, capacity - usage.</param>
        [Preserve]
        public LogsUsageResponse(double usage, double capacity, double remaining)
        {
            Usage = usage;
            Capacity = capacity;
            Remaining = remaining;
        }

        /// <summary>
        /// Current usage in bytes
        /// </summary>
        [Preserve]
        [DataMember(Name = "usage", IsRequired = true, EmitDefaultValue = true)]
        public double Usage{ get; }
        
        /// <summary>
        /// Total available capacity in bytes
        /// </summary>
        [Preserve]
        [DataMember(Name = "capacity", IsRequired = true, EmitDefaultValue = true)]
        public double Capacity{ get; }
        
        /// <summary>
        /// Remaining capacity in bytes, capacity - usage.
        /// </summary>
        [Preserve]
        [DataMember(Name = "remaining", IsRequired = true, EmitDefaultValue = true)]
        public double Remaining{ get; }
    
        /// <summary>
        /// Formats a LogsUsageResponse into a string of key-value pairs for use as a path parameter.
        /// </summary>
        /// <returns>Returns a string representation of the key-value pairs.</returns>
        internal string SerializeAsPathParam()
        {
            var serializedModel = "";

            serializedModel += "usage," + Usage.ToString() + ",";
            serializedModel += "capacity," + Capacity.ToString() + ",";
            serializedModel += "remaining," + Remaining.ToString();
            return serializedModel;
        }

        /// <summary>
        /// Returns a LogsUsageResponse as a dictionary of key-value pairs for use as a query parameter.
        /// </summary>
        /// <returns>Returns a dictionary of string key-value pairs.</returns>
        internal Dictionary<string, string> GetAsQueryParam()
        {
            var dictionary = new Dictionary<string, string>();

            var usageStringValue = Usage.ToString();
            dictionary.Add("usage", usageStringValue);
            
            var capacityStringValue = Capacity.ToString();
            dictionary.Add("capacity", capacityStringValue);
            
            var remainingStringValue = Remaining.ToString();
            dictionary.Add("remaining", remainingStringValue);
            
            return dictionary;
        }
    }
}