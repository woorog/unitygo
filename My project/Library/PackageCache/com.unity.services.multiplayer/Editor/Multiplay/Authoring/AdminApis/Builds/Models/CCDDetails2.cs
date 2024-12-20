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
using Unity.Services.Multiplay.Authoring.Editor.AdminApis.Builds.Http;



namespace Unity.Services.Multiplay.Authoring.Editor.AdminApis.Builds.Models
{
    /// <summary>
    /// CCD based new build version details.
    /// </summary>
    [Preserve]
    [DataContract(Name = "CCD_Details_2")]
    internal class CCDDetails2
    {
        /// <summary>
        /// CCD based new build version details.
        /// </summary>
        /// <param name="bucketID">The CCD bucket ID for a build within an environment. Used as part of validation only. Gathered using Create or Get Build APIs.</param>
        [Preserve]
        public CCDDetails2(System.Guid bucketID)
        {
            BucketID = bucketID;
        }

        /// <summary>
        /// The CCD bucket ID for a build within an environment. Used as part of validation only. Gathered using Create or Get Build APIs.
        /// </summary>
        [Preserve]
        [DataMember(Name = "bucketID", IsRequired = true, EmitDefaultValue = true)]
        public System.Guid BucketID{ get; }

        /// <summary>
        /// Formats a CCDDetails2 into a string of key-value pairs for use as a path parameter.
        /// </summary>
        /// <returns>Returns a string representation of the key-value pairs.</returns>
        internal string SerializeAsPathParam()
        {
            var serializedModel = "";

            if (BucketID != null)
            {
                serializedModel += "bucketID," + BucketID;
            }
            return serializedModel;
        }

        /// <summary>
        /// Returns a CCDDetails2 as a dictionary of key-value pairs for use as a query parameter.
        /// </summary>
        /// <returns>Returns a dictionary of string key-value pairs.</returns>
        internal Dictionary<string, string> GetAsQueryParam()
        {
            var dictionary = new Dictionary<string, string>();

            if (BucketID != null)
            {
                var bucketIDStringValue = BucketID.ToString();
                dictionary.Add("bucketID", bucketIDStringValue);
            }

            return dictionary;
        }
    }
}
