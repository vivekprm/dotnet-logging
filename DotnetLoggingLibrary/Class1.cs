namespace UtilityLibraries;

using Microsoft.Extensions.Configuration;
using Serilog;
using Serilog.Core;
using Serilog.Debugging;
public static class LoggingLibrary
{
    var configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile(path: "appsettings.json", optional: false, reloadOnChange: true).Build();

       var logger = new LoggerConfiguration().ReadFrom.Configuration(configuration).CreateLogger();
    public static void LogLine()
    {

       logger.Information("Hello, Serilog!");
    }
}
