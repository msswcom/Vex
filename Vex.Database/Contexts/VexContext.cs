using Microsoft.EntityFrameworkCore;
using Vex.Database.Connections;
using Vex.Models.Database;
namespace Vex.Database.Contexts;

internal class VexContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlServer(VexDatabase.Connection);
    }

    public DbSet<Credit> Credits { get; set; }
    public DbSet<Message> Messages { get; set; }
    public DbSet<Template> Templates { get; set; }
}
