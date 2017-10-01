# Introduction
This project is to give you overview of ASPNET Core 2.0 Web API

# Installtion
You need to install the following tools in  order to get started

* .NET SDK http://dot.net
* Visual Studio http://visualstudio.com

or you can use cross platform editor

* Visual Studio Code https://code.visualstudio.com

# Getting Started
after installation go to your teminal or cmd in windows and write the following command

```{r, engine='sh'}
dotnet --version
```

you should get the version 2.0

After that, run the following command to create your web api project

```{r, engine='sh'}
dotnet new webapi 
```

Then run the application with the following command

```{r, engine='sh'}
dotnet run
```

you should see the last two lines in the cmd or terminal

```{r, engine='sh'}
Now listening on: http://localhost:5000
Application started. Press Ctrl+C to shut down.
```

>  Now your application is listening on http://localhost:5000
> Open your browser to the link http://localhost:5000/api/date


