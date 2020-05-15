using CommandsRepo.Models;
using Microsoft.EntityFrameworkCore;

namespace CommandsRepo.Data
{
    public class CommanderContext : DbContext
    {
        public CommanderContext(DbContextOptions<CommanderContext> opt) : base(opt)
        {}

        public DbSet<Command> Commands { get; set; }
    }
}