using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace SurveySlide {
    public class SurveysController: ControllerBase {

        private IConfiguration _configuration;
        public SurveysController(IConfiguration configuration) {
            _configuration = configuration;
        }

        [HttpGet("surveys")]
        public async Task<ActionResult<IEnumerable<Survey>>> Get() {

            var repo = new SurveySlideDB<Survey>(_configuration);

            var items = await repo.GetItemsAsync(item => true);

            return Ok(items);
        }

        [HttpGet("surveys/{id}")]
        public async Task<ActionResult<IEnumerable<Survey>>> Get(string id) {

            var repo = new SurveySlideDB<Survey>(_configuration);

            var items = await repo.GetItemsAsync(item => item.Id == id);

            return Ok(items);
        }

    }
}