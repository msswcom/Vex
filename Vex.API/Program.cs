using Vex.Database;
using Vex.Database.Connections;
using Vex.Orchestrator;
using Vex.Sms;
using Vex.Sms.Providers;

var builder = WebApplication.CreateBuilder(args);

var configuration = builder.Configuration;
var environment = builder.Environment;
var services = builder.Services;

MessageBirdAPI.Key = configuration["Vex:MessageBirdAPI:Key"];
MessageBirdAPI.Telephone = configuration["Vex:MessageBirdAPI:Telephone"];

VexDatabase.Connection = configuration.GetConnectionString(VexDatabase.Title)
    ?.Replace("%CONTENTROOTPATH%", environment.ContentRootPath)
    .Replace("\\Vex.API", null);

services.AddControllers();
services.AddOpenApi();

services.AddDatabase();
services.AddOrchestrator();
services.AddSms();

var application = builder.Build();

if (application.Environment.IsDevelopment())
{
    application.MapOpenApi();

    application.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/openapi/v1.json", "v1");
    });
}

application.UseHttpsRedirection();

application.UseAuthorization();

application.MapControllers();

application.Run();
