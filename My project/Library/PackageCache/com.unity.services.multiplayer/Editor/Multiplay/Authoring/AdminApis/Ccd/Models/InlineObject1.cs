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
    /// InlineObject1 model
    /// </summary>
    [Preserve]
    [DataContract(Name = "inline_object_1")]
    internal class InlineObject1
    {
        /// <summary>
        /// Creates an instance of InlineObject1.
        /// </summary>
        /// <param name="description">description param</param>
        [Preserve]
        public InlineObject1(string description = default)
        {
            Description = description;
        }

        /// <summary>
        /// Parameter description of InlineObject1
        /// </summary>
        [Preserve]
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description{ get; }

        /// <summary>
        /// Formats a InlineObject1 into a string of key-value pairs for use as a path parameter.
        /// </summary>
        /// <returns>Returns a string representation of the key-value pairs.</returns>
        internal string SerializeAsPathParam()
        {
            var serializedModel = "";

            if (Description != null)
            {
                serializedModel += "description," + Description;
            }
            return serializedModel;
        }

        /// <summary>
        /// Returns a InlineObject1 as a dictionary of key-value pairs for use as a query parameter.
        /// </summary>
        /// <returns>Returns a dictionary of string key-value pairs.</returns>
        internal Dictionary<string, string> GetAsQueryParam()
        {
            var dictionary = new Dictionary<string, string>();

            if (Description != null)
            {
                var descriptionStringValue = Description.ToString();
                dictionary.Add("description", descriptionStringValue);
            }

            return dictionary;
        }
    }
}
