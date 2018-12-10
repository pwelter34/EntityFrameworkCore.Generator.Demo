using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Tracker.Data;
using Tracker.Domain.Models;

namespace Tracker.Controllers
{
    [Route("api/Task")]
    public class TaskController : EntityControllerBase<Data.Entities.Task, TaskReadModel, TaskCreateModel, TaskUpdateModel>
    {
        public TaskController(TrackerContext dataContext, IMapper mapper) : base(dataContext, mapper)
        {
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TaskReadModel>> Get(CancellationToken cancellationToken, Guid id)
        {
            var readModel = await ReadModel(id, cancellationToken);

            if (readModel == null)
                return NotFound();

            return readModel;
        }

        [HttpGet("")]
        public async Task<ActionResult<IReadOnlyList<TaskReadModel>>> List(CancellationToken cancellationToken)
        {
            var listResult = await QueryModel(null, cancellationToken);
            return Ok(listResult);
        }

        [HttpPost("")]
        public async Task<ActionResult<TaskReadModel>> Create(CancellationToken cancellationToken, TaskCreateModel createModel)
        {
            var readModel = await CreateModel(createModel, cancellationToken).ConfigureAwait(false);

            return readModel;
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<TaskReadModel>> Update(CancellationToken cancellationToken, Guid id, TaskUpdateModel updateModel)
        {
            var readModel = await UpdateModel(id, updateModel, cancellationToken).ConfigureAwait(false);
            if (readModel == null)
                return NotFound();

            return readModel;
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<TaskReadModel>> Delete(CancellationToken cancellationToken, Guid id)
        {
            var readModel = await DeleteModel(id, cancellationToken).ConfigureAwait(false);
            if (readModel == null)
                return NotFound();

            return readModel;
        }

    }
}
