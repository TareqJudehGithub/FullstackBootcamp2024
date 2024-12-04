// builder accesses the configuration, the services, and the environment variables.
var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();
// app is a variable that refers to an instance of the web application object.
// We can configure the middleware of this configuration.


app.MapGet("/", () => "Hello World! This is my first ASP.NET Core web app!");
// When the url is "/" the response should be "Hello World!".

// Starts the server
app.Run();

