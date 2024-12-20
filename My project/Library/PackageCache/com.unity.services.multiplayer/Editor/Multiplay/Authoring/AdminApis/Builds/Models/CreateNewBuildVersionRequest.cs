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
    /// Request to update a build by creating a new build version.
    /// </summary>
    [Preserve]
    [DataContract(Name = "CreateNewBuildVersion_request")]
    internal class CreateNewBuildVersionRequest
    {
        /// <summary>
        /// Request to update a build by creating a new build version.
        /// </summary>
        /// <param name="buildVersionName">The name of the build&#39;s current version. However, it is not relevant for container builds, in which the &#39;imageTag&#39; is used instead.</param>
        /// <param name="ccd">ccd param</param>
        /// <param name="container">container param</param>
        /// <param name="s3">s3 param</param>
        /// <param name="gcs">gcs param</param>
        /// <param name="forceRollout">If true, it will force rollout new build version</param>
        [Preserve]
        public CreateNewBuildVersionRequest(string buildVersionName = default, CCDDetails2 ccd = default, ContainerImage container = default, AmazonS3Request s3 = default, GoogleCloudStorageRequest gcs = default, bool forceRollout = false)
        {
            BuildVersionName = buildVersionName;
            Ccd = ccd;
            Container = container;
            S3 = s3;
            Gcs = gcs;
            ForceRollout = forceRollout;
        }

        /// <summary>
        /// The name of the build&#39;s current version. However, it is not relevant for container builds, in which the &#39;imageTag&#39; is used instead.
        /// </summary>
        [Preserve]
        [DataMember(Name = "buildVersionName", EmitDefaultValue = false)]
        public string BuildVersionName{ get; }
        
        /// <summary>
        /// Parameter ccd of CreateNewBuildVersionRequest
        /// </summary>
        [Preserve]
        [DataMember(Name = "ccd", EmitDefaultValue = false)]
        public CCDDetails2 Ccd{ get; }

        /// <summary>
        /// Parameter container of CreateNewBuildVersionRequest
        /// </summary>
        [Preserve]
        [DataMember(Name = "container", EmitDefaultValue = false)]
        public ContainerImage Container{ get; }

        /// <summary>
        /// Parameter s3 of CreateNewBuildVersionRequest
        /// </summary>
        [Preserve]
        [DataMember(Name = "s3", EmitDefaultValue = false)]
        public AmazonS3Request S3{ get; }

        /// <summary>
        /// Parameter gcs of CreateNewBuildVersionRequest
        /// </summary>
        [Preserve]
        [DataMember(Name = "gcs", EmitDefaultValue = false)]
        public GoogleCloudStorageRequest Gcs{ get; }
        
        /// <summary>
        /// If true, it will force rollout new build version
        /// </summary>
        [Preserve]
        [DataMember(Name = "forceRollout", EmitDefaultValue = true)]
        public bool ForceRollout{ get; }

        /// <summary>
        /// Formats a CreateNewBuildVersionRequest into a string of key-value pairs for use as a path parameter.
        /// </summary>
        /// <returns>Returns a string representation of the key-value pairs.</returns>
        internal string SerializeAsPathParam()
        {
            var serializedModel = "";

            if (BuildVersionName != null)
            {
                serializedModel += "buildVersionName," + BuildVersionName + ",";
            }
            if (Ccd != null)
            {
                serializedModel += "ccd," + Ccd.ToString() + ",";
            }
            if (Container != null)
            {
                serializedModel += "container," + Container.ToString() + ",";
            }
            if (S3 != null)
            {
                serializedModel += "s3," + S3.ToString() + ",";
            }
            if (Gcs != null)
            {
                serializedModel += "gcs," + Gcs.ToString() + ",";
            }
            serializedModel += "forceRollout," + ForceRollout.ToString();
            return serializedModel;
        }

        /// <summary>
        /// Returns a CreateNewBuildVersionRequest as a dictionary of key-value pairs for use as a query parameter.
        /// </summary>
        /// <returns>Returns a dictionary of string key-value pairs.</returns>
        internal Dictionary<string, string> GetAsQueryParam()
        {
            var dictionary = new Dictionary<string, string>();

            if (BuildVersionName != null)
            {
                var buildVersionNameStringValue = BuildVersionName.ToString();
                dictionary.Add("buildVersionName", buildVersionNameStringValue);
            }
            
            var forceRolloutStringValue = ForceRollout.ToString();
            dictionary.Add("forceRollout", forceRolloutStringValue);

            return dictionary;
        }
    }
}
