using Microsoft.Extensions.Logging;
using MarsForever.Data;
using Microsoft.Extensions.Configuration;
using MarsForever.Services;

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
		var config = new ConfigurationBuilder().AddJsonFile("config.json").Build();

		builder.Configuration.AddConfiguration(config);
		builder.Services.AddMauiBlazorWebView();

#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();
		builder.Logging.AddDebug();
#endif

		builder.Services.AddSingleton<WeatherForecastService>();
		builder.Services.AddSingleton<NasaPhotoController>();

		return builder.Build();
	}
}
