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
    /// CcdOrg model
    /// </summary>
    [Preserve]
    [DataContract(Name = "ccd.org")]
    internal class CcdOrg
    {
        /// <summary>
        /// Creates an instance of CcdOrg.
        /// </summary>
        /// <param name="id">id param</param>
        /// <param name="name">name param</param>
        /// <param name="orgid">orgid param</param>
        /// <param name="tosAccepted">tosAccepted param</param>
        [Preserve]
        public CcdOrg(string id = default, string name = default, string orgid = default, bool tosAccepted = default)
        {
            Id = id;
            Name = name;
            Orgid = orgid;
            TosAccepted = tosAccepted;
        }

        /// <summary>
        /// Parameter id of CcdOrg
        /// </summary>
        [Preserve]
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id{ get; }

        /// <summary>
        /// Parameter name of CcdOrg
        /// </summary>
        [Preserve]
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name{ get; }

        /// <summary>
        /// Parameter orgid of CcdOrg
        /// </summary>
        [Preserve]
        [DataMember(Name = "orgid", EmitDefaultValue = false)]
        public string Orgid{ get; }

        /// <summary>
        /// Parameter tos_accepted of CcdOrg
        /// </summary>
        [Preserve]
        [DataMember(Name = "tos_accepted", EmitDefaultValue = true)]
        public bool TosAccepted{ get; }

        /// <summary>
        /// Formats a CcdOrg into a string of key-value pairs for use as a path parameter.
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
                serializedModel += "name," + Name + ",";
            }
            if (Orgid != null)
            {
                serializedModel += "orgid," + Orgid + ",";
            }
            serializedModel += "tos_accepted," + TosAccepted.ToString();
            return serializedModel;
        }

        /// <summary>
        /// Returns a CcdOrg as a dictionary of key-value pairs for use as a query parameter.
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

            if (Orgid != null)
            {
                var orgidStringValue = Orgid.ToString();
                dictionary.Add("orgid", orgidStringValue);
            }

            var tos_acceptedStringValue = TosAccepted.ToString();
            dictionary.Add("tos_accepted", tos_acceptedStringValue);

            return dictionary;
        }
    }
}
