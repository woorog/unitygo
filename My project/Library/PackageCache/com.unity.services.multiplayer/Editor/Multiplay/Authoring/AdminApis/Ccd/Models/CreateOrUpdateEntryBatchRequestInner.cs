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
using Unity.Services.Multiplay.Authoring.Editor.AdminApis.Ccd.Http;



namespace Unity.Services.Multiplay.Authoring.Editor.AdminApis.Ccd.Models
{
    /// <summary>
    /// CreateOrUpdateEntryBatchRequestInner model
    /// </summary>
    [Preserve]
    [DataContract(Name = "CreateOrUpdateEntryBatch_request_inner")]
    internal class CreateOrUpdateEntryBatchRequestInner
    {
        /// <summary>
        /// Creates an instance of CreateOrUpdateEntryBatchRequestInner.
        /// </summary>
        /// <param name="path">path param</param>
        /// <param name="contentHash">The \&quot;content_hash\&quot; should be MD5sum hash value.</param>
        /// <param name="contentSize">contentSize param</param>
        /// <param name="contentType">contentType param</param>
        /// <param name="labels">labels param</param>
        /// <param name="metadata">metadata param</param>
        [Preserve]
        public CreateOrUpdateEntryBatchRequestInner(string path, string contentHash = default, long contentSize = default, string contentType = default, List<string> labels = default, object metadata = default)
        {
            ContentHash = contentHash;
            ContentSize = contentSize;
            ContentType = contentType;
            Labels = labels;
            Metadata = (IDeserializable) JsonObject.GetNewJsonObjectResponse(metadata);
            Path = path;
        }

        /// <summary>
        /// The \&quot;content_hash\&quot; should be MD5sum hash value.
        /// </summary>
        [Preserve]
        [DataMember(Name = "content_hash", EmitDefaultValue = false)]
        public string ContentHash{ get; }
        
        /// <summary>
        /// Parameter content_size of CreateOrUpdateEntryBatchRequestInner
        /// </summary>
        [Preserve]
        [DataMember(Name = "content_size", EmitDefaultValue = false)]
        public long ContentSize{ get; }
        
        /// <summary>
        /// Parameter content_type of CreateOrUpdateEntryBatchRequestInner
        /// </summary>
        [Preserve]
        [DataMember(Name = "content_type", EmitDefaultValue = false)]
        public string ContentType{ get; }
        
        /// <summary>
        /// Parameter labels of CreateOrUpdateEntryBatchRequestInner
        /// </summary>
        [Preserve]
        [DataMember(Name = "labels", EmitDefaultValue = false)]
        public List<string> Labels{ get; }
        
        /// <summary>
        /// Parameter metadata of CreateOrUpdateEntryBatchRequestInner
        /// </summary>
        [Preserve][JsonConverter(typeof(JsonObjectConverter))]
        [DataMember(Name = "metadata", EmitDefaultValue = false)]
        public IDeserializable Metadata{ get; }
        
        /// <summary>
        /// Parameter path of CreateOrUpdateEntryBatchRequestInner
        /// </summary>
        [Preserve]
        [DataMember(Name = "path", IsRequired = true, EmitDefaultValue = true)]
        public string Path{ get; }
    
        /// <summary>
        /// Formats a CreateOrUpdateEntryBatchRequestInner into a string of key-value pairs for use as a path parameter.
        /// </summary>
        /// <returns>Returns a string representation of the key-value pairs.</returns>
        internal string SerializeAsPathParam()
        {
            var serializedModel = "";

            if (ContentHash != null)
            {
                serializedModel += "content_hash," + ContentHash + ",";
            }
            serializedModel += "content_size," + ContentSize.ToString() + ",";
            if (ContentType != null)
            {
                serializedModel += "content_type," + ContentType + ",";
            }
            if (Labels != null)
            {
                serializedModel += "labels," + Labels.ToString() + ",";
            }
            if (Metadata != null)
            {
                serializedModel += "metadata," + Metadata.ToString() + ",";
            }
            if (Path != null)
            {
                serializedModel += "path," + Path;
            }
            return serializedModel;
        }

        /// <summary>
        /// Returns a CreateOrUpdateEntryBatchRequestInner as a dictionary of key-value pairs for use as a query parameter.
        /// </summary>
        /// <returns>Returns a dictionary of string key-value pairs.</returns>
        internal Dictionary<string, string> GetAsQueryParam()
        {
            var dictionary = new Dictionary<string, string>();

            if (ContentHash != null)
            {
                var content_hashStringValue = ContentHash.ToString();
                dictionary.Add("content_hash", content_hashStringValue);
            }
            
            var content_sizeStringValue = ContentSize.ToString();
            dictionary.Add("content_size", content_sizeStringValue);
            
            if (ContentType != null)
            {
                var content_typeStringValue = ContentType.ToString();
                dictionary.Add("content_type", content_typeStringValue);
            }
            
            if (Labels != null)
            {
                var labelsStringValue = Labels.ToString();
                dictionary.Add("labels", labelsStringValue);
            }
            
            if (Path != null)
            {
                var pathStringValue = Path.ToString();
                dictionary.Add("path", pathStringValue);
            }
            
            return dictionary;
        }
    }
}
