using CommandsRepo.Models;
using Microsoft.EntityFrameworkCore;

namespace CommandsRepo.Data
{
    public class CommandsContext : DbContext
    {
        public CommandsContext(DbContextOptions<CommandsContext> opt) : base(opt)
        {}

        public DbSet<Command> Commands { get; set; }
    }
}