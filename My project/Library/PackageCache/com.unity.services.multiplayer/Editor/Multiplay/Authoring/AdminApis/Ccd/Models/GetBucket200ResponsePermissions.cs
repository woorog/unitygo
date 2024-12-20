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
    /// GetBucket200ResponsePermissions model
    /// </summary>
    [Preserve]
    [DataContract(Name = "GetBucket_200_response_permissions")]
    internal class GetBucket200ResponsePermissions
    {
        /// <summary>
        /// Creates an instance of GetBucket200ResponsePermissions.
        /// </summary>
        /// <param name="bucketPromote">bucketPromote param</param>
        /// <param name="bucketRead">bucketRead param</param>
        /// <param name="bucketRelease">bucketRelease param</param>
        /// <param name="bucketWrite">bucketWrite param</param>
        [Preserve]
        public GetBucket200ResponsePermissions(bool bucketPromote = default, bool bucketRead = default, bool bucketRelease = default, bool bucketWrite = default)
        {
            BucketPromote = bucketPromote;
            BucketRead = bucketRead;
            BucketRelease = bucketRelease;
            BucketWrite = bucketWrite;
        }

        /// <summary>
        /// Parameter bucket_promote of GetBucket200ResponsePermissions
        /// </summary>
        [Preserve]
        [DataMember(Name = "bucket_promote", EmitDefaultValue = true)]
        public bool BucketPromote{ get; }
        
        /// <summary>
        /// Parameter bucket_read of GetBucket200ResponsePermissions
        /// </summary>
        [Preserve]
        [DataMember(Name = "bucket_read", EmitDefaultValue = true)]
        public bool BucketRead{ get; }
        
        /// <summary>
        /// Parameter bucket_release of GetBucket200ResponsePermissions
        /// </summary>
        [Preserve]
        [DataMember(Name = "bucket_release", EmitDefaultValue = true)]
        public bool BucketRelease{ get; }
        
        /// <summary>
        /// Parameter bucket_write of GetBucket200ResponsePermissions
        /// </summary>
        [Preserve]
        [DataMember(Name = "bucket_write", EmitDefaultValue = true)]
        public bool BucketWrite{ get; }
    
        /// <summary>
        /// Formats a GetBucket200ResponsePermissions into a string of key-value pairs for use as a path parameter.
        /// </summary>
        /// <returns>Returns a string representation of the key-value pairs.</returns>
        internal string SerializeAsPathParam()
        {
            var serializedModel = "";

            serializedModel += "bucket_promote," + BucketPromote.ToString() + ",";
            serializedModel += "bucket_read," + BucketRead.ToString() + ",";
            serializedModel += "bucket_release," + BucketRelease.ToString() + ",";
            serializedModel += "bucket_write," + BucketWrite.ToString();
            return serializedModel;
        }

        /// <summary>
        /// Returns a GetBucket200ResponsePermissions as a dictionary of key-value pairs for use as a query parameter.
        /// </summary>
        /// <returns>Returns a dictionary of string key-value pairs.</returns>
        internal Dictionary<string, string> GetAsQueryParam()
        {
            var dictionary = new Dictionary<string, string>();

            var bucket_promoteStringValue = BucketPromote.ToString();
            dictionary.Add("bucket_promote", bucket_promoteStringValue);
            
            var bucket_readStringValue = BucketRead.ToString();
            dictionary.Add("bucket_read", bucket_readStringValue);
            
            var bucket_releaseStringValue = BucketRelease.ToString();
            dictionary.Add("bucket_release", bucket_releaseStringValue);
            
            var bucket_writeStringValue = BucketWrite.ToString();
            dictionary.Add("bucket_write", bucket_writeStringValue);
            
            return dictionary;
        }
    }
}
