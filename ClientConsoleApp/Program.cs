using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices;

Console.WriteLine(RuntimeInformation.FrameworkDescription);
ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls13;

var httpClient = new HttpClient();
ConsoleKeyInfo key;
do
{
  key = Console.ReadKey();
  
  if (key.KeyChar == '1')
  {
    var res = httpClient.SendAsync(
      new HttpRequestMessage(HttpMethod.Get, "https://192.168.178.45:58000" + "/api/time")).Result;
    Console.WriteLine(res.RequestMessage);
    Console.WriteLine(res);
    Console.WriteLine(res.Content.ReadAsStringAsync().Result);
  }

} while (key.Key != ConsoleKey.Escape);

