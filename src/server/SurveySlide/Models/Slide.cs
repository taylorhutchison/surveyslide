using System.Collections.Generic;

namespace SurveySlide
{

    public class Slide
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Type { get; set; }
        public IEnumerable<Option> Options { get; set; }

    }

}