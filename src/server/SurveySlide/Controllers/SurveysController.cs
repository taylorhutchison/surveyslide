using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace SurveySlide {
    public class SurveysController: ControllerBase {

        private IConfiguration _configuration;
        public SurveysController(IConfiguration configuration) {
            _configuration = configuration;
        }

        [HttpGet("surveys/survey.json")]
        public ActionResult<string> Get() {
            return Ok();
        }
    }
}