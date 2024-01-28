using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Appricot.Abp.FileManagementModule.EntityFrameworkCore;

[ConnectionStringName(FileManagementModuleDbProperties.ConnectionStringName)]
public class FileManagementModuleDbContext : AbpDbContext<FileManagementModuleDbContext>, IFileManagementModuleDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * public DbSet<Question> Questions { get; set; }
     */

    public FileManagementModuleDbContext(DbContextOptions<FileManagementModuleDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ConfigureFileManagementModule();
    }
}
