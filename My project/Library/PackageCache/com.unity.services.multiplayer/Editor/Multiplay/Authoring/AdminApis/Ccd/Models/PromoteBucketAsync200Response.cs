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
    /// PromoteBucketAsync200Response model
    /// </summary>
    [Preserve]
    [DataContract(Name = "PromoteBucketAsync_200_response")]
    internal class PromoteBucketAsync200Response
    {
        /// <summary>
        /// Creates an instance of PromoteBucketAsync200Response.
        /// </summary>
        /// <param name="promotionId">promotionId param</param>
        [Preserve]
        public PromoteBucketAsync200Response(System.Guid promotionId = default)
        {
            PromotionId = promotionId;
        }

        /// <summary>
        /// Parameter promotion_id of PromoteBucketAsync200Response
        /// </summary>
        [Preserve]
        [DataMember(Name = "promotion_id", EmitDefaultValue = false)]
        public System.Guid PromotionId{ get; }
    
        /// <summary>
        /// Formats a PromoteBucketAsync200Response into a string of key-value pairs for use as a path parameter.
        /// </summary>
        /// <returns>Returns a string representation of the key-value pairs.</returns>
        internal string SerializeAsPathParam()
        {
            var serializedModel = "";

            if (PromotionId != null)
            {
                serializedModel += "promotion_id," + PromotionId;
            }
            return serializedModel;
        }

        /// <summary>
        /// Returns a PromoteBucketAsync200Response as a dictionary of key-value pairs for use as a query parameter.
        /// </summary>
        /// <returns>Returns a dictionary of string key-value pairs.</returns>
        internal Dictionary<string, string> GetAsQueryParam()
        {
            var dictionary = new Dictionary<string, string>();

            if (PromotionId != null)
            {
                var promotion_idStringValue = PromotionId.ToString();
                dictionary.Add("promotion_id", promotion_idStringValue);
            }
            
            return dictionary;
        }
    }
}
