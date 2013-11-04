#load "controller.csx"
#load "jsonController.csx"


var webApi = Require<WebApi>();
var server = webApi.CreateServer("http://localhost:8877");
server.OpenAsync().Wait();

Console.WriteLine("Listening...");
Console.ReadKey();
server.CloseAsync().Wait();
