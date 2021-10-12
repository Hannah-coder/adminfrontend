using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AdminFrontEnd.Models
{

    public record Page
    {
        public int Id { get; init; }
        public string Page_Url { get; init; }
        [JsonIgnore]
        public ICollection<PageSession> PageSessions { get; set; }
    }
}