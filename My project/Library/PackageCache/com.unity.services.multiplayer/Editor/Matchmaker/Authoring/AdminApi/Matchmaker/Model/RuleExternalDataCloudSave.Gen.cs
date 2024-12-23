#if UNITY_EDITOR || ENABLE_RUNTIME_ADMIN_APIS
//-----------------------------------------------------------------------------
// <auto-generated>
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//-----------------------------------------------------------------------------
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Unity.Services.Multiplayer.Editor.Matchmaker.Authoring.AdminApi.Shared;
using UnityEngine.Scripting;

namespace Unity.Services.Multiplayer.Editor.Matchmaker.Authoring.AdminApi.Matchmaker.Model
{
    /// <summary>
    /// RuleExternalDataCloudSave
    /// </summary>
    [DataContract(Name = "Rule_externalData_cloudSave")]
    [Preserve]
    partial class RuleExternalDataCloudSave
    {
        /// <summary>
        /// Defines AccessClass
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AccessClassEnum
        {
            /// <summary>
            /// Enum Default for value: default
            /// </summary>
            [EnumMember(Value = "default")]
            Default = 1,

            /// <summary>
            /// Enum Public for value: public
            /// </summary>
            [EnumMember(Value = "public")]
            Public = 2,

            /// <summary>
            /// Enum Protected for value: protected
            /// </summary>
            [EnumMember(Value = "protected")]
            Protected = 3,

            /// <summary>
            /// Enum Private for value: private
            /// </summary>
            [EnumMember(Value = "private")]
            Private = 4

        }

        /// <summary>
        /// Gets or Sets AccessClass
        /// </summary>
        [DataMember(Name = "accessClass", EmitDefaultValue = false)]
        [Preserve]
        public AccessClassEnum? AccessClass { get; set; }
        /// <summary>
        /// Gets or Sets Default
        /// </summary>
        [DataMember(Name = "default", EmitDefaultValue = true)]
        [Preserve]
        public ApiObject Default { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="RuleExternalDataCloudSave" /> class.
        /// </summary>
        /// <param name="_default">_default.</param>
        /// <param name="accessClass">accessClass.</param>
        [Preserve]
        public RuleExternalDataCloudSave(ApiObject _default = default(ApiObject), AccessClassEnum? accessClass = default(AccessClassEnum?))
        {
            this.Default = _default;
            this.AccessClass = accessClass;
        }
    }

}
#endif
