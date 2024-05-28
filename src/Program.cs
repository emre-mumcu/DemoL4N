// dotnet add package Microsoft.AspNetCore.Mvc.Razor.RuntimeCompilation
// dotnet add package log4net
// add log4net.config file
// add Log4netExtensions class
// log4net xsd schema: https://csharptest.net/downloads/schema/log4net.xsd

using src.AppLib;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddLog4net();

builder.Services.AddMvc().AddRazorRuntimeCompilation();

var app = builder.Build();

app.MapDefaultControllerRoute();

app.Run();
