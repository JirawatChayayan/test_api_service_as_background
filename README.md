# Create Windows Service using BackgroundService

credit :> https://learn.microsoft.com/en-us/dotnet/core/extensions/windows-service

1. dotnet add package Microsoft.Extensions.Hosting.WindowsServices

2. Rewrite the Program.cs file

  //Add this code under > var builder = WebApplication.CreateBuilder(args);

  builder.Services.AddWindowsService(options =>
  {
      options.ServiceName = "Test web api background service";
  });

3.
