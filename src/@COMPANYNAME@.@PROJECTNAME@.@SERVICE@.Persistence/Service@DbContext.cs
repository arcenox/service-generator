using _COMPANYNAME_._PROJECTNAME_._SERVICE_.Application.Interfaces;
using _COMPANYNAME_._PROJECTNAME_._SERVICE_.Common.Extensions;
using _COMPANYNAME_._PROJECTNAME_._SERVICE_.Domain.Entities.Base;
using _COMPANYNAME_._PROJECTNAME_._SERVICE_.Persistence.Configurations.Base;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;

namespace _COMPANYNAME_._PROJECTNAME_._SERVICE_.Persistence
{
    public class _SERVICE_DbContext : IdentityDbContext, I_SERVICE_DbContext
    {
        public _SERVICE_DbContext(DbContextOptions<_SERVICE_DbContext> options) : base(options) { }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            ChangeTracker.Entries()
                         .Where(x => typeof(IEntityTimeStamp).IsAssignableFrom(x.Entity.GetType()) && x.State == EntityState.Modified)
                         .Select(x => x.Entity)
                         .ForEach((x) => x.GetType().GetProperty(nameof(IEntityTimeStamp.UpdatedAt)).SetValue(x, DateTime.UtcNow));

            return base.SaveChangesAsync(cancellationToken);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Model.GetEntityTypes().ToList().ForEach(entityType =>
            {
                if (entityType.ClrType == typeof(BaseEntity<>) || entityType.ClrType == typeof(EntityTimeStamp))
                    modelBuilder.Entity<EntityTimeStamp>(x => x.UseBaseConfigurations());

                if (entityType.GetTableName() is string table && table.StartsWith("AspNet"))
                    entityType.SetTableName(table[6..]);
            });

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
