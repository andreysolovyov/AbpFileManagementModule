using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Appricot.Abp.FileManagementModule.EntityFrameworkCore;

public class FileManagementModuleHttpApiHostMigrationsDbContext : AbpDbContext<FileManagementModuleHttpApiHostMigrationsDbContext>
{
    public FileManagementModuleHttpApiHostMigrationsDbContext(DbContextOptions<FileManagementModuleHttpApiHostMigrationsDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ConfigureFileManagementModule();
    }
}
