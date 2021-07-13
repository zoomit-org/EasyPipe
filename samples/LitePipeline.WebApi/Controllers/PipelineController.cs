using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LitePipeline.WebApi.Pipeline;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace LitePipeline.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PipelineController : ControllerBase
    {
        private readonly IPipeline<PipelineRequest, PipelineResponse> _pipeline;

        public PipelineController(IPipeline<PipelineRequest, PipelineResponse> pipeline)
        {
            _pipeline = pipeline;
        }

        [HttpGet]
        public Task<PipelineResponse> RunPipeline()
        {
            return _pipeline.RunAsync(new PipelineRequest());
        }
    }
}