using CiuchApp.Domain;
using CiuchApp.Services;
using CiuchApp.Settings;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace CiuchApp.DI
{
    public static class CiuchAppServiceRegistrator
    {
        public static void RegisterCiuchAppServices(IServiceCollection services)
        {
            // Add application services.
            services.AddTransient<IEmailSender, EmailSender>();
            services.AddTransient<ICiuchAppSettings, CiuchAppSettings>();
            services.AddTransient<ICrudService<BusinessTrip>, BusinessTripService>();
            services.AddTransient<ICrudService<Piece>, PieceService>();
            services.AddTransient<ICrudService<SizeAmountPair>, SizeAmountPairService>();
            services.AddTransient<IDropdownServices, DropdownServices>();

            AddTransientDropdownService<Country>(services);
            AddTransientDropdownService<City>(services);
            AddTransientDropdownService<Season>(services);
            AddTransientDropdownService<Currency>(services);
            AddTransientDropdownService<Color>(services);
            AddTransientDropdownService<TopCategory>(services);
            AddTransientDropdownService<MainCategory>(services);
            AddTransientDropdownService<Group>(services);
            AddTransientDropdownService<Component>(services);
            AddTransientDropdownService<CountryOfOrigin>(services);
            AddTransientDropdownService<Supplier>(services);
            AddTransientDropdownService<CodeCn>(services);
            AddTransientDropdownService<Set>(services);
            AddTransientDropdownService<ColorName>(services);
            AddTransientDropdownService<Size>(services);
        }

        private static void AddTransientDropdownService<T>(IServiceCollection services) where T : DropDownValueBase
        {
            services.AddTransient<ICrudService<T>, DropdownService<T>>();
        }
    }
}
