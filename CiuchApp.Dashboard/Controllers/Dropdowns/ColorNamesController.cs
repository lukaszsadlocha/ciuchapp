﻿using CiuchApp.Domain;
using CiuchApp.Services;
using CiuchApp.Settings;
using Microsoft.Extensions.Logging;
using CiuchApp.Dashboard.Controllers.Base;

namespace CiuchApp.Dashboard.Controllers.Dropdowns
{
    public class ColorNamesController : CiuchAppDrodownBaseController<ColorName>
    {
        public ColorNamesController(ICrudService<ColorName> serviceProvider, ILogger<ColorName> logger, ICiuchAppSettings settings, IDropdownServices dropdownServices) : base(serviceProvider, logger, settings, dropdownServices)
        {
        }
    }

}