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
    /// CcdRelease model
    /// </summary>
    [Preserve]
    [DataContract(Name = "ccd.release")]
    internal class CcdRelease
    {
        /// <summary>
        /// Creates an instance of CcdRelease.
        /// </summary>
        /// <param name="badges">badges param</param>
        /// <param name="changes">changes param</param>
        /// <param name="contentHash">contentHash param</param>
        /// <param name="contentSize">contentSize param</param>
        /// <param name="created">created param</param>
        /// <param name="createdBy">createdBy param</param>
        /// <param name="createdByName">createdByName param</param>
        /// <param name="entriesLink">entriesLink param</param>
        /// <param name="metadata">metadata param</param>
        /// <param name="notes">notes param</param>
        /// <param name="promotedFromBucket">promotedFromBucket param</param>
        /// <param name="promotedFromRelease">promotedFromRelease param</param>
        /// <param name="releaseid">releaseid param</param>
        /// <param name="releasenum">releasenum param</param>
        [Preserve]
        public CcdRelease(List<GetBucket200ResponseLastReleaseBadgesInner> badges = default, GetBucket200ResponseChanges changes = default, string contentHash = default, long contentSize = default, DateTime created = default, string createdBy = default, string createdByName = default, string entriesLink = default, object metadata = default, string notes = default, System.Guid promotedFromBucket = default, System.Guid promotedFromRelease = default, System.Guid releaseid = default, long releasenum = default)
        {
            Badges = badges;
            Changes = changes;
            ContentHash = contentHash;
            ContentSize = contentSize;
            Created = created;
            CreatedBy = createdBy;
            CreatedByName = createdByName;
            EntriesLink = entriesLink;
            Metadata = (IDeserializable) JsonObject.GetNewJsonObjectResponse(metadata);
            Notes = notes;
            PromotedFromBucket = promotedFromBucket;
            PromotedFromRelease = promotedFromRelease;
            Releaseid = releaseid;
            Releasenum = releasenum;
        }

        /// <summary>
        /// Parameter badges of CcdRelease
        /// </summary>
        [Preserve]
        [DataMember(Name = "badges", EmitDefaultValue = false)]
        public List<GetBucket200ResponseLastReleaseBadgesInner> Badges{ get; }
        
        /// <summary>
        /// Parameter changes of CcdRelease
        /// </summary>
        [Preserve]
        [DataMember(Name = "changes", EmitDefaultValue = false)]
        public GetBucket200ResponseChanges Changes{ get; }
        
        /// <summary>
        /// Parameter content_hash of CcdRelease
        /// </summary>
        [Preserve]
        [DataMember(Name = "content_hash", EmitDefaultValue = false)]
        public string ContentHash{ get; }
        
        /// <summary>
        /// Parameter content_size of CcdRelease
        /// </summary>
        [Preserve]
        [DataMember(Name = "content_size", EmitDefaultValue = false)]
        public long ContentSize{ get; }
        
        /// <summary>
        /// Parameter created of CcdRelease
        /// </summary>
        [Preserve]
        [DataMember(Name = "created", EmitDefaultValue = false)]
        public DateTime Created{ get; }
        
        /// <summary>
        /// Parameter created_by of CcdRelease
        /// </summary>
        [Preserve]
        [DataMember(Name = "created_by", EmitDefaultValue = false)]
        public string CreatedBy{ get; }
        
        /// <summary>
        /// Parameter created_by_name of CcdRelease
        /// </summary>
        [Preserve]
        [DataMember(Name = "created_by_name", EmitDefaultValue = false)]
        public string CreatedByName{ get; }
        
        /// <summary>
        /// Parameter entries_link of CcdRelease
        /// </summary>
        [Preserve]
        [DataMember(Name = "entries_link", EmitDefaultValue = false)]
        public string EntriesLink{ get; }
        
        /// <summary>
        /// Parameter metadata of CcdRelease
        /// </summary>
        [Preserve][JsonConverter(typeof(JsonObjectConverter))]
        [DataMember(Name = "metadata", EmitDefaultValue = false)]
        public IDeserializable Metadata{ get; }
        
        /// <summary>
        /// Parameter notes of CcdRelease
        /// </summary>
        [Preserve]
        [DataMember(Name = "notes", EmitDefaultValue = false)]
        public string Notes{ get; }
        
        /// <summary>
        /// Parameter promoted_from_bucket of CcdRelease
        /// </summary>
        [Preserve]
        [DataMember(Name = "promoted_from_bucket", EmitDefaultValue = false)]
        public System.Guid PromotedFromBucket{ get; }
        
        /// <summary>
        /// Parameter promoted_from_release of CcdRelease
        /// </summary>
        [Preserve]
        [DataMember(Name = "promoted_from_release", EmitDefaultValue = false)]
        public System.Guid PromotedFromRelease{ get; }
        
        /// <summary>
        /// Parameter releaseid of CcdRelease
        /// </summary>
        [Preserve]
        [DataMember(Name = "releaseid", EmitDefaultValue = false)]
        public System.Guid Releaseid{ get; }
        
        /// <summary>
        /// Parameter releasenum of CcdRelease
        /// </summary>
        [Preserve]
        [DataMember(Name = "releasenum", EmitDefaultValue = false)]
        public long Releasenum{ get; }
    
        /// <summary>
        /// Formats a CcdRelease into a string of key-value pairs for use as a path parameter.
        /// </summary>
        /// <returns>Returns a string representation of the key-value pairs.</returns>
        internal string SerializeAsPathParam()
        {
            var serializedModel = "";

            if (Badges != null)
            {
                serializedModel += "badges," + Badges.ToString() + ",";
            }
            if (Changes != null)
            {
                serializedModel += "changes," + Changes.ToString() + ",";
            }
            if (ContentHash != null)
            {
                serializedModel += "content_hash," + ContentHash + ",";
            }
            serializedModel += "content_size," + ContentSize.ToString() + ",";
            if (Created != null)
            {
                serializedModel += "created," + Created.ToString() + ",";
            }
            if (CreatedBy != null)
            {
                serializedModel += "created_by," + CreatedBy + ",";
            }
            if (CreatedByName != null)
            {
                serializedModel += "created_by_name," + CreatedByName + ",";
            }
            if (EntriesLink != null)
            {
                serializedModel += "entries_link," + EntriesLink + ",";
            }
            if (Metadata != null)
            {
                serializedModel += "metadata," + Metadata.ToString() + ",";
            }
            if (Notes != null)
            {
                serializedModel += "notes," + Notes + ",";
            }
            if (PromotedFromBucket != null)
            {
                serializedModel += "promoted_from_bucket," + PromotedFromBucket + ",";
            }
            if (PromotedFromRelease != null)
            {
                serializedModel += "promoted_from_release," + PromotedFromRelease + ",";
            }
            if (Releaseid != null)
            {
                serializedModel += "releaseid," + Releaseid + ",";
            }
            serializedModel += "releasenum," + Releasenum.ToString();
            return serializedModel;
        }

        /// <summary>
        /// Returns a CcdRelease as a dictionary of key-value pairs for use as a query parameter.
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
            
            if (Created != null)
            {
                var createdStringValue = Created.ToString();
                dictionary.Add("created", createdStringValue);
            }
            
            if (CreatedBy != null)
            {
                var created_byStringValue = CreatedBy.ToString();
                dictionary.Add("created_by", created_byStringValue);
            }
            
            if (CreatedByName != null)
            {
                var created_by_nameStringValue = CreatedByName.ToString();
                dictionary.Add("created_by_name", created_by_nameStringValue);
            }
            
            if (EntriesLink != null)
            {
                var entries_linkStringValue = EntriesLink.ToString();
                dictionary.Add("entries_link", entries_linkStringValue);
            }
            
            if (Notes != null)
            {
                var notesStringValue = Notes.ToString();
                dictionary.Add("notes", notesStringValue);
            }
            
            if (PromotedFromBucket != null)
            {
                var promoted_from_bucketStringValue = PromotedFromBucket.ToString();
                dictionary.Add("promoted_from_bucket", promoted_from_bucketStringValue);
            }
            
            if (PromotedFromRelease != null)
            {
                var promoted_from_releaseStringValue = PromotedFromRelease.ToString();
                dictionary.Add("promoted_from_release", promoted_from_releaseStringValue);
            }
            
            if (Releaseid != null)
            {
                var releaseidStringValue = Releaseid.ToString();
                dictionary.Add("releaseid", releaseidStringValue);
            }
            
            var releasenumStringValue = Releasenum.ToString();
            dictionary.Add("releasenum", releasenumStringValue);
            
            return dictionary;
        }
    }
}
