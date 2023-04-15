using Serilog;

Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Debug()
    .WriteTo.Console()
    .WriteTo.File("logs/myapp.txt", rollingInterval: RollingInterval.Day)
    .WriteTo.Seq("http://localhost:5341")
    .CreateLogger();

Log.Information("Hello, world!");

// use {@} to show the objects in json format
var sensorInput = new { Latitude = 25, Longitude = 134, Point = new { Value = 0.344432002 } };
Log.Information("Processing {@SensorInput}", sensorInput);
Log.Information("Procesisng {SensorInput}", sensorInput);

// use {$} to show the types of objects
var unknown = new[] { 1, 2, 3 };
Log.Information("Received {$Type}", unknown);

short x = 10, y = 0;

try
{
    // use {} to show the primitive type values
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