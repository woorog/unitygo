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
    /// MultiplayFleetStatus enum.
    /// </summary>
    /// <value>Current status of the fleet.</value>

    [Preserve]
    [JsonConverter(typeof(StringEnumConverter))]
    internal enum MultiplayFleetStatus
    {
        /// <summary>
        /// Enum ONLINE for value: ONLINE
        /// </summary>
        [EnumMember(Value = "ONLINE")]
        ONLINE = 1,

        /// <summary>
        /// Enum DRAINING for value: DRAINING
        /// </summary>
        [EnumMember(Value = "DRAINING")]
        DRAINING = 2,

        /// <summary>
        /// Enum OFFLINE for value: OFFLINE
        /// </summary>
        [EnumMember(Value = "OFFLINE")]
        OFFLINE = 3

    }
}



