using System.Net;

class Program
{
    static void Main(string[] args)
    {
        WebClient client = new WebClient();
        string url = "https://www.googleapis.com/geolocation/v1/geolocate?key=<your_api_key>";
        string request = "{\"considerIp\": \"true\"}";
        client.Headers.Add("Content-Type", "application/json");
        string response = client.UploadString(url, request);
        Console.WriteLine(response);
        Console.ReadKey();
    }
}