using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{    
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAllCommands() => new List<Command> {
                new Command { Id = 1, HowTo = "install packges on linux", Line = "some explanation", Platform = "Linux" },
                new Command { Id = 2, HowTo = "uninstall packges on linux", Line = "some explanation", Platform = "Linux" },
                new Command { Id = 3, HowTo = "remove packges on linux", Line = "some explanation", Platform = "Linux" },
            };

        public Command GetCommandById(int id) => new Command { Id = 1, HowTo = "install packges on linux", Line = "some explanation", Platform = "Linux" };
    }
}