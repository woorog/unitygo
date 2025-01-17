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
    /// The request body to trigger a fleet active build configuration switch.
    /// </summary>
    [Preserve]
    [DataContract(Name = "Fleet_Build_Configuration_Switch_Request_Body")]
    internal class FleetBuildConfigurationSwitchRequestBody
    {
        /// <summary>
        /// The request body to trigger a fleet active build configuration switch.
        /// </summary>
        /// <param name="buildConfigurationId">The ID of the build configuration to switch to.</param>
        /// <param name="timeout">The time to wait before force-restarting the remainin game servers. Formatted as a duration string with a sequence of numbers and time units (e.g. 2m / 1h / 5d). Valid time units are \&quot;ns\&quot;, \&quot;us\&quot; (or \&quot;µs\&quot;), \&quot;ms\&quot;, \&quot;s\&quot;, \&quot;m\&quot;, \&quot;h\&quot;, \&quot;d\&quot;, \&quot;w\&quot;, \&quot;y\&quot;. </param>
        /// <param name="batchSize">The maximum number of machines to process at a time in batches. Optional but recommended. Will default to 20 if not specified.</param>
        [Preserve]
        public FleetBuildConfigurationSwitchRequestBody(long buildConfigurationId, string timeout, long batchSize = 20)
        {
            BuildConfigurationId = buildConfigurationId;
            Timeout = timeout;
            BatchSize = batchSize;
        }

        /// <summary>
        /// The ID of the build configuration to switch to.
        /// </summary>
        [Preserve]
        [DataMember(Name = "buildConfigurationId", IsRequired = true, EmitDefaultValue = true)]
        public long BuildConfigurationId{ get; }
        
        /// <summary>
        /// The time to wait before force-restarting the remainin game servers. Formatted as a duration string with a sequence of numbers and time units (e.g. 2m / 1h / 5d). Valid time units are \&quot;ns\&quot;, \&quot;us\&quot; (or \&quot;µs\&quot;), \&quot;ms\&quot;, \&quot;s\&quot;, \&quot;m\&quot;, \&quot;h\&quot;, \&quot;d\&quot;, \&quot;w\&quot;, \&quot;y\&quot;. 
        /// </summary>
        [Preserve]
        [DataMember(Name = "timeout", IsRequired = true, EmitDefaultValue = true)]
        public string Timeout{ get; }
        
        /// <summary>
        /// The maximum number of machines to process at a time in batches. Optional but recommended. Will default to 20 if not specified.
        /// </summary>
        [Preserve]
        [DataMember(Name = "batchSize", EmitDefaultValue = false)]
        public long BatchSize{ get; }
    
        /// <summary>
        /// Formats a FleetBuildConfigurationSwitchRequestBody into a string of key-value pairs for use as a path parameter.
        /// </summary>
        /// <returns>Returns a string representation of the key-value pairs.</returns>
        internal string SerializeAsPathParam()
        {
            var serializedModel = "";

            serializedModel += "buildConfigurationId," + BuildConfigurationId.ToString() + ",";
            if (Timeout != null)
            {
                serializedModel += "timeout," + Timeout + ",";
            }
            serializedModel += "batchSize," + BatchSize.ToString();
            return serializedModel;
        }

        /// <summary>
        /// Returns a FleetBuildConfigurationSwitchRequestBody as a dictionary of key-value pairs for use as a query parameter.
        /// </summary>
        /// <returns>Returns a dictionary of string key-value pairs.</returns>
        internal Dictionary<string, string> GetAsQueryParam()
        {
            var dictionary = new Dictionary<string, string>();

            var buildConfigurationIdStringValue = BuildConfigurationId.ToString();
            dictionary.Add("buildConfigurationId", buildConfigurationIdStringValue);
            
            if (Timeout != null)
            {
                var timeoutStringValue = Timeout.ToString();
                dictionary.Add("timeout", timeoutStringValue);
            }
            
            var batchSizeStringValue = BatchSize.ToString();
            dictionary.Add("batchSize", batchSizeStringValue);
            
            return dictionary;
        }
    }
}
