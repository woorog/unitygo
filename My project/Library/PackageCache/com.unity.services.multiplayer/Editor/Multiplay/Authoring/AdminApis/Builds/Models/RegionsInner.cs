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
using Unity.Services.Multiplay.Authoring.Editor.AdminApis.Builds.Http;



namespace Unity.Services.Multiplay.Authoring.Editor.AdminApis.Builds.Models
{
    /// <summary>
    /// A single build install region within a build installs list response.
    /// </summary>
    [Preserve]
    [DataContract(Name = "Regions_inner")]
    internal class RegionsInner
    {
        /// <summary>
        /// A single build install region within a build installs list response.
        /// </summary>
        /// <param name="regionName">The name of a region within a build installs by region breakdown list region.</param>
        /// <param name="completedMachines">The total number of completed machines within a build installs by region breakdown list region.</param>
        /// <param name="pendingMachines">The total number of pending machines within a build installs by region breakdown list region.</param>
        /// <param name="failures">The total number of failed machines within a build installs by region breakdown list region.</param>
        [Preserve]
        public RegionsInner(string regionName, long completedMachines, long pendingMachines, long failures)
        {
            RegionName = regionName;
            CompletedMachines = completedMachines;
            PendingMachines = pendingMachines;
            Failures = failures;
        }

        /// <summary>
        /// The name of a region within a build installs by region breakdown list region.
        /// </summary>
        [Preserve]
        [DataMember(Name = "regionName", IsRequired = true, EmitDefaultValue = true)]
        public string RegionName{ get; }

        /// <summary>
        /// The total number of completed machines within a build installs by region breakdown list region.
        /// </summary>
        [Preserve]
        [DataMember(Name = "completedMachines", IsRequired = true, EmitDefaultValue = true)]
        public long CompletedMachines{ get; }

        /// <summary>
        /// The total number of pending machines within a build installs by region breakdown list region.
        /// </summary>
        [Preserve]
        [DataMember(Name = "pendingMachines", IsRequired = true, EmitDefaultValue = true)]
        public long PendingMachines{ get; }

        /// <summary>
        /// The total number of failed machines within a build installs by region breakdown list region.
        /// </summary>
        [Preserve]
        [DataMember(Name = "failures", IsRequired = true, EmitDefaultValue = true)]
        public long Failures{ get; }

        /// <summary>
        /// Formats a RegionsInner into a string of key-value pairs for use as a path parameter.
        /// </summary>
        /// <returns>Returns a string representation of the key-value pairs.</returns>
        internal string SerializeAsPathParam()
        {
            var serializedModel = "";

            if (RegionName != null)
            {
                serializedModel += "regionName," + RegionName + ",";
            }
            serializedModel += "completedMachines," + CompletedMachines.ToString() + ",";
            serializedModel += "pendingMachines," + PendingMachines.ToString() + ",";
            serializedModel += "failures," + Failures.ToString();
            return serializedModel;
        }

        /// <summary>
        /// Returns a RegionsInner as a dictionary of key-value pairs for use as a query parameter.
        /// </summary>
        /// <returns>Returns a dictionary of string key-value pairs.</returns>
        internal Dictionary<string, string> GetAsQueryParam()
        {
            var dictionary = new Dictionary<string, string>();

            if (RegionName != null)
            {
                var regionNameStringValue = RegionName.ToString();
                dictionary.Add("regionName", regionNameStringValue);
            }

            var completedMachinesStringValue = CompletedMachines.ToString();
            dictionary.Add("completedMachines", completedMachinesStringValue);

            var pendingMachinesStringValue = PendingMachines.ToString();
            dictionary.Add("pendingMachines", pendingMachinesStringValue);

            var failuresStringValue = Failures.ToString();
            dictionary.Add("failures", failuresStringValue);

            return dictionary;
        }
    }
}
