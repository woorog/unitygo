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
using Unity.Services.Multiplay.Authoring.Editor.AdminApis.Allocations.Http;



namespace Unity.Services.Multiplay.Authoring.Editor.AdminApis.Allocations.Models
{
    /// <summary>
    /// A single test allocation, possibly within an allocations list.
    /// </summary>
    [Preserve]
    [DataContract(Name = "Test_Allocation")]
    internal class TestAllocation
    {
        /// <summary>
        /// A single test allocation, possibly within an allocations list.
        /// </summary>
        /// <param name="allocationId">The ID of the allocation.</param>
        /// <param name="fleetId">ID of the Fleet.</param>
        /// <param name="regionId">ID of the Region.</param>
        /// <param name="buildConfigurationId">ID of the build configuration.</param>
        /// <param name="requestId">The unique ID of this allocation request.</param>
        /// <param name="serverId">ID of the server.</param>
        /// <param name="machineId">ID of the machine.</param>
        /// <param name="ipv4">IPv4 of the allocated server.</param>
        /// <param name="ipv6">IPv6 of the allocated server.</param>
        /// <param name="gamePort">The port of the allocated server on the machine.</param>
        /// <param name="requested">The time at which the allocation was requested.</param>
        /// <param name="created">The time at which the allocation was created.</param>
        /// <param name="fulfilled">The time at which the allocation was fulfilled.</param>
        /// <param name="failed">Has the Allocation failed</param>
        [Preserve]
        public TestAllocation(System.Guid allocationId, System.Guid fleetId = default, System.Guid regionId = default, long buildConfigurationId = default, System.Guid requestId = default, long serverId = default, long machineId = default, string ipv4 = default, string ipv6 = default, int gamePort = default, DateTime requested = default, DateTime created = default, DateTime fulfilled = default, bool failed = default)
        {
            AllocationId = allocationId;
            FleetId = fleetId;
            RegionId = regionId;
            BuildConfigurationId = buildConfigurationId;
            RequestId = requestId;
            ServerId = serverId;
            MachineId = machineId;
            Ipv4 = ipv4;
            Ipv6 = ipv6;
            GamePort = gamePort;
            Requested = requested;
            Created = created;
            Fulfilled = fulfilled;
            Failed = failed;
        }

        /// <summary>
        /// The ID of the allocation.
        /// </summary>
        [Preserve]
        [DataMember(Name = "allocationId", IsRequired = true, EmitDefaultValue = true)]
        public System.Guid AllocationId{ get; }

        /// <summary>
        /// ID of the Fleet.
        /// </summary>
        [Preserve]
        [DataMember(Name = "fleetId", EmitDefaultValue = false)]
        public System.Guid FleetId{ get; }

        /// <summary>
        /// ID of the Region.
        /// </summary>
        [Preserve]
        [DataMember(Name = "regionId", EmitDefaultValue = false)]
        public System.Guid RegionId{ get; }

        /// <summary>
        /// ID of the build configuration.
        /// </summary>
        [Preserve]
        [DataMember(Name = "buildConfigurationId", EmitDefaultValue = false)]
        public long BuildConfigurationId{ get; }

        /// <summary>
        /// The unique ID of this allocation request.
        /// </summary>
        [Preserve]
        [DataMember(Name = "requestId", EmitDefaultValue = false)]
        public System.Guid RequestId{ get; }

        /// <summary>
        /// ID of the server.
        /// </summary>
        [Preserve]
        [DataMember(Name = "serverId", EmitDefaultValue = false)]
        public long ServerId{ get; }

        /// <summary>
        /// ID of the machine.
        /// </summary>
        [Preserve]
        [DataMember(Name = "machineId", EmitDefaultValue = false)]
        public long MachineId{ get; }

        /// <summary>
        /// IPv4 of the allocated server.
        /// </summary>
        [Preserve]
        [DataMember(Name = "ipv4", EmitDefaultValue = false)]
        public string Ipv4{ get; }

        /// <summary>
        /// IPv6 of the allocated server.
        /// </summary>
        [Preserve]
        [DataMember(Name = "ipv6", EmitDefaultValue = false)]
        public string Ipv6{ get; }

        /// <summary>
        /// The port of the allocated server on the machine.
        /// </summary>
        [Preserve]
        [DataMember(Name = "gamePort", EmitDefaultValue = false)]
        public int GamePort{ get; }

        /// <summary>
        /// The time at which the allocation was requested.
        /// </summary>
        [Preserve]
        [DataMember(Name = "requested", EmitDefaultValue = false)]
        public DateTime Requested{ get; }

        /// <summary>
        /// The time at which the allocation was created.
        /// </summary>
        [Preserve]
        [DataMember(Name = "created", EmitDefaultValue = false)]
        public DateTime Created{ get; }

        /// <summary>
        /// The time at which the allocation was fulfilled.
        /// </summary>
        [Preserve]
        [DataMember(Name = "fulfilled", EmitDefaultValue = false)]
        public DateTime Fulfilled{ get; }

        /// <summary>
        /// Has the Allocation failed
        /// </summary>
        [Preserve]
        [DataMember(Name = "failed", EmitDefaultValue = true)]
        public bool Failed{ get; }

        /// <summary>
        /// Formats a TestAllocation into a string of key-value pairs for use as a path parameter.
        /// </summary>
        /// <returns>Returns a string representation of the key-value pairs.</returns>
        internal string SerializeAsPathParam()
        {
            var serializedModel = "";

            if (AllocationId != null)
            {
                serializedModel += "allocationId," + AllocationId + ",";
            }
            if (FleetId != null)
            {
                serializedModel += "fleetId," + FleetId + ",";
            }
            if (RegionId != null)
            {
                serializedModel += "regionId," + RegionId + ",";
            }
            serializedModel += "buildConfigurationId," + BuildConfigurationId.ToString() + ",";
            if (RequestId != null)
            {
                serializedModel += "requestId," + RequestId + ",";
            }
            serializedModel += "serverId," + ServerId.ToString() + ",";
            serializedModel += "machineId," + MachineId.ToString() + ",";
            if (Ipv4 != null)
            {
                serializedModel += "ipv4," + Ipv4 + ",";
            }
            if (Ipv6 != null)
            {
                serializedModel += "ipv6," + Ipv6 + ",";
            }
            serializedModel += "gamePort," + GamePort.ToString() + ",";
            if (Requested != null)
            {
                serializedModel += "requested," + Requested.ToString() + ",";
            }
            if (Created != null)
            {
                serializedModel += "created," + Created.ToString() + ",";
            }
            if (Fulfilled != null)
            {
                serializedModel += "fulfilled," + Fulfilled.ToString() + ",";
            }
            serializedModel += "failed," + Failed.ToString();
            return serializedModel;
        }

        /// <summary>
        /// Returns a TestAllocation as a dictionary of key-value pairs for use as a query parameter.
        /// </summary>
        /// <returns>Returns a dictionary of string key-value pairs.</returns>
        internal Dictionary<string, string> GetAsQueryParam()
        {
            var dictionary = new Dictionary<string, string>();

            if (AllocationId != null)
            {
                var allocationIdStringValue = AllocationId.ToString();
                dictionary.Add("allocationId", allocationIdStringValue);
            }

            if (FleetId != null)
            {
                var fleetIdStringValue = FleetId.ToString();
                dictionary.Add("fleetId", fleetIdStringValue);
            }

            if (RegionId != null)
            {
                var regionIdStringValue = RegionId.ToString();
                dictionary.Add("regionId", regionIdStringValue);
            }

            var buildConfigurationIdStringValue = BuildConfigurationId.ToString();
            dictionary.Add("buildConfigurationId", buildConfigurationIdStringValue);

            if (RequestId != null)
            {
                var requestIdStringValue = RequestId.ToString();
                dictionary.Add("requestId", requestIdStringValue);
            }

            var serverIdStringValue = ServerId.ToString();
            dictionary.Add("serverId", serverIdStringValue);

            var machineIdStringValue = MachineId.ToString();
            dictionary.Add("machineId", machineIdStringValue);

            if (Ipv4 != null)
            {
                var ipv4StringValue = Ipv4.ToString();
                dictionary.Add("ipv4", ipv4StringValue);
            }

            if (Ipv6 != null)
            {
                var ipv6StringValue = Ipv6.ToString();
                dictionary.Add("ipv6", ipv6StringValue);
            }

            var gamePortStringValue = GamePort.ToString();
            dictionary.Add("gamePort", gamePortStringValue);

            if (Requested != null)
            {
                var requestedStringValue = Requested.ToString();
                dictionary.Add("requested", requestedStringValue);
            }

            if (Created != null)
            {
                var createdStringValue = Created.ToString();
                dictionary.Add("created", createdStringValue);
            }

            if (Fulfilled != null)
            {
                var fulfilledStringValue = Fulfilled.ToString();
                dictionary.Add("fulfilled", fulfilledStringValue);
            }

            var failedStringValue = Failed.ToString();
            dictionary.Add("failed", failedStringValue);

            return dictionary;
        }
    }
}
