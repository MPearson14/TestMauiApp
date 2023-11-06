﻿using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using TestMauiApp.ViewModels;

namespace TestMauiApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            #if DEBUG
		            builder.Logging.AddDebug();
            #endif

            builder.Services.AddTransient<MainViewModel>();
            builder.Services.AddTransient<DetailViewModel>();

            builder.Services.AddTransient<DetailPage>();

            return builder.Build();
        }
    }
}