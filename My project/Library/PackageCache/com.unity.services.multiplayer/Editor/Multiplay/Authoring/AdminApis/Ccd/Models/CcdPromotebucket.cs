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
using Unity.Services.Multiplay.Authoring.Editor.AdminApis.Ccd.Http;



namespace Unity.Services.Multiplay.Authoring.Editor.AdminApis.Ccd.Models
{
    /// <summary>
    /// CcdPromotebucket model
    /// </summary>
    [Preserve]
    [DataContract(Name = "ccd.promotebucket")]
    internal class CcdPromotebucket
    {
        /// <summary>
        /// Creates an instance of CcdPromotebucket.
        /// </summary>
        /// <param name="fromRelease">fromRelease param</param>
        /// <param name="toBucket">toBucket param</param>
        /// <param name="notes">If unset, the release notes of the \&quot;from release\&quot; will be used.</param>
        /// <param name="toEnvironment">If unset, the environment of the \&quot;from_release\&quot; will be used.</param>
        [Preserve]
        public CcdPromotebucket(System.Guid fromRelease, System.Guid toBucket, string notes = default, System.Guid toEnvironment = default)
        {
            FromRelease = fromRelease;
            Notes = notes;
            ToBucket = toBucket;
            ToEnvironment = toEnvironment;
        }

        /// <summary>
        /// Parameter from_release of CcdPromotebucket
        /// </summary>
        [Preserve]
        [DataMember(Name = "from_release", IsRequired = true, EmitDefaultValue = true)]
        public System.Guid FromRelease{ get; }

        /// <summary>
        /// If unset, the release notes of the \&quot;from release\&quot; will be used.
        /// </summary>
        [Preserve]
        [DataMember(Name = "notes", EmitDefaultValue = false)]
        public string Notes{ get; }

        /// <summary>
        /// Parameter to_bucket of CcdPromotebucket
        /// </summary>
        [Preserve]
        [DataMember(Name = "to_bucket", IsRequired = true, EmitDefaultValue = true)]
        public System.Guid ToBucket{ get; }

        /// <summary>
        /// If unset, the environment of the \&quot;from_release\&quot; will be used.
        /// </summary>
        [Preserve]
        [DataMember(Name = "to_environment", EmitDefaultValue = false)]
        public System.Guid ToEnvironment{ get; }

        /// <summary>
        /// Formats a CcdPromotebucket into a string of key-value pairs for use as a path parameter.
        /// </summary>
        /// <returns>Returns a string representation of the key-value pairs.</returns>
        internal string SerializeAsPathParam()
        {
            var serializedModel = "";

            if (FromRelease != null)
            {
                serializedModel += "from_release," + FromRelease + ",";
            }
            if (Notes != null)
            {
                serializedModel += "notes," + Notes + ",";
            }
            if (ToBucket != null)
            {
                serializedModel += "to_bucket," + ToBucket + ",";
            }
            if (ToEnvironment != null)
            {
                serializedModel += "to_environment," + ToEnvironment;
            }
            return serializedModel;
        }

        /// <summary>
        /// Returns a CcdPromotebucket as a dictionary of key-value pairs for use as a query parameter.
        /// </summary>
        /// <returns>Returns a dictionary of string key-value pairs.</returns>
        internal Dictionary<string, string> GetAsQueryParam()
        {
            var dictionary = new Dictionary<string, string>();

            if (FromRelease != null)
            {
                var from_releaseStringValue = FromRelease.ToString();
                dictionary.Add("from_release", from_releaseStringValue);
            }

            if (Notes != null)
            {
                var notesStringValue = Notes.ToString();
                dictionary.Add("notes", notesStringValue);
            }

            if (ToBucket != null)
            {
                var to_bucketStringValue = ToBucket.ToString();
                dictionary.Add("to_bucket", to_bucketStringValue);
            }

            if (ToEnvironment != null)
            {
                var to_environmentStringValue = ToEnvironment.ToString();
                dictionary.Add("to_environment", to_environmentStringValue);
            }

            return dictionary;
        }
    }
}
