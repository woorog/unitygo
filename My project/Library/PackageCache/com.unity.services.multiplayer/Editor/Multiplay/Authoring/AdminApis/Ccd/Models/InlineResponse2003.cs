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
    /// InlineResponse2003 model
    /// </summary>
    [Preserve]
    [DataContract(Name = "inline_response_200_3")]
    internal class InlineResponse2003
    {
        /// <summary>
        /// Creates an instance of InlineResponse2003.
        /// </summary>
        /// <param name="complete">complete param</param>
        /// <param name="contentHash">The \&quot;content_hash\&quot; should be MD5sum hash value.</param>
        /// <param name="contentLink">contentLink param</param>
        /// <param name="contentSize">contentSize param</param>
        /// <param name="contentType">contentType param</param>
        /// <param name="currentVersionid">currentVersionid param</param>
        /// <param name="entryid">entryid param</param>
        /// <param name="labels">labels param</param>
        /// <param name="lastModified">lastModified param</param>
        /// <param name="lastModifiedBy">lastModifiedBy param</param>
        /// <param name="lastModifiedByName">lastModifiedByName param</param>
        /// <param name="link">link param</param>
        /// <param name="metadata">metadata param</param>
        /// <param name="path">path param</param>
        /// <param name="signedUrl">signedUrl param</param>
        /// <param name="updatedAt">updatedAt param</param>
        [Preserve]
        public InlineResponse2003(bool complete = default, string contentHash = default, string contentLink = default, int contentSize = default, string contentType = default, System.Guid currentVersionid = default, System.Guid entryid = default, List<string> labels = default, DateTime lastModified = default, string lastModifiedBy = default, string lastModifiedByName = default, string link = default, object metadata = default, string path = default, string signedUrl = default, DateTime updatedAt = default)
        {
            Complete = complete;
            ContentHash = contentHash;
            ContentLink = contentLink;
            ContentSize = contentSize;
            ContentType = contentType;
            CurrentVersionid = currentVersionid;
            Entryid = entryid;
            Labels = labels;
            LastModified = lastModified;
            LastModifiedBy = lastModifiedBy;
            LastModifiedByName = lastModifiedByName;
            Link = link;
            Metadata = (IDeserializable) JsonObject.GetNewJsonObjectResponse(metadata);
            Path = path;
            SignedUrl = signedUrl;
            UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Parameter complete of InlineResponse2003
        /// </summary>
        [Preserve]
        [DataMember(Name = "complete", EmitDefaultValue = true)]
        public bool Complete{ get; }

        /// <summary>
        /// The \&quot;content_hash\&quot; should be MD5sum hash value.
        /// </summary>
        [Preserve]
        [DataMember(Name = "content_hash", EmitDefaultValue = false)]
        public string ContentHash{ get; }

        /// <summary>
        /// Parameter content_link of InlineResponse2003
        /// </summary>
        [Preserve]
        [DataMember(Name = "content_link", EmitDefaultValue = false)]
        public string ContentLink{ get; }

        /// <summary>
        /// Parameter content_size of InlineResponse2003
        /// </summary>
        [Preserve]
        [DataMember(Name = "content_size", EmitDefaultValue = false)]
        public int ContentSize{ get; }

        /// <summary>
        /// Parameter content_type of InlineResponse2003
        /// </summary>
        [Preserve]
        [DataMember(Name = "content_type", EmitDefaultValue = false)]
        public string ContentType{ get; }

        /// <summary>
        /// Parameter current_versionid of InlineResponse2003
        /// </summary>
        [Preserve]
        [DataMember(Name = "current_versionid", EmitDefaultValue = false)]
        public System.Guid CurrentVersionid{ get; }

        /// <summary>
        /// Parameter entryid of InlineResponse2003
        /// </summary>
        [Preserve]
        [DataMember(Name = "entryid", EmitDefaultValue = false)]
        public System.Guid Entryid{ get; }

        /// <summary>
        /// Parameter labels of InlineResponse2003
        /// </summary>
        [Preserve]
        [DataMember(Name = "labels", EmitDefaultValue = false)]
        public List<string> Labels{ get; }

        /// <summary>
        /// Parameter last_modified of InlineResponse2003
        /// </summary>
        [Preserve]
        [DataMember(Name = "last_modified", EmitDefaultValue = false)]
        public DateTime LastModified{ get; }

        /// <summary>
        /// Parameter last_modified_by of InlineResponse2003
        /// </summary>
        [Preserve]
        [DataMember(Name = "last_modified_by", EmitDefaultValue = false)]
        public string LastModifiedBy{ get; }

        /// <summary>
        /// Parameter last_modified_by_name of InlineResponse2003
        /// </summary>
        [Preserve]
        [DataMember(Name = "last_modified_by_name", EmitDefaultValue = false)]
        public string LastModifiedByName{ get; }

        /// <summary>
        /// Parameter link of InlineResponse2003
        /// </summary>
        [Preserve]
        [DataMember(Name = "link", EmitDefaultValue = false)]
        public string Link{ get; }

        /// <summary>
        /// Parameter metadata of InlineResponse2003
        /// </summary>
        [Preserve][JsonConverter(typeof(JsonObjectConverter))]
        [DataMember(Name = "metadata", EmitDefaultValue = false)]
        public IDeserializable Metadata{ get; }

        /// <summary>
        /// Parameter path of InlineResponse2003
        /// </summary>
        [Preserve]
        [DataMember(Name = "path", EmitDefaultValue = false)]
        public string Path{ get; }

        /// <summary>
        /// Parameter signed_url of InlineResponse2003
        /// </summary>
        [Preserve]
        [DataMember(Name = "signed_url", EmitDefaultValue = false)]
        public string SignedUrl{ get; }

        /// <summary>
        /// Parameter updated_at of InlineResponse2003
        /// </summary>
        [Preserve]
        [DataMember(Name = "updated_at", EmitDefaultValue = false)]
        public DateTime UpdatedAt{ get; }

        /// <summary>
        /// Formats a InlineResponse2003 into a string of key-value pairs for use as a path parameter.
        /// </summary>
        /// <returns>Returns a string representation of the key-value pairs.</returns>
        internal string SerializeAsPathParam()
        {
            var serializedModel = "";

            serializedModel += "complete," + Complete.ToString() + ",";
            if (ContentHash != null)
            {
                serializedModel += "content_hash," + ContentHash + ",";
            }
            if (ContentLink != null)
            {
                serializedModel += "content_link," + ContentLink + ",";
            }
            serializedModel += "content_size," + ContentSize.ToString() + ",";
            if (ContentType != null)
            {
                serializedModel += "content_type," + ContentType + ",";
            }
            if (CurrentVersionid != null)
            {
                serializedModel += "current_versionid," + CurrentVersionid + ",";
            }
            if (Entryid != null)
            {
                serializedModel += "entryid," + Entryid + ",";
            }
            if (Labels != null)
            {
                serializedModel += "labels," + Labels.ToString() + ",";
            }
            if (LastModified != null)
            {
                serializedModel += "last_modified," + LastModified.ToString() + ",";
            }
            if (LastModifiedBy != null)
            {
                serializedModel += "last_modified_by," + LastModifiedBy + ",";
            }
            if (LastModifiedByName != null)
            {
                serializedModel += "last_modified_by_name," + LastModifiedByName + ",";
            }
            if (Link != null)
            {
                serializedModel += "link," + Link + ",";
            }
            if (Metadata != null)
            {
                serializedModel += "metadata," + Metadata.ToString() + ",";
            }
            if (Path != null)
            {
                serializedModel += "path," + Path + ",";
            }
            if (SignedUrl != null)
            {
                serializedModel += "signed_url," + SignedUrl + ",";
            }
            if (UpdatedAt != null)
            {
                serializedModel += "updated_at," + UpdatedAt.ToString();
            }
            return serializedModel;
        }

        /// <summary>
        /// Returns a InlineResponse2003 as a dictionary of key-value pairs for use as a query parameter.
        /// </summary>
        /// <returns>Returns a dictionary of string key-value pairs.</returns>
        internal Dictionary<string, string> GetAsQueryParam()
        {
            var dictionary = new Dictionary<string, string>();

            var completeStringValue = Complete.ToString();
            dictionary.Add("complete", completeStringValue);

            if (ContentHash != null)
            {
                var content_hashStringValue = ContentHash.ToString();
                dictionary.Add("content_hash", content_hashStringValue);
            }

            if (ContentLink != null)
            {
                var content_linkStringValue = ContentLink.ToString();
                dictionary.Add("content_link", content_linkStringValue);
            }

            var content_sizeStringValue = ContentSize.ToString();
            dictionary.Add("content_size", content_sizeStringValue);

            if (ContentType != null)
            {
                var content_typeStringValue = ContentType.ToString();
                dictionary.Add("content_type", content_typeStringValue);
            }

            if (CurrentVersionid != null)
            {
                var current_versionidStringValue = CurrentVersionid.ToString();
                dictionary.Add("current_versionid", current_versionidStringValue);
            }

            if (Entryid != null)
            {
                var entryidStringValue = Entryid.ToString();
                dictionary.Add("entryid", entryidStringValue);
            }

            if (Labels != null)
            {
                var labelsStringValue = Labels.ToString();
                dictionary.Add("labels", labelsStringValue);
            }

            if (LastModified != null)
            {
                var last_modifiedStringValue = LastModified.ToString();
                dictionary.Add("last_modified", last_modifiedStringValue);
            }

            if (LastModifiedBy != null)
            {
                var last_modified_byStringValue = LastModifiedBy.ToString();
                dictionary.Add("last_modified_by", last_modified_byStringValue);
            }

            if (LastModifiedByName != null)
            {
                var last_modified_by_nameStringValue = LastModifiedByName.ToString();
                dictionary.Add("last_modified_by_name", last_modified_by_nameStringValue);
            }

            if (Link != null)
            {
                var linkStringValue = Link.ToString();
                dictionary.Add("link", linkStringValue);
            }

            if (Path != null)
            {
                var pathStringValue = Path.ToString();
                dictionary.Add("path", pathStringValue);
            }

            if (SignedUrl != null)
            {
                var signed_urlStringValue = SignedUrl.ToString();
                dictionary.Add("signed_url", signed_urlStringValue);
            }

            if (UpdatedAt != null)
            {
                var updated_atStringValue = UpdatedAt.ToString();
                dictionary.Add("updated_at", updated_atStringValue);
            }

            return dictionary;
        }
    }
}
