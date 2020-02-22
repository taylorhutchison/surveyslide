using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace SurveySlide {
    public class SurveysController: ControllerBase {

        private IConfiguration _configuration;
        public SurveysController(IConfiguration configuration) {
            _configuration = configuration;
        }

        [HttpGet("surveys/survey.json")]
        public ActionResult<Survey> Get() {

            var survey = new Survey {
                Id = new Guid().ToString(),
                Slides = new List<Slide> {
                    new Slide {
                        Id = new Guid().ToString(),
                        Title = "Rank your topic",
                        DisplayType = DisplayType.Rank,
                        Options = new List<Option> {
                            new Option {
                                Id = new Guid().ToString(),
                                Title = "Option A"
                            },
                            new Option {
                                Id = new Guid().ToString(),
                                Title = "Option B"
                            }   
                        }
                    }
                }
            };

            return Ok(survey);
        }
    }
}