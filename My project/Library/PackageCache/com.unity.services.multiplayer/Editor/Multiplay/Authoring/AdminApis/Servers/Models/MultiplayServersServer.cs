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
using Unity.Services.Multiplay.Authoring.Editor.AdminApis.Servers.Http;



namespace Unity.Services.Multiplay.Authoring.Editor.AdminApis.Servers.Models
{
    /// <summary>
    /// A single server.
    /// </summary>
    [Preserve]
    [DataContract(Name = "multiplay.servers.server")]
    internal class MultiplayServersServer
    {
        /// <summary>
        /// A single server.
        /// </summary>
        /// <param name="id">ID of the server.</param>
        /// <param name="machineID">ID of the machine hosting the server.</param>
        /// <param name="machineName">Name of the machine hosting the server.</param>
        /// <param name="buildConfigurationID">ID of the associated build configuration.</param>
        /// <param name="buildConfigurationName">Name of the associated build configuration.</param>
        /// <param name="buildName">Name of the build for the associated build configuration.</param>
        /// <param name="fleetID">ID of the associated fleet.</param>
        /// <param name="fleetName">Name of the associated fleet.</param>
        /// <param name="locationID">ID of the associated location.</param>
        /// <param name="locationName">Name of the associated location.</param>
        /// <param name="ip">IP address of the server.</param>
        /// <param name="port">Network port the server is running on.</param>
        /// <param name="status">Status of the server.</param>
        /// <param name="cpuLimit">CPU Speed Limit (MHz) of the server.</param>
        /// <param name="memoryLimit">Memory (RAM) (MiB) Limit of the server.</param>
        /// <param name="hardwareType">Hardware type of the server.</param>
        /// <param name="machineSpec">machineSpec param</param>
        /// <param name="deleted">Whether the server is marked as deleted.</param>
        /// <param name="holdExpiresAt">The unix timestamp, in seconds, at which a held server automatically expires and releases its hold.</param>
        [Preserve]
        public MultiplayServersServer(long id, long machineID, string machineName, long buildConfigurationID, string buildConfigurationName, string buildName, System.Guid fleetID, string fleetName, long locationID, string locationName, string ip, int port, StatusOptions status, long cpuLimit, long memoryLimit, HardwareTypeOptions hardwareType, MachineSpec machineSpec, bool deleted, long holdExpiresAt = default)
        {
            Id = id;
            MachineID = machineID;
            MachineName = machineName;
            BuildConfigurationID = buildConfigurationID;
            BuildConfigurationName = buildConfigurationName;
            BuildName = buildName;
            FleetID = fleetID;
            FleetName = fleetName;
            LocationID = locationID;
            LocationName = locationName;
            Ip = ip;
            Port = port;
            Status = status;
            CpuLimit = cpuLimit;
            MemoryLimit = memoryLimit;
            HardwareType = hardwareType;
            MachineSpec = machineSpec;
            Deleted = deleted;
            HoldExpiresAt = holdExpiresAt;
        }

        /// <summary>
        /// ID of the server.
        /// </summary>
        [Preserve]
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public long Id{ get; }

        /// <summary>
        /// ID of the machine hosting the server.
        /// </summary>
        [Preserve]
        [DataMember(Name = "machineID", IsRequired = true, EmitDefaultValue = true)]
        public long MachineID{ get; }

        /// <summary>
        /// Name of the machine hosting the server.
        /// </summary>
        [Preserve]
        [DataMember(Name = "machineName", IsRequired = true, EmitDefaultValue = true)]
        public string MachineName{ get; }

        /// <summary>
        /// ID of the associated build configuration.
        /// </summary>
        [Preserve]
        [DataMember(Name = "buildConfigurationID", IsRequired = true, EmitDefaultValue = true)]
        public long BuildConfigurationID{ get; }

        /// <summary>
        /// Name of the associated build configuration.
        /// </summary>
        [Preserve]
        [DataMember(Name = "buildConfigurationName", IsRequired = true, EmitDefaultValue = true)]
        public string BuildConfigurationName{ get; }

        /// <summary>
        /// Name of the build for the associated build configuration.
        /// </summary>
        [Preserve]
        [DataMember(Name = "buildName", IsRequired = true, EmitDefaultValue = true)]
        public string BuildName{ get; }

        /// <summary>
        /// ID of the associated fleet.
        /// </summary>
        [Preserve]
        [DataMember(Name = "fleetID", IsRequired = true, EmitDefaultValue = true)]
        public System.Guid FleetID{ get; }

        /// <summary>
        /// Name of the associated fleet.
        /// </summary>
        [Preserve]
        [DataMember(Name = "fleetName", IsRequired = true, EmitDefaultValue = true)]
        public string FleetName{ get; }

        /// <summary>
        /// ID of the associated location.
        /// </summary>
        [Preserve]
        [DataMember(Name = "locationID", IsRequired = true, EmitDefaultValue = true)]
        public long LocationID{ get; }

        /// <summary>
        /// Name of the associated location.
        /// </summary>
        [Preserve]
        [DataMember(Name = "locationName", IsRequired = true, EmitDefaultValue = true)]
        public string LocationName{ get; }

        /// <summary>
        /// IP address of the server.
        /// </summary>
        [Preserve]
        [DataMember(Name = "ip", IsRequired = true, EmitDefaultValue = true)]
        public string Ip{ get; }

        /// <summary>
        /// Network port the server is running on.
        /// </summary>
        [Preserve]
        [DataMember(Name = "port", IsRequired = true, EmitDefaultValue = true)]
        public int Port{ get; }

        /// <summary>
        /// Status of the server.
        /// </summary>
        [Preserve]
        [JsonConverter(typeof(StringEnumConverter))]
        [DataMember(Name = "status", IsRequired = true, EmitDefaultValue = true)]
        public StatusOptions Status{ get; }

        /// <summary>
        /// CPU Speed Limit (MHz) of the server.
        /// </summary>
        [Preserve]
        [DataMember(Name = "cpuLimit", IsRequired = true, EmitDefaultValue = true)]
        public long CpuLimit{ get; }

        /// <summary>
        /// Memory (RAM) (MiB) Limit of the server.
        /// </summary>
        [Preserve]
        [DataMember(Name = "memoryLimit", IsRequired = true, EmitDefaultValue = true)]
        public long MemoryLimit{ get; }

        /// <summary>
        /// Hardware type of the server.
        /// </summary>
        [Preserve]
        [JsonConverter(typeof(StringEnumConverter))]
        [DataMember(Name = "hardwareType", IsRequired = true, EmitDefaultValue = true)]
        public HardwareTypeOptions HardwareType{ get; }

        /// <summary>
        /// Parameter machineSpec of MultiplayServersServer
        /// </summary>
        [Preserve]
        [DataMember(Name = "machineSpec", IsRequired = true, EmitDefaultValue = true)]
        public MachineSpec MachineSpec{ get; }

        /// <summary>
        /// Whether the server is marked as deleted.
        /// </summary>
        [Preserve]
        [DataMember(Name = "deleted", IsRequired = true, EmitDefaultValue = true)]
        public bool Deleted{ get; }

        /// <summary>
        /// The unix timestamp, in seconds, at which a held server automatically expires and releases its hold.
        /// </summary>
        [Preserve]
        [DataMember(Name = "holdExpiresAt", EmitDefaultValue = false)]
        public long HoldExpiresAt{ get; }

        /// <summary>
        /// Status of the server.
        /// </summary>
        /// <value>Status of the server.</value>
        [Preserve]
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusOptions
        {
            /// <summary>
            /// Enum ALLOCATED for value: ALLOCATED
            /// </summary>
            [EnumMember(Value = "ALLOCATED")]
            ALLOCATED = 1,
            /// <summary>
            /// Enum RESERVED for value: RESERVED
            /// </summary>
            [EnumMember(Value = "RESERVED")]
            RESERVED = 2,
            /// <summary>
            /// Enum AVAILABLE for value: AVAILABLE
            /// </summary>
            [EnumMember(Value = "AVAILABLE")]
            AVAILABLE = 3,
            /// <summary>
            /// Enum ONLINE for value: ONLINE
            /// </summary>
            [EnumMember(Value = "ONLINE")]
            ONLINE = 4,
            /// <summary>
            /// Enum READY for value: READY
            /// </summary>
            [EnumMember(Value = "READY")]
            READY = 5,
            /// <summary>
            /// Enum HELD for value: HELD
            /// </summary>
            [EnumMember(Value = "HELD")]
            HELD = 6
        }

        /// <summary>
        /// Hardware type of the server.
        /// </summary>
        /// <value>Hardware type of the server.</value>
        [Preserve]
        [JsonConverter(typeof(StringEnumConverter))]
        public enum HardwareTypeOptions
        {
            /// <summary>
            /// Enum CLOUD for value: CLOUD
            /// </summary>
            [EnumMember(Value = "CLOUD")]
            CLOUD = 1,
            /// <summary>
            /// Enum METAL for value: METAL
            /// </summary>
            [EnumMember(Value = "METAL")]
            METAL = 2
        }

        /// <summary>
        /// Formats a MultiplayServersServer into a string of key-value pairs for use as a path parameter.
        /// </summary>
        /// <returns>Returns a string representation of the key-value pairs.</returns>
        internal string SerializeAsPathParam()
        {
            var serializedModel = "";

            serializedModel += "id," + Id.ToString() + ",";
            serializedModel += "machineID," + MachineID.ToString() + ",";
            if (MachineName != null)
            {
                serializedModel += "machineName," + MachineName + ",";
            }
            serializedModel += "buildConfigurationID," + BuildConfigurationID.ToString() + ",";
            if (BuildConfigurationName != null)
            {
                serializedModel += "buildConfigurationName," + BuildConfigurationName + ",";
            }
            if (BuildName != null)
            {
                serializedModel += "buildName," + BuildName + ",";
            }
            if (FleetID != null)
            {
                serializedModel += "fleetID," + FleetID + ",";
            }
            if (FleetName != null)
            {
                serializedModel += "fleetName," + FleetName + ",";
            }
            serializedModel += "locationID," + LocationID.ToString() + ",";
            if (LocationName != null)
            {
                serializedModel += "locationName," + LocationName + ",";
            }
            if (Ip != null)
            {
                serializedModel += "ip," + Ip + ",";
            }
            serializedModel += "port," + Port.ToString() + ",";
            serializedModel += "status," + Status + ",";
            serializedModel += "cpuLimit," + CpuLimit.ToString() + ",";
            serializedModel += "memoryLimit," + MemoryLimit.ToString() + ",";
            serializedModel += "hardwareType," + HardwareType + ",";
            if (MachineSpec != null)
            {
                serializedModel += "machineSpec," + MachineSpec.ToString() + ",";
            }
            serializedModel += "deleted," + Deleted.ToString() + ",";
            serializedModel += "holdExpiresAt," + HoldExpiresAt.ToString();
            return serializedModel;
        }

        /// <summary>
        /// Returns a MultiplayServersServer as a dictionary of key-value pairs for use as a query parameter.
        /// </summary>
        /// <returns>Returns a dictionary of string key-value pairs.</returns>
        internal Dictionary<string, string> GetAsQueryParam()
        {
            var dictionary = new Dictionary<string, string>();

            var idStringValue = Id.ToString();
            dictionary.Add("id", idStringValue);

            var machineIDStringValue = MachineID.ToString();
            dictionary.Add("machineID", machineIDStringValue);

            if (MachineName != null)
            {
                var machineNameStringValue = MachineName.ToString();
                dictionary.Add("machineName", machineNameStringValue);
            }

            var buildConfigurationIDStringValue = BuildConfigurationID.ToString();
            dictionary.Add("buildConfigurationID", buildConfigurationIDStringValue);

            if (BuildConfigurationName != null)
            {
                var buildConfigurationNameStringValue = BuildConfigurationName.ToString();
                dictionary.Add("buildConfigurationName", buildConfigurationNameStringValue);
            }

            if (BuildName != null)
            {
                var buildNameStringValue = BuildName.ToString();
                dictionary.Add("buildName", buildNameStringValue);
            }

            if (FleetID != null)
            {
                var fleetIDStringValue = FleetID.ToString();
                dictionary.Add("fleetID", fleetIDStringValue);
            }

            if (FleetName != null)
            {
                var fleetNameStringValue = FleetName.ToString();
                dictionary.Add("fleetName", fleetNameStringValue);
            }

            var locationIDStringValue = LocationID.ToString();
            dictionary.Add("locationID", locationIDStringValue);

            if (LocationName != null)
            {
                var locationNameStringValue = LocationName.ToString();
                dictionary.Add("locationName", locationNameStringValue);
            }

            if (Ip != null)
            {
                var ipStringValue = Ip.ToString();
                dictionary.Add("ip", ipStringValue);
            }

            var portStringValue = Port.ToString();
            dictionary.Add("port", portStringValue);

            var statusStringValue = Status.ToString();
            dictionary.Add("status", statusStringValue);

            var cpuLimitStringValue = CpuLimit.ToString();
            dictionary.Add("cpuLimit", cpuLimitStringValue);

            var memoryLimitStringValue = MemoryLimit.ToString();
            dictionary.Add("memoryLimit", memoryLimitStringValue);

            var hardwareTypeStringValue = HardwareType.ToString();
            dictionary.Add("hardwareType", hardwareTypeStringValue);

            var deletedStringValue = Deleted.ToString();
            dictionary.Add("deleted", deletedStringValue);

            var holdExpiresAtStringValue = HoldExpiresAt.ToString();
            dictionary.Add("holdExpiresAt", holdExpiresAtStringValue);

            return dictionary;
        }
    }
}
