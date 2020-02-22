using System.Collections.Generic;

namespace SurveySlide
{
    public class Survey
    {
        public string Id { get; set; }
        public IEnumerable<Slide> Slides { get; set; }
    }
}