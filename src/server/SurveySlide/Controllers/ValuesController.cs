using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace SurveySlide {

    public class ValuesController: ControllerBase {
        

        [HttpGet("api/values")]
        public ActionResult<List<int>> Get() {
            var values = new List<int> { 1, 2, 3};
            return Ok(values);
        }
    }
}