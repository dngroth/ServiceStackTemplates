# web-corefx

ServiceStack ASP.NET Core Empty Web project on .NET Framework

## Running

[![](https://raw.githubusercontent.com/ServiceStack/Assets/master/csharp-templates/web.png)](http://web.web-templates.io/)

Using docker:

```sh
docker build --tag servicestack . && docker run -p 5000:5000 servicestack
```

Using dotnet:

```sh
dotnet run --configuration Release --project App
```

The website will be hosted at <http://localhost:5000>
