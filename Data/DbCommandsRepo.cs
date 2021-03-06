using System.Collections.Generic;
using System.Linq;
using CommandsRepo.Models;

namespace CommandsRepo.Data
{
    public class DbCommanderRepo : ICommandsRepo
    {
        private CommandsContext _context;

        public DbCommanderRepo(CommandsContext context)
        {
            _context = context;
        }

        public IEnumerable<Command> GetAllCommands()
        {
            return _context.Commands.ToList();
        }

        public Command GetCommandById(int id)
        {
            return _context.Commands.FirstOrDefault(p => p.Id == id);
        }
    }
}