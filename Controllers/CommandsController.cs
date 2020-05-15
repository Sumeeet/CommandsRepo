using System.Collections.Generic;
using CommandsRepo.Data;
using CommandsRepo.Models;
using Microsoft.AspNetCore.Mvc;

namespace CommandsRepo.Controllers
{
    [Route("api/commands")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        private readonly ICommandsRepo _repository;
        
        public CommandsController(ICommandsRepo repository) {
            _repository = repository;
        }

        // Get api/commands
        [HttpGet]
        public ActionResult<IEnumerable<Command>> GetAllCommands()
        {
            var commandItems = _repository.GetAllCommands();
            return Ok(commandItems);
        }

        // Get api/commands/{id}
        [HttpGet("{id}")]
        public ActionResult <Command> GetCommandById(int id)
        {
            var commandItem = _repository.GetCommandById(id);
            return Ok(commandItem);
        }
     }
}