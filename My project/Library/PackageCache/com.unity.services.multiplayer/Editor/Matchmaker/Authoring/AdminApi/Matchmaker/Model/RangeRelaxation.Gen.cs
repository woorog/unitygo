#if UNITY_EDITOR || ENABLE_RUNTIME_ADMIN_APIS
//-----------------------------------------------------------------------------
// <auto-generated>
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//-----------------------------------------------------------------------------
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using UnityEngine.Scripting;

namespace Unity.Services.Multiplayer.Editor.Matchmaker.Authoring.AdminApi.Matchmaker.Model
{
    /// <summary>
    /// RangeRelaxation
    /// </summary>
    [DataContract(Name = "RangeRelaxation")]
    [Preserve]
    partial class RangeRelaxation
    {
        /// <summary>
        /// Defines Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum RangeControlReplaceMin for value: RangeControl.ReplaceMin
            /// </summary>
            [EnumMember(Value = "RangeControl.ReplaceMin")]
            RangeControlReplaceMin = 1

        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        [Preserve]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Gets or Sets AgeType
        /// </summary>
        [DataMember(Name = "ageType", IsRequired = true, EmitDefaultValue = true)]
        [Preserve]
        public AgeType AgeType { get; set; }
        /// <summary>
        /// Gets or Sets AtSeconds
        /// </summary>
        [DataMember(Name = "atSeconds", IsRequired = true, EmitDefaultValue = true)]
        [Preserve]
        public double AtSeconds { get; set; }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name = "value", IsRequired = true, EmitDefaultValue = true)]
        [Preserve]
        public double Value { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="RangeRelaxation" /> class.
        /// </summary>
        /// <param name="type">type (required).</param>
        /// <param name="atSeconds">atSeconds (required).</param>
        /// <param name="ageType">ageType (required).</param>
        /// <param name="value">value (required).</param>
        [Preserve]
        public RangeRelaxation(TypeEnum type = default(TypeEnum), double atSeconds = default(double), AgeType ageType = default(AgeType), double value = default(double))
        {
            this.Type = type;
            this.AtSeconds = atSeconds;
            this.AgeType = ageType;
            this.Value = value;
        }
    }

}
#endif
