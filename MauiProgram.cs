using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using MarsForever.Services;
using System.Reflection;
using Microsoft.Extensions.FileProviders;

namespace MarsForever;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
			});
        var assembly = typeof(App).GetTypeInfo().Assembly;
        var config = new ConfigurationBuilder().AddJsonFile(new EmbeddedFileProvider(assembly),"config.json", optional: false, false).Build();

		builder.Configuration.AddConfiguration(config);
		builder.Services.AddMauiBlazorWebView();

#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();
		builder.Logging.AddDebug();
#endif
		builder.Services.AddSingleton<NasaPhotoController>();

		return builder.Build();
	}
}
