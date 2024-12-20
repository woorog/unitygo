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
    /// Amazon S3 bucket upload based build details.
    /// </summary>
    [Preserve]
    [DataContract(Name = "Amazon_S3_Details")]
    internal class AmazonS3Details
    {
        /// <summary>
        /// Amazon S3 bucket upload based build details.
        /// </summary>
        /// <param name="s3URI">The S3 URI used to identify a directory or file(s) within a given Amazon S3 bucket. Starts with \&quot;s3://\&quot;.</param>
        [Preserve]
        public AmazonS3Details(string s3URI)
        {
            S3URI = s3URI;
        }

        /// <summary>
        /// The S3 URI used to identify a directory or file(s) within a given Amazon S3 bucket. Starts with \&quot;s3://\&quot;.
        /// </summary>
        [Preserve]
        [DataMember(Name = "s3URI", IsRequired = true, EmitDefaultValue = true)]
        public string S3URI{ get; }

        /// <summary>
        /// Formats a AmazonS3Details into a string of key-value pairs for use as a path parameter.
        /// </summary>
        /// <returns>Returns a string representation of the key-value pairs.</returns>
        internal string SerializeAsPathParam()
        {
            var serializedModel = "";

            if (S3URI != null)
            {
                serializedModel += "s3URI," + S3URI;
            }
            return serializedModel;
        }

        /// <summary>
        /// Returns a AmazonS3Details as a dictionary of key-value pairs for use as a query parameter.
        /// </summary>
        /// <returns>Returns a dictionary of string key-value pairs.</returns>
        internal Dictionary<string, string> GetAsQueryParam()
        {
            var dictionary = new Dictionary<string, string>();

            if (S3URI != null)
            {
                var s3URIStringValue = S3URI.ToString();
                dictionary.Add("s3URI", s3URIStringValue);
            }

            return dictionary;
        }
    }
}