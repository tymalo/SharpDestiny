using System.Runtime.Serialization;
using Newtonsoft.Json.Linq;

namespace SharpDestiny.Destiny.Model
{
    [DataContract]
    public class Bucket
    {
        [DataMember(Name = "bucketHash")]
        public string BucketHash { get; set; }

        [DataMember(Name = "bucketName")]
        public string BucketName { get; set; }

        [DataMember(Name = "bucketDescription")]
        public string BucketDescription { get; set; }

        [DataMember(Name = "scope")]
        public int Scope { get; set; }

        [DataMember(Name = "category")]
        public int Category { get; set; }

        [DataMember(Name = "bucketOrder")]
        public int BucketOrder { get; set; }

        [DataMember(Name = "bucketIdentifier")]
        public string BucketIdentifier { get; set; }

        [DataMember(Name = "itemCount")]
        public int ItemCount { get; set; }

        [DataMember(Name = "location")]
        public int Location { get; set; }

        [DataMember(Name = "hasTransferDestination")]
        public bool HasTransferDestination { get; set; }

        public Bucket(JObject j)
        {
            BucketHash = j["bucketHash"] != null ? j["bucketHash"].Value<string>() : null;
            BucketName = j["bucketName"] != null ? j["bucketName"].Value<string>() : null;
            BucketDescription = j["bucketDescription"] != null ? j["bucketDescription"].Value<string>() : null;
            Scope = j["scope"].Value<int>();
            Category = j["category"].Value<int>();
            BucketOrder = j["bucketOrder"].Value<int>();
            BucketIdentifier = j["bucketIdentifier"] != null ? j["bucketIdentifier"].Value<string>() : null;
            ItemCount = j["itemCount"].Value<int>();
            Location = j["location"].Value<int>();
            HasTransferDestination = j["hasTransferDestination"].Value<bool>();
        }
    }
}