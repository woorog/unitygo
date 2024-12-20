
//-----------------------------------------------------------------------------
// <auto-generated>
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//-----------------------------------------------------------------------------
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using UnityEngine.Scripting;
using Unity.Services.Authentication.Server.Shared;

namespace Unity.Services.Authentication.Server.ServiceAuth.Generated
{
    /// <summary>
    /// ExchangeRequest
    /// </summary>
    [DataContract(Name = "ExchangeRequest")]
    [Preserve]
    internal partial class ExchangeRequest
    {
        /// <summary>
        /// List of requested permissions
        /// </summary>
        /// <value>List of requested permissions</value>
        [DataMember(Name = "scopes", EmitDefaultValue = false)]
        [Preserve]
        public List<string> Scopes { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExchangeRequest" /> class.
        /// </summary>
        /// <param name="scopes">List of requested permissions.</param>
        [Preserve]
        public ExchangeRequest(List<string> scopes = default(List<string>))
        {
            this.Scopes = scopes;
        }
    }

}