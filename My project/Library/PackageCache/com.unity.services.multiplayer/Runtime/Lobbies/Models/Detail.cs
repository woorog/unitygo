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
using Unity.Services.Lobbies.Http;



namespace Unity.Services.Lobbies.Models
{
    /// <summary>
    /// Additional detail about an error.  This may include detailed validation failure messages, debugging information, troubleshooting steps, or more.
    /// </summary>
    [Preserve]
    [DataContract(Name = "Detail")]
    public class Detail
    {
        /// <summary>
        /// Additional detail about an error.  This may include detailed validation failure messages, debugging information, troubleshooting steps, or more.
        /// </summary>
        /// <param name="errorType">errorType param</param>
        /// <param name="message">message param</param>
        [Preserve]
        public Detail(string errorType = default, string message = default)
        {
            ErrorType = errorType;
            Message = message;
        }

        /// <summary>
        /// Parameter errorType of Detail
        /// </summary>
        [Preserve]
        [DataMember(Name = "errorType", EmitDefaultValue = false)]
        public string ErrorType{ get; }

        /// <summary>
        /// Parameter message of Detail
        /// </summary>
        [Preserve]
        [DataMember(Name = "message", EmitDefaultValue = false)]
        public string Message{ get; }

        /// <summary>
        /// Formats a Detail into a string of key-value pairs for use as a path parameter.
        /// </summary>
        /// <returns>Returns a string representation of the key-value pairs.</returns>
        internal string SerializeAsPathParam()
        {
            var serializedModel = "";

            if (ErrorType != null)
            {
                serializedModel += "errorType," + ErrorType + ",";
            }
            if (Message != null)
            {
                serializedModel += "message," + Message;
            }
            return serializedModel;
        }

        /// <summary>
        /// Returns a Detail as a dictionary of key-value pairs for use as a query parameter.
        /// </summary>
        /// <returns>Returns a dictionary of string key-value pairs.</returns>
        internal Dictionary<string, string> GetAsQueryParam()
        {
            var dictionary = new Dictionary<string, string>();

            if (ErrorType != null)
            {
                var errorTypeStringValue = ErrorType.ToString();
                dictionary.Add("errorType", errorTypeStringValue);
            }

            if (Message != null)
            {
                var messageStringValue = Message.ToString();
                dictionary.Add("message", messageStringValue);
            }

            return dictionary;
        }
    }
}
