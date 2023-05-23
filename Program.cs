using NETGraphQLSample.Queries;

namespace NETGraphQLSample
{
	public class Program
	{
		public static void Main(string[] args)
		{
			//See article: https://chillicream.com/docs/hotchocolate/v13
			//HotChocolate.AspNetCore is required package

			int? xx = null;
			xx = 10;

			string str = null;

			if (xx != null)
			{
				Console.WriteLine($"xx: {xx}");
			}

			if (str != null)
			{
				Console.WriteLine($"str: {str}");
			}


			var builder = WebApplication.CreateBuilder(args);

			builder.Services
				.AddGraphQLServer()
				.AddQueryType<Query>();

			var app = builder.Build();

			app.MapGraphQL();

			app.MapGet("/", () => "Hello from GraphQL");

			app.Run();
		}
	}
}