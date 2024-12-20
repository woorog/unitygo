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
using Unity.Services.Multiplay.Authoring.Editor.AdminApis.Fleets.Http;

//-----------------------------------------------------------------------------
// <auto-generated>
//     This file was generated by the C# SDK Code Generator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//-----------------------------------------------------------------------------


namespace Unity.Services.Multiplay.Authoring.Editor.AdminApis.Fleets.Models
{
    /// <summary>
    /// MultiplayConflictType enum.
    /// </summary>
    /// <value>The type of conflict:   * `DEPENDENT` - The conflicting resource is dependent on the subject resource.   * `DEPENDENCY` - The conflicting resource is a dependency of the subject resource.   * `ACTIVE` - The conflict is due to the subject resource being in an active state.   * `INACTIVE` - The conflict is due to the subject resource being in an inactive state. </value>
    
    [Preserve]
    [JsonConverter(typeof(StringEnumConverter))]
    internal enum MultiplayConflictType
    {
        /// <summary>
        /// Enum DEPENDENT for value: DEPENDENT
        /// </summary>
        [EnumMember(Value = "DEPENDENT")]
        DEPENDENT = 1,

        /// <summary>
        /// Enum DEPENDENCY for value: DEPENDENCY
        /// </summary>
        [EnumMember(Value = "DEPENDENCY")]
        DEPENDENCY = 2,

        /// <summary>
        /// Enum ACTIVE for value: ACTIVE
        /// </summary>
        [EnumMember(Value = "ACTIVE")]
        ACTIVE = 3,

        /// <summary>
        /// Enum INACTIVE for value: INACTIVE
        /// </summary>
        [EnumMember(Value = "INACTIVE")]
        INACTIVE = 4

    }
}



