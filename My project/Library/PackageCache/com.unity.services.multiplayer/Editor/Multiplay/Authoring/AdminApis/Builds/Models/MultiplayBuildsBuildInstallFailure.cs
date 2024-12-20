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
    /// A single build install failure
    /// </summary>
    [Preserve]
    [DataContract(Name = "multiplay.builds.buildInstallFailure")]
    internal class MultiplayBuildsBuildInstallFailure
    {
        /// <summary>
        /// A single build install failure
        /// </summary>
        /// <param name="updated">The time the install job was last updated</param>
        /// <param name="machineID">Machine ID</param>
        /// <param name="reason">Reason of the install failure</param>
        [Preserve]
        public MultiplayBuildsBuildInstallFailure(DateTime updated, long machineID, string reason)
        {
            Updated = updated;
            MachineID = machineID;
            Reason = reason;
        }

        /// <summary>
        /// The time the install job was last updated
        /// </summary>
        [Preserve]
        [DataMember(Name = "updated", IsRequired = true, EmitDefaultValue = true)]
        public DateTime Updated{ get; }

        /// <summary>
        /// Machine ID
        /// </summary>
        [Preserve]
        [DataMember(Name = "machineID", IsRequired = true, EmitDefaultValue = true)]
        public long MachineID{ get; }

        /// <summary>
        /// Reason of the install failure
        /// </summary>
        [Preserve]
        [DataMember(Name = "reason", IsRequired = true, EmitDefaultValue = true)]
        public string Reason{ get; }

        /// <summary>
        /// Formats a MultiplayBuildsBuildInstallFailure into a string of key-value pairs for use as a path parameter.
        /// </summary>
        /// <returns>Returns a string representation of the key-value pairs.</returns>
        internal string SerializeAsPathParam()
        {
            var serializedModel = "";

            if (Updated != null)
            {
                serializedModel += "updated," + Updated.ToString() + ",";
            }
            serializedModel += "machineID," + MachineID.ToString() + ",";
            if (Reason != null)
            {
                serializedModel += "reason," + Reason;
            }
            return serializedModel;
        }

        /// <summary>
        /// Returns a MultiplayBuildsBuildInstallFailure as a dictionary of key-value pairs for use as a query parameter.
        /// </summary>
        /// <returns>Returns a dictionary of string key-value pairs.</returns>
        internal Dictionary<string, string> GetAsQueryParam()
        {
            var dictionary = new Dictionary<string, string>();

            if (Updated != null)
            {
                var updatedStringValue = Updated.ToString();
                dictionary.Add("updated", updatedStringValue);
            }

            var machineIDStringValue = MachineID.ToString();
            dictionary.Add("machineID", machineIDStringValue);

            if (Reason != null)
            {
                var reasonStringValue = Reason.ToString();
                dictionary.Add("reason", reasonStringValue);
            }

            return dictionary;
        }
    }
}
