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
    /// InlineObject model
    /// </summary>
    [Preserve]
    [DataContract(Name = "inline_object")]
    internal class InlineObject
    {
        /// <summary>
        /// Creates an instance of InlineObject.
        /// </summary>
        /// <param name="description">description param</param>
        /// <param name="name">name param</param>
        [Preserve]
        public InlineObject(string description = default, string name = default)
        {
            Description = description;
            Name = name;
        }

        /// <summary>
        /// Parameter description of InlineObject
        /// </summary>
        [Preserve]
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description{ get; }
        
        /// <summary>
        /// Parameter name of InlineObject
        /// </summary>
        [Preserve]
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name{ get; }
    
        /// <summary>
        /// Formats a InlineObject into a string of key-value pairs for use as a path parameter.
        /// </summary>
        /// <returns>Returns a string representation of the key-value pairs.</returns>
        internal string SerializeAsPathParam()
        {
            var serializedModel = "";

            if (Description != null)
            {
                serializedModel += "description," + Description + ",";
            }
            if (Name != null)
            {
                serializedModel += "name," + Name;
            }
            return serializedModel;
        }

        /// <summary>
        /// Returns a InlineObject as a dictionary of key-value pairs for use as a query parameter.
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
            
            if (Name != null)
            {
                var nameStringValue = Name.ToString();
                dictionary.Add("name", nameStringValue);
            }
            
            return dictionary;
        }
    }
}
