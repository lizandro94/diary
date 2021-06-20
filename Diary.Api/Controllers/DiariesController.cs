using Diary.Application.Features.Diaries.Queries.GetDiariesList;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Diary.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiariesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public DiariesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        //[Authorize]
        [HttpGet("", Name = "GetAllDiaries")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<DiaryListVm>>> GetDiaries()
        {
            var dtos = await _mediator.Send(new GetDiaryListQuery() { UserId = Guid.NewGuid() });
            return Ok(dtos);
        }
    }
}
