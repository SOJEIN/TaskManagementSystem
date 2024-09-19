using Microsoft.AspNetCore.Mvc;
using TaskManagementSystem.Core.Entities;
using TaskManagementSystem.Core.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TaskManagementSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        private readonly ITaskRepository _taskRepository;

        public TaskController(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserTask>>> GetTasks()
        {
            var tasks = await _taskRepository.GetAllTasksAsync();
            return Ok(tasks);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<UserTask>> GetTask(int id)
        {
            var task = await _taskRepository.GetTaskByIdAsync(id);
            if (task == null)
            {
                return NotFound();
            }
            return Ok(task);
        }

        [HttpPost]
        public async Task<ActionResult<UserTask>> CreateTask(UserTask task)
        {
            await _taskRepository.AddTaskAsync(task); // Cambiado a AddTaskAsync
            return CreatedAtAction(nameof(GetTask), new { id = task.Id }, task);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateTask(int id, UserTask task)
        {
            if (id != task.Id)
            {
                return BadRequest();
            }

            await _taskRepository.UpdateTaskAsync(task); // Cambiado a UpdateTaskAsync
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTask(int id)
        {
            await _taskRepository.DeleteTaskAsync(id); // Cambiado a DeleteTaskAsync
            return NoContent();
        }
    }
}
