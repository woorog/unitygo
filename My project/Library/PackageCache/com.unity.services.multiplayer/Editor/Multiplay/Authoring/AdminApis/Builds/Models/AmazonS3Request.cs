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
    /// Amazon S3 bucket upload based build create or update request.
    /// </summary>
    [Preserve]
    [DataContract(Name = "Amazon_S3_Request")]
    internal class AmazonS3Request
    {
        /// <summary>
        /// Amazon S3 bucket upload based build create or update request.
        /// </summary>
        /// <param name="s3URI">The S3 URI used to identify a directory or file(s) within a given Amazon S3 bucket. Starts with \&quot;s3://\&quot;.</param>
        /// <param name="accessKey">The Amazon Web Services (AWS) access key, first of a pair of credentials needed to authenticate with AWS services.</param>
        /// <param name="secretKey">The Amazon Web Services (AWS) secret key, second of a pair of credentials needed to authenticate with AWS services.</param>
        [Preserve]
        public AmazonS3Request(string s3URI, string accessKey, string secretKey)
        {
            S3URI = s3URI;
            AccessKey = accessKey;
            SecretKey = secretKey;
        }

        /// <summary>
        /// The S3 URI used to identify a directory or file(s) within a given Amazon S3 bucket. Starts with \&quot;s3://\&quot;.
        /// </summary>
        [Preserve]
        [DataMember(Name = "s3URI", IsRequired = true, EmitDefaultValue = true)]
        public string S3URI{ get; }

        /// <summary>
        /// The Amazon Web Services (AWS) access key, first of a pair of credentials needed to authenticate with AWS services.
        /// </summary>
        [Preserve]
        [DataMember(Name = "accessKey", IsRequired = true, EmitDefaultValue = true)]
        public string AccessKey{ get; }

        /// <summary>
        /// The Amazon Web Services (AWS) secret key, second of a pair of credentials needed to authenticate with AWS services.
        /// </summary>
        [Preserve]
        [DataMember(Name = "secretKey", IsRequired = true, EmitDefaultValue = true)]
        public string SecretKey{ get; }

        /// <summary>
        /// Formats a AmazonS3Request into a string of key-value pairs for use as a path parameter.
        /// </summary>
        /// <returns>Returns a string representation of the key-value pairs.</returns>
        internal string SerializeAsPathParam()
        {
            var serializedModel = "";

            if (S3URI != null)
            {
                serializedModel += "s3URI," + S3URI + ",";
            }
            if (AccessKey != null)
            {
                serializedModel += "accessKey," + AccessKey + ",";
            }
            if (SecretKey != null)
            {
                serializedModel += "secretKey," + SecretKey;
            }
            return serializedModel;
        }

        /// <summary>
        /// Returns a AmazonS3Request as a dictionary of key-value pairs for use as a query parameter.
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

            if (AccessKey != null)
            {
                var accessKeyStringValue = AccessKey.ToString();
                dictionary.Add("accessKey", accessKeyStringValue);
            }

            if (SecretKey != null)
            {
                var secretKeyStringValue = SecretKey.ToString();
                dictionary.Add("secretKey", secretKeyStringValue);
            }

            return dictionary;
        }
    }
}
