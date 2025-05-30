namespace DevExpert.Marketplace.Core.Configurations;

public class Settings
{
    public required string AppPath { get; set; }
    public required string RootPath { get; set; }
    public required string ProductImageDirectoryPath { get; set; }
    
    public static Settings? Instance { get; private set; }

    public static void Initialize(Settings? settings)
    {
        Instance = settings;
    }
}