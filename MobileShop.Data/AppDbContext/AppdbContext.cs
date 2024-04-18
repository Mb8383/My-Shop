using Microsoft.EntityFrameworkCore;
using MobileShop.Domain.Model.User;
namespace MobileShop.Data.AppDbContext;

public class AppdbContext:DbContext
{
    #region cror    

    public AppdbContext(DbContextOptions<AppdbContext> options) : base(options)
    {

    }
    #endregion
    #region DBset
    public DbSet<User> Users { get; set; }
    #endregion
    #region Model Creating
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        var cascadeFKs = modelBuilder.Model.GetEntityTypes()
            .SelectMany(t => t.GetForeignKeys())
            .Where(fk => !fk.IsOwnership && fk.DeleteBehavior == DeleteBehavior.Cascade);

        foreach (var fk in cascadeFKs)
            fk.DeleteBehavior = DeleteBehavior.Restrict;


        base.OnModelCreating(modelBuilder);
    }
    #endregion

}
