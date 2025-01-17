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
    /// UpdatePermissionByBucketRequest model
    /// </summary>
    [Preserve]
    [DataContract(Name = "UpdatePermissionByBucket_request")]
    internal class UpdatePermissionByBucketRequest
    {
        /// <summary>
        /// Creates an instance of UpdatePermissionByBucketRequest.
        /// </summary>
        /// <param name="action">action param</param>
        /// <param name="permission">permission param</param>
        /// <param name="role">role param</param>
        [Preserve]
        public UpdatePermissionByBucketRequest(ActionOptions action, PermissionOptions permission, RoleOptions role = RoleOptions.User)
        {
            Action = action;
            Permission = permission;
            Role = role;
        }

        /// <summary>
        /// Parameter action of UpdatePermissionByBucketRequest
        /// </summary>
        [Preserve]
        [JsonConverter(typeof(StringEnumConverter))]
        [DataMember(Name = "action", IsRequired = true, EmitDefaultValue = true)]
        public ActionOptions Action{ get; }
        
        /// <summary>
        /// Parameter permission of UpdatePermissionByBucketRequest
        /// </summary>
        [Preserve]
        [JsonConverter(typeof(StringEnumConverter))]
        [DataMember(Name = "permission", IsRequired = true, EmitDefaultValue = true)]
        public PermissionOptions Permission{ get; }
        
        /// <summary>
        /// Parameter role of UpdatePermissionByBucketRequest
        /// </summary>
        [Preserve]
        [JsonConverter(typeof(StringEnumConverter))]
        [DataMember(Name = "role", EmitDefaultValue = false)]
        public RoleOptions Role{ get; }
    
        /// <summary>
        /// Defines Action
        /// </summary>
        [Preserve]
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ActionOptions
        {
            /// <summary>
            /// Enum Write for value: write
            /// </summary>
            [EnumMember(Value = "write")]
            Write = 1,
            /// <summary>
            /// Enum ListEntries for value: list-entries
            /// </summary>
            [EnumMember(Value = "list-entries")]
            ListEntries = 2,
            /// <summary>
            /// Enum ListReleases for value: list-releases
            /// </summary>
            [EnumMember(Value = "list-releases")]
            ListReleases = 3
        }

        /// <summary>
        /// Defines Permission
        /// </summary>
        [Preserve]
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PermissionOptions
        {
            /// <summary>
            /// Enum Allow for value: allow
            /// </summary>
            [EnumMember(Value = "allow")]
            Allow = 1,
            /// <summary>
            /// Enum Deny for value: deny
            /// </summary>
            [EnumMember(Value = "deny")]
            Deny = 2
        }

        /// <summary>
        /// Defines Role
        /// </summary>
        [Preserve]
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RoleOptions
        {
            /// <summary>
            /// Enum User for value: user
            /// </summary>
            [EnumMember(Value = "user")]
            User = 1,
            /// <summary>
            /// Enum Client for value: client
            /// </summary>
            [EnumMember(Value = "client")]
            Client = 2
        }

        /// <summary>
        /// Formats a UpdatePermissionByBucketRequest into a string of key-value pairs for use as a path parameter.
        /// </summary>
        /// <returns>Returns a string representation of the key-value pairs.</returns>
        internal string SerializeAsPathParam()
        {
            var serializedModel = "";

            serializedModel += "action," + Action + ",";
            serializedModel += "permission," + Permission + ",";
            serializedModel += "role," + Role;
            return serializedModel;
        }

        /// <summary>
        /// Returns a UpdatePermissionByBucketRequest as a dictionary of key-value pairs for use as a query parameter.
        /// </summary>
        /// <returns>Returns a dictionary of string key-value pairs.</returns>
        internal Dictionary<string, string> GetAsQueryParam()
        {
            var dictionary = new Dictionary<string, string>();

            var actionStringValue = Action.ToString();
            dictionary.Add("action", actionStringValue);
            
            var permissionStringValue = Permission.ToString();
            dictionary.Add("permission", permissionStringValue);
            
            var roleStringValue = Role.ToString();
            dictionary.Add("role", roleStringValue);
            
            return dictionary;
        }
    }
}
