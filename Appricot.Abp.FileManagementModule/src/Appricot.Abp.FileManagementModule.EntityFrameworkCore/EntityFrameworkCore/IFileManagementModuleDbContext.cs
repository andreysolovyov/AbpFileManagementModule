using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Appricot.Abp.FileManagementModule.EntityFrameworkCore;

[ConnectionStringName(FileManagementModuleDbProperties.ConnectionStringName)]
public interface IFileManagementModuleDbContext : IEfCoreDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * DbSet<Question> Questions { get; }
     */
}
