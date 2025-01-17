#if UNITY_EDITOR || ENABLE_RUNTIME_ADMIN_APIS
//-----------------------------------------------------------------------------
// <auto-generated>
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//-----------------------------------------------------------------------------
using System.Collections.Generic;
using System.Runtime.Serialization;
using UnityEngine.Scripting;

namespace Unity.Services.Multiplayer.Editor.Matchmaker.Authoring.AdminApi.Matchmaker.Model
{
    /// <summary>
    /// Range
    /// </summary>
    [DataContract(Name = "Range")]
    [Preserve]
    partial class Range
    {
        /// <summary>
        /// Gets or Sets Min
        /// </summary>
        [DataMember(Name = "min", IsRequired = true, EmitDefaultValue = true)]
        [Preserve]
        public int Min { get; set; }

        /// <summary>
        /// Gets or Sets Max
        /// </summary>
        [DataMember(Name = "max", IsRequired = true, EmitDefaultValue = true)]
        [Preserve]
        public int Max { get; set; }

        /// <summary>
        /// Gets or Sets Relaxations
        /// </summary>
        [DataMember(Name = "relaxations", EmitDefaultValue = false)]
        [Preserve]
        public List<RangeRelaxation> Relaxations { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Range" /> class.
        /// </summary>
        /// <param name="min">min (required).</param>
        /// <param name="max">max (required).</param>
        /// <param name="relaxations">relaxations.</param>
        [Preserve]
        public Range(int min = default(int), int max = default(int), List<RangeRelaxation> relaxations = default(List<RangeRelaxation>))
        {
            this.Min = min;
            this.Max = max;
            this.Relaxations = relaxations;
        }
    }

}
#endif
