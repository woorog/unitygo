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
using Unity.Services.Multiplay.Authoring.Editor.AdminApis.Allocations.Http;



namespace Unity.Services.Multiplay.Authoring.Editor.AdminApis.Allocations.Models
{
    /// <summary>
    /// Response to a request to process a test allocation.
    /// </summary>
    [Preserve]
    [DataContract(Name = "multiplay.allocations.TestAllocateResponse")]
    internal class MultiplayAllocationsTestAllocateResponse
    {
        /// <summary>
        /// Response to a request to process a test allocation.
        /// </summary>
        /// <param name="allocationId">The uuid for the allocation being processed.</param>
        /// <param name="href">The relative path to the allocation resource.</param>
        [Preserve]
        public MultiplayAllocationsTestAllocateResponse(System.Guid allocationId, string href)
        {
            AllocationId = allocationId;
            Href = href;
        }

        /// <summary>
        /// The uuid for the allocation being processed.
        /// </summary>
        [Preserve]
        [DataMember(Name = "allocationId", IsRequired = true, EmitDefaultValue = true)]
        public System.Guid AllocationId{ get; }

        /// <summary>
        /// The relative path to the allocation resource.
        /// </summary>
        [Preserve]
        [DataMember(Name = "href", IsRequired = true, EmitDefaultValue = true)]
        public string Href{ get; }

        /// <summary>
        /// Formats a MultiplayAllocationsTestAllocateResponse into a string of key-value pairs for use as a path parameter.
        /// </summary>
        /// <returns>Returns a string representation of the key-value pairs.</returns>
        internal string SerializeAsPathParam()
        {
            var serializedModel = "";

            if (AllocationId != null)
            {
                serializedModel += "allocationId," + AllocationId + ",";
            }
            if (Href != null)
            {
                serializedModel += "href," + Href;
            }
            return serializedModel;
        }

        /// <summary>
        /// Returns a MultiplayAllocationsTestAllocateResponse as a dictionary of key-value pairs for use as a query parameter.
        /// </summary>
        /// <returns>Returns a dictionary of string key-value pairs.</returns>
        internal Dictionary<string, string> GetAsQueryParam()
        {
            var dictionary = new Dictionary<string, string>();

            if (AllocationId != null)
            {
                var allocationIdStringValue = AllocationId.ToString();
                dictionary.Add("allocationId", allocationIdStringValue);
            }

            if (Href != null)
            {
                var hrefStringValue = Href.ToString();
                dictionary.Add("href", hrefStringValue);
            }

            return dictionary;
        }
    }
}
