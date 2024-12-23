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
using Unity.Services.Matchmaker.Http;



namespace Unity.Services.Matchmaker.Models
{
    /// <summary>
    /// An object representing a single player.
    /// </summary>
    [Preserve]
    [DataContract(Name = "Player")]
    public class Player
    {
        /// <summary>
        /// An object representing a single player.
        /// </summary>
        /// <param name="id">The unique ID of the player. Usually, the ID received as a result of authenticating a player.</param>
        /// <param name="customData">A custom data object. Contains a dictionary of custom data to be used by the rules defined in a Match Definition.</param>
        /// <param name="qosResults">A list of QosResult.</param>
        [Preserve]
        public Player(string id, object customData = default, List<QosResult> qosResults = default)
        {
            Id = id;
            CustomData = (IDeserializable) JsonObject.GetNewJsonObjectResponse(customData);
            QosResults = qosResults;
        }

        /// <summary>
        /// The unique ID of the player. Usually, the ID received as a result of authenticating a player.
        /// </summary>
        [Preserve]
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id{ get; }

        /// <summary>
        /// A custom data object. Contains a dictionary of custom data to be used by the rules defined in a Match Definition.
        /// </summary>
        [Preserve][JsonConverter(typeof(JsonObjectConverter))]
        [DataMember(Name = "customData", EmitDefaultValue = false)]
        public IDeserializable CustomData{ get; }

        /// <summary>
        /// A list of QosResult.
        /// </summary>
        [Preserve]
        [DataMember(Name = "qosResults", EmitDefaultValue = false)]
        public List<QosResult> QosResults{ get; }

        /// <summary>
        /// Formats a Player into a string of key-value pairs for use as a path parameter.
        /// </summary>
        /// <returns>Returns a string representation of the key-value pairs.</returns>
        internal string SerializeAsPathParam()
        {
            var serializedModel = "";

            if (Id != null)
            {
                serializedModel += "id," + Id + ",";
            }
            if (CustomData != null)
            {
                serializedModel += "customData," + CustomData.ToString() + ",";
            }
            if (QosResults != null)
            {
                serializedModel += "qosResults," + QosResults.ToString();
            }
            return serializedModel;
        }

        /// <summary>
        /// Returns a Player as a dictionary of key-value pairs for use as a query parameter.
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

            return dictionary;
        }
    }
}
