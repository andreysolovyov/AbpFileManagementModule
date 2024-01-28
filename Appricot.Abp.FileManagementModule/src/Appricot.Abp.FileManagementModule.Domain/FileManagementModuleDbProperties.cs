namespace Appricot.Abp.FileManagementModule;

public static class FileManagementModuleDbProperties
{
    public static string DbTablePrefix { get; set; } = "FileManagementModule";

    public static string? DbSchema { get; set; } = null;

    public const string ConnectionStringName = "FileManagementModule";
}
