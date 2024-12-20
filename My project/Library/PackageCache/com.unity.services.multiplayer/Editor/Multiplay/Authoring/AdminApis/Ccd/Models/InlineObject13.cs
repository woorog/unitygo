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
    /// InlineObject13 model
    /// </summary>
    [Preserve]
    [DataContract(Name = "inline_object_13")]
    internal class InlineObject13
    {
        /// <summary>
        /// Creates an instance of InlineObject13.
        /// </summary>
        /// <param name="entries">entries param</param>
        /// <param name="metadata">metadata param</param>
        /// <param name="notes">notes param</param>
        /// <param name="snapshot">snapshot param</param>
        [Preserve]
        public InlineObject13(List<ApiCcdManagementV1ProjectsProjectidBucketsBucketidReleasesEntries> entries = default, object metadata = default, string notes = default, DateTime snapshot = default)
        {
            Entries = entries;
            Metadata = (IDeserializable) JsonObject.GetNewJsonObjectResponse(metadata);
            Notes = notes;
            Snapshot = snapshot;
        }

        /// <summary>
        /// Parameter entries of InlineObject13
        /// </summary>
        [Preserve]
        [DataMember(Name = "entries", EmitDefaultValue = false)]
        public List<ApiCcdManagementV1ProjectsProjectidBucketsBucketidReleasesEntries> Entries{ get; }

        /// <summary>
        /// Parameter metadata of InlineObject13
        /// </summary>
        [Preserve][JsonConverter(typeof(JsonObjectConverter))]
        [DataMember(Name = "metadata", EmitDefaultValue = false)]
        public IDeserializable Metadata{ get; }

        /// <summary>
        /// Parameter notes of InlineObject13
        /// </summary>
        [Preserve]
        [DataMember(Name = "notes", EmitDefaultValue = false)]
        public string Notes{ get; }

        /// <summary>
        /// Parameter snapshot of InlineObject13
        /// </summary>
        [Preserve]
        [DataMember(Name = "snapshot", EmitDefaultValue = false)]
        public DateTime Snapshot{ get; }

        /// <summary>
        /// Formats a InlineObject13 into a string of key-value pairs for use as a path parameter.
        /// </summary>
        /// <returns>Returns a string representation of the key-value pairs.</returns>
        internal string SerializeAsPathParam()
        {
            var serializedModel = "";

            if (Entries != null)
            {
                serializedModel += "entries," + Entries.ToString() + ",";
            }
            if (Metadata != null)
            {
                serializedModel += "metadata," + Metadata.ToString() + ",";
            }
            if (Notes != null)
            {
                serializedModel += "notes," + Notes + ",";
            }
            if (Snapshot != null)
            {
                serializedModel += "snapshot," + Snapshot.ToString();
            }
            return serializedModel;
        }

        /// <summary>
        /// Returns a InlineObject13 as a dictionary of key-value pairs for use as a query parameter.
        /// </summary>
        /// <returns>Returns a dictionary of string key-value pairs.</returns>
        internal Dictionary<string, string> GetAsQueryParam()
        {
            var dictionary = new Dictionary<string, string>();

            if (Notes != null)
            {
                var notesStringValue = Notes.ToString();
                dictionary.Add("notes", notesStringValue);
            }

            if (Snapshot != null)
            {
                var snapshotStringValue = Snapshot.ToString();
                dictionary.Add("snapshot", snapshotStringValue);
            }

            return dictionary;
        }
    }
}
