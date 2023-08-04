# ASP.NET Core/C#: Starter API Code Sample

This C# code sample demonstrates how to build an API server using ASP.NET Core that is secure by design.

Visit the ["ASP.NET Core/C# Code Samples: API Security in Action"](https://developer.auth0.com/resources/code-samples/api/aspnet-core) section of the ["Auth0 Developer Resources"](https://developer.auth0.com/resources) to explore how you can secure ASP.NET Core applications written in C# by implementing endpoint protection and authorization with Auth0.

## Why Use Auth0?

Auth0 is a flexible drop-in solution to add authentication and authorization services to your applications. Your team and organization can avoid the cost, time, and risk that come with building your own solution to authenticate and authorize users. We offer tons of guidance and SDKs for you to get started and [integrate Auth0 into your stack easily](https://developer.auth0.com/resources/code-samples/full-stack).

## Set Up and Run the ASP.NET Core Project

Create a `.env` file under the root project directory and populate it with the following environment variables:

```bash
PORT=6060
CLIENT_ORIGIN_URL=http://localhost:4040
```

Run the project:

```
dotnet run
```
