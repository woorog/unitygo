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



namespace Unity.Services.Multiplay.Authoring.Editor.AdminApis.Fleets.Models
{
    /// <summary>
    /// A fleet for managing game servers and machines.
    /// </summary>
    [Preserve]
    [DataContract(Name = "Fleet_List_Item")]
    internal class FleetListItem
    {
        /// <summary>
        /// A fleet for managing game servers and machines.
        /// </summary>
        /// <param name="id">ID of the Fleet.</param>
        /// <param name="name">Name of the fleet.</param>
        /// <param name="osID">ID of the Operating System used in the fleet.</param>
        /// <param name="osName">Name of the Operating System used in the fleet.</param>
        /// <param name="buildConfigurations">A list of build configurations associated with the fleet.</param>
        /// <param name="regions">A list regions associated with the fleet.</param>
        /// <param name="status">Current status of the fleet.</param>
        [Preserve]
        public FleetListItem(
            System.Guid id,
            string name,
            System.Guid osID,
            string osName,
            List<BuildConfiguration> buildConfigurations,
            List<FleetRegion> regions,
            StatusOptions status,
            FleetListItem.ServersAlloc servers = null)
        {
            Id = id;
            Name = name;
            OsID = osID;
            OsName = osName;
            BuildConfigurations = buildConfigurations;
            Regions = regions;
            Status = status;
            Servers = servers;
        }

        /// <summary>
        /// ID of the Fleet.
        /// </summary>
        [Preserve]
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public System.Guid Id{ get; }

        /// <summary>
        /// Name of the fleet.
        /// </summary>
        [Preserve]
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name{ get; }

        /// <summary>
        /// ID of the Operating System used in the fleet.
        /// </summary>
        [Preserve]
        [DataMember(Name = "osID", IsRequired = true, EmitDefaultValue = true)]
        public System.Guid OsID{ get; }

        /// <summary>
        /// Name of the Operating System used in the fleet.
        /// </summary>
        [Preserve]
        [DataMember(Name = "osName", IsRequired = true, EmitDefaultValue = true)]
        public string OsName{ get; }

        /// <summary>
        /// A list of build configurations associated with the fleet.
        /// </summary>
        [Preserve]
        [DataMember(Name = "buildConfigurations", IsRequired = true, EmitDefaultValue = true)]
        public List<BuildConfiguration> BuildConfigurations{ get; }

        /// <summary>
        /// A list regions associated with the fleet.
        /// </summary>
        [Preserve]
        [DataMember(Name = "regions", IsRequired = true, EmitDefaultValue = true)]
        public List<FleetRegion> Regions{ get; }

        /// <summary>
        /// Current status of the fleet.
        /// </summary>
        [Preserve]
        [JsonConverter(typeof(StringEnumConverter))]
        [DataMember(Name = "status", IsRequired = true, EmitDefaultValue = true)]
        public StatusOptions Status{ get; }

        [Preserve]
        [DataMember(Name = "servers", IsRequired = false, EmitDefaultValue = true)]
        public ServersAlloc Servers { get; set; }

        public class ServersAlloc
        {
            [Preserve]
            [DataMember(Name = "all", IsRequired = false, EmitDefaultValue = true)]
            public Allocations All { get; set; }
            [Preserve]
            [DataMember(Name = "cloud", IsRequired = false, EmitDefaultValue = true)]
            public Allocations Cloud { get; set; }
            [Preserve]
            [DataMember(Name = "metal", IsRequired = false, EmitDefaultValue = true)]
            public Allocations Metal { get; set; }
        }

        public class Allocations
        {
            [Preserve]
            [DataMember(Name = "status", IsRequired = true, EmitDefaultValue = true)]
            public AllocationStatus Status { get; set; }
            [Preserve]
            [DataMember(Name = "total", IsRequired = false, EmitDefaultValue = true)]
            public int Total { get; set; }
        }

        public class AllocationStatus
        {
            [Preserve]
            [DataMember(Name = "allocated", IsRequired = false, EmitDefaultValue = true)]
            public int Allocated { get; set; }
            [Preserve]
            [DataMember(Name = "avalaible", IsRequired = false, EmitDefaultValue = true)]
            public int Available { get; set; }
            [Preserve]
            [DataMember(Name = "online", IsRequired = false, EmitDefaultValue = true)]
            public int Online { get; set; }
        }

        /// <summary>
        /// Current status of the fleet.
        /// </summary>
        /// <value>Current status of the fleet.</value>
        [Preserve]
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusOptions
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

        /// <summary>
        /// Formats a FleetListItem into a string of key-value pairs for use as a path parameter.
        /// </summary>
        /// <returns>Returns a string representation of the key-value pairs.</returns>
        internal string SerializeAsPathParam()
        {
            var serializedModel = "";

            if (Id != null)
            {
                serializedModel += "id," + Id + ",";
            }
            if (Name != null)
            {
                serializedModel += "name," + Name + ",";
            }
            if (OsID != null)
            {
                serializedModel += "osID," + OsID + ",";
            }
            if (OsName != null)
            {
                serializedModel += "osName," + OsName + ",";
            }
            if (BuildConfigurations != null)
            {
                serializedModel += "buildConfigurations," + BuildConfigurations.ToString() + ",";
            }
            if (Regions != null)
            {
                serializedModel += "regions," + Regions.ToString() + ",";
            }
            serializedModel += "status," + Status;
            return serializedModel;
        }

        /// <summary>
        /// Returns a FleetListItem as a dictionary of key-value pairs for use as a query parameter.
        /// </summary>
        /// <returns>Returns a dictionary of string key-value pairs.</returns>
        internal Dictionary<string, string> GetAsQueryParam()
        {
            var dictionary = new Dictionary<string, string>();

            if (Id != null)
            {
                var idStringValue = Id.ToString();
                dictionary.Add("id", idStringValue);
            }

            if (Name != null)
            {
                var nameStringValue = Name.ToString();
                dictionary.Add("name", nameStringValue);
            }

            if (OsID != null)
            {
                var osIDStringValue = OsID.ToString();
                dictionary.Add("osID", osIDStringValue);
            }

            if (OsName != null)
            {
                var osNameStringValue = OsName.ToString();
                dictionary.Add("osName", osNameStringValue);
            }

            var statusStringValue = Status.ToString();
            dictionary.Add("status", statusStringValue);

            return dictionary;
        }
    }
}