using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_WetterApp.Data.Web.DataProcessing.SupportForeCastProcessing
{
    public class Condition
    {
        [JsonProperty("text")]
        public string? Text { get; set; }

        [JsonProperty("icon")]
        public string? Icon { get; set; }

        [JsonProperty("code")]
        public int Code { get; set; }
    }
}
