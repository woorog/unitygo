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
    /// Log entries found along with their metadata.
    /// </summary>
    [Preserve]
    [DataContract(Name = "multiplay.logSearchResponse.v1")]
    internal class MultiplayLogSearchResponseV1
    {
        /// <summary>
        /// Log entries found along with their metadata.
        /// </summary>
        /// <param name="count">Number of results returned.</param>
        /// <param name="hits">Log entries returned by the search.</param>
        /// <param name="paginationToken">A token used to fetch the next page of results. If provided, all other fields are ignored.</param>
        [Preserve]
        public MultiplayLogSearchResponseV1(decimal count, List<LogEntry> hits, string paginationToken)
        {
            Count = count;
            Hits = hits;
            PaginationToken = paginationToken;
        }

        /// <summary>
        /// Number of results returned.
        /// </summary>
        [Preserve]
        [DataMember(Name = "count", IsRequired = true, EmitDefaultValue = true)]
        public decimal Count{ get; }

        /// <summary>
        /// Log entries returned by the search.
        /// </summary>
        [Preserve]
        [DataMember(Name = "hits", IsRequired = true, EmitDefaultValue = true)]
        public List<LogEntry> Hits{ get; }

        /// <summary>
        /// A token used to fetch the next page of results. If provided, all other fields are ignored.
        /// </summary>
        [Preserve]
        [DataMember(Name = "paginationToken", IsRequired = true, EmitDefaultValue = true)]
        public string PaginationToken{ get; }

        /// <summary>
        /// Formats a MultiplayLogSearchResponseV1 into a string of key-value pairs for use as a path parameter.
        /// </summary>
        /// <returns>Returns a string representation of the key-value pairs.</returns>
        internal string SerializeAsPathParam()
        {
            var serializedModel = "";

            serializedModel += "count," + Count.ToString() + ",";
            if (Hits != null)
            {
                serializedModel += "hits," + Hits.ToString() + ",";
            }
            if (PaginationToken != null)
            {
                serializedModel += "paginationToken," + PaginationToken;
            }
            return serializedModel;
        }

        /// <summary>
        /// Returns a MultiplayLogSearchResponseV1 as a dictionary of key-value pairs for use as a query parameter.
        /// </summary>
        /// <returns>Returns a dictionary of string key-value pairs.</returns>
        internal Dictionary<string, string> GetAsQueryParam()
        {
            var dictionary = new Dictionary<string, string>();

            var countStringValue = Count.ToString();
            dictionary.Add("count", countStringValue);

            if (PaginationToken != null)
            {
                var paginationTokenStringValue = PaginationToken.ToString();
                dictionary.Add("paginationToken", paginationTokenStringValue);
            }

            return dictionary;
        }
    }
}
