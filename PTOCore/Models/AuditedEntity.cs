using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PTOCore.Models
{
    public class AuditedEntity : IAuditedEntity
    {
        [JsonProperty("createdDate")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("lastModifiedDate")]
        public DateTime LastModifiedAt { get; set; }

        [JsonProperty("lastModifiedBy")]
        public string LastModifiedBy { get; set; }
    }
}
