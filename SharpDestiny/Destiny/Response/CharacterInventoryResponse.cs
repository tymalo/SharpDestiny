﻿using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json.Linq;
using SharpCommon.Extension;
using SharpDestiny.Destiny.Model;

namespace SharpDestiny.Destiny.Response
{
    [DataContract]
    public class CharacterInventoryResponse : Common.Response
    {
        [DataMember]
        public ICollection<Item> Items;

        [DataMember]
        public ICollection<Bucket> Buckets;

        [DataMember]
        public ICollection<Stat> Stats;

        public CharacterInventoryResponse(JObject j) : base(j)
        {
            Items = new List<Item>();
            Buckets = new List<Bucket>();
            Stats = new List<Stat>();

            if (j["Response"] != null)
            {
                j["Response"]["definitions"]["items"].ForEach(x =>
                {
                    var jObj = x.First.Value<JObject>();
                    Items.Add(new Item(jObj));
                });

                j["Response"]["definitions"]["buckets"].ForEach(x =>
                {
                    var jObj = x.First.Value<JObject>();
                    Buckets.Add(new Bucket(jObj));
                });

                j["Response"]["definitions"]["stats"].ForEach(x =>
                {
                    var jObj = x.First.Value<JObject>();
                    Stats.Add(new Stat(jObj));
                });
            }
        }
    }
}