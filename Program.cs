




using Microsoft.Extensions.Configuration;

var config = new ConfigurationBuilder()
           .AddJsonFile("appSettings.json")
           .Build();
var ConnectionString = config.GetSection("ConnectionStrings").Value;

Console.WriteLine(ConnectionString);