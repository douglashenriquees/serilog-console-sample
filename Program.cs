using Serilog;

Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Debug()
    .WriteTo.Console()
    .WriteTo.File("logs/myapp.txt", rollingInterval: RollingInterval.Day)
    .CreateLogger();

Log.Information("Hello, world!");

short x = 10, y = 0;

try
{
    Log.Debug("Dividing {A} by {B}", x, y);
    Console.WriteLine(x / y);
}
catch (Exception ex)
{
    Log.Error(ex, "Something went wrong");
}
finally
{
    Log.CloseAndFlush();
}
