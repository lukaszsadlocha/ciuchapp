using System;
using System.Linq;
using System.Threading.Tasks;
using CiuchApp.DataContext;
using CiuchApp.Domain;
using CiuchApp.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace CiuchApp.WebApi.Controllers
{


    public class ColorsController : BaseController<Color>
    {
        public ColorsController(ICrudService<Color> service, ILogger<Color> logger) : base(service, logger)
        {
        }
    }
    public class TopCategoriesController : BaseController<TopCategory>
    {
        public TopCategoriesController(ICrudService<TopCategory> service, ILogger<TopCategory> logger) : base(service, logger)
        {
        }
    }
    public class MainCategoriesController : BaseController<MainCategory>
    {
        public MainCategoriesController(ICrudService<MainCategory> service, ILogger<MainCategory> logger) : base(service, logger)
        {
        }
    }
    public class GroupsController : BaseController<Group>
    {
        public GroupsController(ICrudService<Group> service, ILogger<Group> logger) : base(service, logger)
        {
        }
    }
    public class ComponentsController : BaseController<Component>
    {
        public ComponentsController(ICrudService<Component> service, ILogger<Component> logger) : base(service, logger)
        {
        }
    }
    public class CountryOfOriginsController : BaseController<CountryOfOrigin>
    {
        public CountryOfOriginsController(ICrudService<CountryOfOrigin> service, ILogger<CountryOfOrigin> logger) : base(service, logger)
        {
        }
    }
    public class SuppliersController : BaseController<Supplier>
    {
        public SuppliersController(ICrudService<Supplier> service, ILogger<Supplier> logger) : base(service, logger)
        {
        }
    }
    public class SizesController : BaseController<Size>
    {
        public SizesController(ICrudService<Size> service, ILogger<Size> logger) : base(service, logger)
        {
        }
    }
    public class CodeCnsController : BaseController<CodeCn>
    {
        public CodeCnsController(ICrudService<CodeCn> service, ILogger<CodeCn> logger) : base(service, logger)
        {
        }
    }
    public class SetsController : BaseController<Set>
    {
        public SetsController(ICrudService<Set> service, ILogger<Set> logger) : base(service, logger)
        {
        }
    }
    public class ColorNamesController : BaseController<ColorName>
    {
        public ColorNamesController(ICrudService<ColorName> service, ILogger<ColorName> logger) : base(service, logger)
        {
        }
    }
    public class CountriesController : BaseController<Country>
    {
        public CountriesController(ICrudService<Country> service, ILogger<Country> logger) : base(service, logger)
        {
        }
    }
    public class CitiesController : BaseController<City>
    {
        public CitiesController(ICrudService<City> service, ILogger<City> logger) : base(service, logger)
        {
        }
    }
    public class SeasonsController : BaseController<Season>
    {
        public SeasonsController(ICrudService<Season> service, ILogger<Season> logger) : base(service, logger)
        {
        }
    }
    public class CurrenciesController : BaseController<Currency>
    {
        public CurrenciesController(ICrudService<Currency> service, ILogger<Currency> logger) : base(service, logger)
        {
        }
    }
    public class SizeAmountPairsController : BaseController<SizeAmountPair>
    {
        public SizeAmountPairsController(ICrudService<SizeAmountPair> service, ILogger<SizeAmountPair> logger) : base(service, logger)
        {
        }
    }
}
