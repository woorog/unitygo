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
    /// CcdUser model
    /// </summary>
    [Preserve]
    [DataContract(Name = "ccd.user")]
    internal class CcdUser
    {
        /// <summary>
        /// Creates an instance of CcdUser.
        /// </summary>
        /// <param name="id">id param</param>
        /// <param name="name">name param</param>
        [Preserve]
        public CcdUser(string id = default, string name = default)
        {
            Id = id;
            Name = name;
        }

        /// <summary>
        /// Parameter id of CcdUser
        /// </summary>
        [Preserve]
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id{ get; }

        /// <summary>
        /// Parameter name of CcdUser
        /// </summary>
        [Preserve]
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name{ get; }

        /// <summary>
        /// Formats a CcdUser into a string of key-value pairs for use as a path parameter.
        /// </summary>
        /// <returns>Returns a string representation of the key-value pairs.</returns>
        internal string SerializeAsPathParam()
        {
            var serializedModel = "";

            if (Id != null)
            {
                serializedModel += "id," + Id + ",";
            }
            if (Name != null)
            {
                serializedModel += "name," + Name;
            }
            return serializedModel;
        }

        /// <summary>
        /// Returns a CcdUser as a dictionary of key-value pairs for use as a query parameter.
        /// </summary>
        /// <returns>Returns a dictionary of string key-value pairs.</returns>
        internal Dictionary<string, string> GetAsQueryParam()
        {
            var dictionary = new Dictionary<string, string>();

            if (Id != null)
            {
                var idStringValue = Id.ToString();
                dictionary.Add("id", idStringValue);
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
