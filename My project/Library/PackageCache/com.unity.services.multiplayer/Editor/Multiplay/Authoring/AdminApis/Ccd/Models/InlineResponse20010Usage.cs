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
    /// InlineResponse20010Usage model
    /// </summary>
    [Preserve]
    [DataContract(Name = "inline_response_200_10_usage")]
    internal class InlineResponse20010Usage
    {
        /// <summary>
        /// Creates an instance of InlineResponse20010Usage.
        /// </summary>
        /// <param name="projectguid">projectguid param</param>
        /// <param name="quantity">quantity param</param>
        [Preserve]
        public InlineResponse20010Usage(System.Guid projectguid = default, decimal quantity = default)
        {
            Projectguid = projectguid;
            Quantity = quantity;
        }

        /// <summary>
        /// Parameter projectguid of InlineResponse20010Usage
        /// </summary>
        [Preserve]
        [DataMember(Name = "projectguid", EmitDefaultValue = false)]
        public System.Guid Projectguid{ get; }

        /// <summary>
        /// Parameter quantity of InlineResponse20010Usage
        /// </summary>
        [Preserve]
        [DataMember(Name = "quantity", EmitDefaultValue = false)]
        public decimal Quantity{ get; }

        /// <summary>
        /// Formats a InlineResponse20010Usage into a string of key-value pairs for use as a path parameter.
        /// </summary>
        /// <returns>Returns a string representation of the key-value pairs.</returns>
        internal string SerializeAsPathParam()
        {
            var serializedModel = "";

            if (Projectguid != null)
            {
                serializedModel += "projectguid," + Projectguid + ",";
            }
            serializedModel += "quantity," + Quantity.ToString();
            return serializedModel;
        }

        /// <summary>
        /// Returns a InlineResponse20010Usage as a dictionary of key-value pairs for use as a query parameter.
        /// </summary>
        /// <returns>Returns a dictionary of string key-value pairs.</returns>
        internal Dictionary<string, string> GetAsQueryParam()
        {
            var dictionary = new Dictionary<string, string>();

            if (Projectguid != null)
            {
                var projectguidStringValue = Projectguid.ToString();
                dictionary.Add("projectguid", projectguidStringValue);
            }

            var quantityStringValue = Quantity.ToString();
            dictionary.Add("quantity", quantityStringValue);

            return dictionary;
        }
    }
}