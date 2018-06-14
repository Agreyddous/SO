using System.IO;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Real.Shared;

namespace Real.Api
{
    public class Startup
	{
		public static IConfiguration Configuration { get; set; }

		public void ConfigureServices(IServiceCollection services)
		{
			var builder = new ConfigurationBuilder()
				.SetBasePath(Directory.GetCurrentDirectory())
				.AddJsonFile("Settings.json");

			Configuration = builder.Build();

			services.AddMvc();
			services.AddResponseCompression();

			Config.Connection = Configuration["connection"];
		}

		public void Configure(IApplicationBuilder app, IHostingEnvironment env)
		{
			if (env.IsDevelopment())
				app.UseDeveloperExceptionPage();

			app.UseMvc();
			app.UseResponseCompression();
		}
	}
}