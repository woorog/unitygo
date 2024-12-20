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
    /// InlineObject30 model
    /// </summary>
    [Preserve]
    [DataContract(Name = "inline_object_30")]
    internal class InlineObject30
    {
        /// <summary>
        /// Creates an instance of InlineObject30.
        /// </summary>
        /// <param name="tosVersion">tosVersion param</param>
        [Preserve]
        public InlineObject30(int tosVersion = default)
        {
            TosVersion = tosVersion;
        }

        /// <summary>
        /// Parameter tos_version of InlineObject30
        /// </summary>
        [Preserve]
        [DataMember(Name = "tos_version", EmitDefaultValue = false)]
        public int TosVersion{ get; }

        /// <summary>
        /// Formats a InlineObject30 into a string of key-value pairs for use as a path parameter.
        /// </summary>
        /// <returns>Returns a string representation of the key-value pairs.</returns>
        internal string SerializeAsPathParam()
        {
            var serializedModel = "";

            serializedModel += "tos_version," + TosVersion.ToString();
            return serializedModel;
        }

        /// <summary>
        /// Returns a InlineObject30 as a dictionary of key-value pairs for use as a query parameter.
        /// </summary>
        /// <returns>Returns a dictionary of string key-value pairs.</returns>
        internal Dictionary<string, string> GetAsQueryParam()
        {
            var dictionary = new Dictionary<string, string>();

            var tos_versionStringValue = TosVersion.ToString();
            dictionary.Add("tos_version", tos_versionStringValue);

            return dictionary;
        }
    }
}
