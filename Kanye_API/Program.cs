using System;
using RestSharp;
namespace Kanye_API
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Here's a quote from Kanye West. " + GetReleases());
		}
		public static string GetReleases()
		{
			var client = new RestClient("https://api.kanye.rest");
			var response = client.Execute(new RestRequest());
			return response.Content.Substring(9).TrimEnd('}');
		}
	}
}