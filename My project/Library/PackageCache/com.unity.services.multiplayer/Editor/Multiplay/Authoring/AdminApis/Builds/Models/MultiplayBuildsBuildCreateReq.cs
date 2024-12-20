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
    /// Request to create a build.
    /// </summary>
    [Preserve]
    [DataContract(Name = "multiplay.builds.buildCreateReq")]
    internal class MultiplayBuildsBuildCreateReq
    {
        /// <summary>
        /// Request to create a build.
        /// </summary>
        /// <param name="buildName">The name of a build within an environment.</param>
        /// <param name="osFamily">The operating system family to use for the build: * &#x60;LINUX&#x60; - The build is for Linux. </param>
        /// <param name="buildType">The upload type of the build:   * &#x60;FILE_UPLOAD&#x60; - The build is created using directly uploaded game files, backed by CCD as the storage driver.   * &#x60;CONTAINER&#x60; - The build is created using a container image containing game files.   * &#x60;S3&#x60; - The build is created using an external Amazon S3 Bucket containing game files. </param>
        /// <param name="ccd">ccd param</param>
        /// <param name="buildVersionName">The name of the build&#39;s current version. However, it is not relevant for container builds, in which the &#39;imageTag&#39; is used instead.</param>
        [Preserve]
        public MultiplayBuildsBuildCreateReq(string buildName, OsFamilyOptions osFamily = default, BuildTypeOptions buildType = default, CCDDetails1 ccd = default, string buildVersionName = default)
        {
            BuildName = buildName;
            OsFamily = osFamily;
            BuildType = buildType;
            Ccd = ccd;
            BuildVersionName = buildVersionName;
        }

        /// <summary>
        /// The name of a build within an environment.
        /// </summary>
        [Preserve]
        [DataMember(Name = "buildName", IsRequired = true, EmitDefaultValue = true)]
        public string BuildName{ get; }
        
        /// <summary>
        /// The operating system family to use for the build: * &#x60;LINUX&#x60; - The build is for Linux. 
        /// </summary>
        [Preserve]
        [JsonConverter(typeof(StringEnumConverter))]
        [DataMember(Name = "osFamily", EmitDefaultValue = false)]
        public OsFamilyOptions OsFamily{ get; }
        
        /// <summary>
        /// The upload type of the build:   * &#x60;FILE_UPLOAD&#x60; - The build is created using directly uploaded game files, backed by CCD as the storage driver.   * &#x60;CONTAINER&#x60; - The build is created using a container image containing game files.   * &#x60;S3&#x60; - The build is created using an external Amazon S3 Bucket containing game files. 
        /// </summary>
        [Preserve]
        [JsonConverter(typeof(StringEnumConverter))]
        [DataMember(Name = "buildType", EmitDefaultValue = false)]
        public BuildTypeOptions BuildType{ get; }
        
        /// <summary>
        /// Parameter ccd of MultiplayBuildsBuildCreateReq
        /// </summary>
        [Preserve]
        [DataMember(Name = "ccd", EmitDefaultValue = false)]
        public CCDDetails1 Ccd{ get; }
        
        /// <summary>
        /// The name of the build&#39;s current version. However, it is not relevant for container builds, in which the &#39;imageTag&#39; is used instead.
        /// </summary>
        [Preserve]
        [DataMember(Name = "buildVersionName", EmitDefaultValue = false)]
        public string BuildVersionName{ get; }
    
        /// <summary>
        /// The operating system family to use for the build: * &#x60;LINUX&#x60; - The build is for Linux. 
        /// </summary>
        /// <value>The operating system family to use for the build: * &#x60;LINUX&#x60; - The build is for Linux. </value>
        [Preserve]
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OsFamilyOptions
        {
            /// <summary>
            /// Enum LINUX for value: LINUX
            /// </summary>
            [EnumMember(Value = "LINUX")]
            LINUX = 1
        }

        /// <summary>
        /// The upload type of the build:   * &#x60;FILE_UPLOAD&#x60; - The build is created using directly uploaded game files, backed by CCD as the storage driver.   * &#x60;CONTAINER&#x60; - The build is created using a container image containing game files.   * &#x60;S3&#x60; - The build is created using an external Amazon S3 Bucket containing game files. 
        /// </summary>
        /// <value>The upload type of the build:   * &#x60;FILE_UPLOAD&#x60; - The build is created using directly uploaded game files, backed by CCD as the storage driver.   * &#x60;CONTAINER&#x60; - The build is created using a container image containing game files.   * &#x60;S3&#x60; - The build is created using an external Amazon S3 Bucket containing game files. </value>
        [Preserve]
        [JsonConverter(typeof(StringEnumConverter))]
        public enum BuildTypeOptions
        {
            /// <summary>
            /// Enum FILEUPLOAD for value: FILE_UPLOAD
            /// </summary>
            [EnumMember(Value = "FILE_UPLOAD")]
            FILEUPLOAD = 1,
            /// <summary>
            /// Enum CONTAINER for value: CONTAINER
            /// </summary>
            [EnumMember(Value = "CONTAINER")]
            CONTAINER = 2,
            /// <summary>
            /// Enum S3 for value: S3
            /// </summary>
            [EnumMember(Value = "S3")]
            S3 = 3,
            /// <summary>
            /// Enum GCS for value: GCS
            /// </summary>
            [EnumMember(Value = "GCS")]
            GCS = 4
        }

        /// <summary>
        /// Formats a MultiplayBuildsBuildCreateReq into a string of key-value pairs for use as a path parameter.
        /// </summary>
        /// <returns>Returns a string representation of the key-value pairs.</returns>
        internal string SerializeAsPathParam()
        {
            var serializedModel = "";

            if (BuildName != null)
            {
                serializedModel += "buildName," + BuildName + ",";
            }
            serializedModel += "osFamily," + OsFamily + ",";
            serializedModel += "buildType," + BuildType + ",";
            if (Ccd != null)
            {
                serializedModel += "ccd," + Ccd.ToString() + ",";
            }
            if (BuildVersionName != null)
            {
                serializedModel += "buildVersionName," + BuildVersionName;
            }
            return serializedModel;
        }

        /// <summary>
        /// Returns a MultiplayBuildsBuildCreateReq as a dictionary of key-value pairs for use as a query parameter.
        /// </summary>
        /// <returns>Returns a dictionary of string key-value pairs.</returns>
        internal Dictionary<string, string> GetAsQueryParam()
        {
            var dictionary = new Dictionary<string, string>();

            if (BuildName != null)
            {
                var buildNameStringValue = BuildName.ToString();
                dictionary.Add("buildName", buildNameStringValue);
            }
            
            var osFamilyStringValue = OsFamily.ToString();
            dictionary.Add("osFamily", osFamilyStringValue);
            
            var buildTypeStringValue = BuildType.ToString();
            dictionary.Add("buildType", buildTypeStringValue);
            
            if (BuildVersionName != null)
            {
                var buildVersionNameStringValue = BuildVersionName.ToString();
                dictionary.Add("buildVersionName", buildVersionNameStringValue);
            }
            
            return dictionary;
        }
    }
}
