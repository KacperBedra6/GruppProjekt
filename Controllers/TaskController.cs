using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grupparbete.Model;

using Grupparbete;
using Microsoft.AspNetCore.Mvc;
using Task = Grupparbete.Model.Task;

namespace Grupparbete.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TasksController : ControllerBase
    {
        public TasksController(JsonFileTaskService TaskService) => this.TaskService = TaskService;

        public JsonFileTaskService TaskService { get; }

        [HttpGet]
        public IEnumerable<Task> Get() => TaskService.GetTasks();




    }

    /*
    [HttpPatch]
    public ActionResult Patch([FromBody] PriorityRequest request)
    {
        if (request?.TaskId == null)
            return BadRequest();

        TaskService.AddPriority(request.TaskId, request.Priority);

        return Ok();
    }

    public class PriorityRequest
    {
        public int? TaskId { get; set; }
        public int Priority { get; set; }
    }
    */
}
