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
    /// CcdUserapikey model
    /// </summary>
    [Preserve]
    [DataContract(Name = "ccd.userapikey")]
    internal class CcdUserapikey
    {
        /// <summary>
        /// Creates an instance of CcdUserapikey.
        /// </summary>
        /// <param name="apikey">apikey param</param>
        [Preserve]
        public CcdUserapikey(string apikey)
        {
            Apikey = apikey;
        }

        /// <summary>
        /// Parameter apikey of CcdUserapikey
        /// </summary>
        [Preserve]
        [DataMember(Name = "apikey", IsRequired = true, EmitDefaultValue = true)]
        public string Apikey{ get; }
    
        /// <summary>
        /// Formats a CcdUserapikey into a string of key-value pairs for use as a path parameter.
        /// </summary>
        /// <returns>Returns a string representation of the key-value pairs.</returns>
        internal string SerializeAsPathParam()
        {
            var serializedModel = "";

            if (Apikey != null)
            {
                serializedModel += "apikey," + Apikey;
            }
            return serializedModel;
        }

        /// <summary>
        /// Returns a CcdUserapikey as a dictionary of key-value pairs for use as a query parameter.
        /// </summary>
        /// <returns>Returns a dictionary of string key-value pairs.</returns>
        internal Dictionary<string, string> GetAsQueryParam()
        {
            var dictionary = new Dictionary<string, string>();

            if (Apikey != null)
            {
                var apikeyStringValue = Apikey.ToString();
                dictionary.Add("apikey", apikeyStringValue);
            }
            
            return dictionary;
        }
    }
}