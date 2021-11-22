# .NET 6 Services (4 approaches)

## Purpose  
The purpose of this repository is to show different ways to approach a simple service using .NET 6. This includes using the new Minimal API or a Startup class with Controllers. There are async and non-async versions of both approaches. All of the services run on a pre-determined port on localhost.

*Note: I would use the async approach in production; however for demo and testing purposes, I often use the non-async versions for folks who are not comfortable with async yet.*  

## The Projects

The various approaches are all in separate folders, but have the same names and runtime ports.  

* **async-minimal**  
This project uses .NET 6 minimal API along with an asynchronous service.
* **async-startup**  
This project uses the Startup class along with separate controllers. The controllers are asynchronous.
* **minimal-api**  
This project uses .NET 6 minimal API but does not use asynchronous calls. The data is hard-coded, so this is not an issue if this is used as a test service or with demo code.  
* **use-startup**  
This project uses the Startup class along iwth separate controllers. The controllers are not asynchronous. The data is hard-coded, so this is not an issue if this isused as a test service or with demo code.

## Running the Service  
Each project folder has a "People.Service" folder. The following instructions are the same for running any of the 4 projects.  

1. Open a terminal in the "People.Service".
2. Type "dotnet run". (This will rebuild the project if necessary.)
3. The service should start and show the following info:
```
info: Microsoft.Hosting.Lifetime[0]
      Now listening on: http://localhost:9874
info: Microsoft.Hosting.Lifetime[0]
      Application started. Press Ctrl+C to shut down.
info: Microsoft.Hosting.Lifetime[0]
      Hosting environment: Development
```

If you open a browser to http://localhost:9874/people, you will see data from the service.

To stop the service, press "Ctrl+C" in the terminal.

