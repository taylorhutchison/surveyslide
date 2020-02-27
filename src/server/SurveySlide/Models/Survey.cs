using System.Collections.Generic;
using Newtonsoft.Json;

namespace SurveySlide
{
    public class Survey
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        [JsonProperty(PropertyName = "userid")]
        public string UserId { get; set; }

        public string Title { get; set; }
        public IEnumerable<Slide> Slides { get; set; }
    }
}