using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Appricot.Abp.FileManagementModule.EntityFrameworkCore;

public class FileManagementModuleHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<FileManagementModuleHttpApiHostMigrationsDbContext>
{
    public FileManagementModuleHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<FileManagementModuleHttpApiHostMigrationsDbContext>()
            .UseNpgsql(configuration.GetConnectionString("FileManagementModule"));

        return new FileManagementModuleHttpApiHostMigrationsDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
