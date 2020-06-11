# BlazorWebAssembly3

Blazor WebAssembly application in .NET Core 3.1

Can only be compiled if you have the latest SDK installed and/or in latest version of Visual Studio 2019 v16.6

After opening the solution, run the BlazorWebAssembly3.Startup project first to generate the SQLite database

Change the Solution startup project properties to run BlazorWebAssembly3.Api and BlazorWebAssembly3.Web as the web project communicates with the Api project - both running in IIS Express.
