using ConsoleAppConfig;
using Microsoft.Extensions.Configuration;

IConfiguration configuration = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json", optional:true , reloadOnChange:true)
    .AddEnvironmentVariables()
    .AddCommandLine(args)
    .Build();

var serverConnection1 = configuration.GetSection("ServerConnection");

var url = serverConnection1.GetValue<string>("Url");
var port = serverConnection1.GetValue<int>("Port");
var isSsl = serverConnection1.GetValue<bool>("IsSSL");
var password = serverConnection1.GetValue<string>("Password");

var serverConnection = new ServerConnection();
configuration.GetSection("ServerConnection").Bind(serverConnection);

Console.WriteLine(serverConnection);

Console.Read();