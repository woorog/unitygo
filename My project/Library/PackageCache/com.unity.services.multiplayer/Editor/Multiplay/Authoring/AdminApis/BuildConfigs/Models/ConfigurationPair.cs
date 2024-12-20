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
using Unity.Services.Multiplay.Authoring.Editor.AdminApis.BuildConfigs.Http;



namespace Unity.Services.Multiplay.Authoring.Editor.AdminApis.BuildConfigs.Models
{
    /// <summary>
    /// A key/value pair to configure a build configuration.
    /// </summary>
    [Preserve]
    [DataContract(Name = "Configuration_Pair")]
    internal class ConfigurationPair
    {
        /// <summary>
        /// A key/value pair to configure a build configuration.
        /// </summary>
        /// <param name="key">The freeform key used to identify the paired value for build configuration configuration.</param>
        /// <param name="value">The value used for build configuration configuration with the paired key.</param>
        [Preserve]
        public ConfigurationPair(string key, string value)
        {
            Key = key;
            Value = value;
        }

        /// <summary>
        /// The freeform key used to identify the paired value for build configuration configuration.
        /// </summary>
        [Preserve]
        [DataMember(Name = "key", IsRequired = true, EmitDefaultValue = true)]
        public string Key{ get; }

        /// <summary>
        /// The value used for build configuration configuration with the paired key.
        /// </summary>
        [Preserve]
        [DataMember(Name = "value", IsRequired = true, EmitDefaultValue = true)]
        public string Value{ get; }

        /// <summary>
        /// Formats a ConfigurationPair into a string of key-value pairs for use as a path parameter.
        /// </summary>
        /// <returns>Returns a string representation of the key-value pairs.</returns>
        internal string SerializeAsPathParam()
        {
            var serializedModel = "";

            if (Key != null)
            {
                serializedModel += "key," + Key + ",";
            }
            if (Value != null)
            {
                serializedModel += "value," + Value;
            }
            return serializedModel;
        }

        /// <summary>
        /// Returns a ConfigurationPair as a dictionary of key-value pairs for use as a query parameter.
        /// </summary>
        /// <returns>Returns a dictionary of string key-value pairs.</returns>
        internal Dictionary<string, string> GetAsQueryParam()
        {
            var dictionary = new Dictionary<string, string>();

            if (Key != null)
            {
                var keyStringValue = Key.ToString();
                dictionary.Add("key", keyStringValue);
            }

            if (Value != null)
            {
                var valueStringValue = Value.ToString();
                dictionary.Add("value", valueStringValue);
            }

            return dictionary;
        }
    }
}