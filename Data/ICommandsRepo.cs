using System.Collections.Generic;
using CommandsRepo.Models;

namespace CommandsRepo.Data
{
    public interface ICommandsRepo
    {
        IEnumerable<Command> GetAllCommands();
        Command GetCommandById(int id);
    }
}