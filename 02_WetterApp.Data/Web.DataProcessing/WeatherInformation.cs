using _02_WetterApp.Data.APIRequests;
using _02_WetterApp.Data.Web.DataProcessing.SupportForeCastProcessing;
using System.Text.Json.Serialization;



namespace _02_WetterApp.Data.Web.DataProcessing
{
    public class WeatherInformation
    {
        [JsonPropertyName("location")]
        public Location? Location { get; set; }

        [JsonPropertyName("current")]
        public Current? Current { get; set; }

        [JsonPropertyName("forecast")]
        public ForeCast? ForeCast { get; set; }
    }
}
