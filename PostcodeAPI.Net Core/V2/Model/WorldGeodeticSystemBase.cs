﻿using Newtonsoft.Json;

namespace PostcodeAPI.V2.Model
{
    public abstract class WorldGeodeticSystemBase
    {
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("crs")]
        public CRS ReferenceSystem { get; set; }
    }
}