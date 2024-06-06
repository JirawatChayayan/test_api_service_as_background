# Create Windows Service using BackgroundService

Credit: [Microsoft Documentation](https://learn.microsoft.com/en-us/dotnet/core/extensions/windows-service)

## Steps to Create a Windows Service

1. Add the necessary package to your project:
    ```sh
    dotnet add package Microsoft.Extensions.Hosting.WindowsServices
    ```

2. Modify your `Program.cs` file to include the Windows Service setup:

    ```csharp
    // Add this code under: var builder = WebApplication.CreateBuilder(args);
    builder.Services.AddWindowsService(options =>
    {
        options.ServiceName = "Test web api background service";
    });
    ```

3. In publish function setup following this image
        ![image](https://github.com/JirawatChayayan/test_api_service_as_background/assets/51415869/9a6d4021-8ebd-4aa9-bd40-c053830a250b)


4. After published pls following below command for install service
        ```sh
        sc.exe create ".NET Joke Service" binpath= "C:\Path\To\App.WindowsService.exe"
        ```
        Optional for add the description 
        ```sh
        sc.exe description ".NET Joke Service" "Note Something"
        ```
