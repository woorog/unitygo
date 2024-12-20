//-----------------------------------------------------------------------------
// <auto-generated>
//     This file was generated by the C# SDK Code Generator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//-----------------------------------------------------------------------------


using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Utilities;
using UnityEngine;

namespace Unity.Services.Multiplay.Authoring.Editor.AdminApis.Allocations.Http
{
    /// <summary>
    /// JsonHelpers class
    /// </summary>
    internal static class JsonHelpers
    {
        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSplashScreen)]
        internal static void RegisterTypesForAOT()
        {
            AotHelper.EnsureType<StringEnumConverter>();
            AotHelper.EnsureType<JsonObjectConverter>();
        }

        internal static bool TryParseJson<T>(this string @this, out T result)
        {
            var success = true;
            var settings = new JsonSerializerSettings
            {
                Error = (sender, args) =>
                {
                    success = false;
                    args.ErrorContext.Handled = true;
                },
                MissingMemberHandling = Newtonsoft.Json.MissingMemberHandling.Ignore,
                ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
            };
            result = IsolatedJsonConvert.DeserializeObject<T>(@this, settings);
            return success;
        }
    }
}
