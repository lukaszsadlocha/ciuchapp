using CiuchApp.Services;
using CiuchApp.Domain;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CiuchApp.Dashboard.Controllers.ViewComponents
{
    public class LeftNavigationViewComponent : ViewComponent
    {
        private readonly ICrudService<BusinessTrip> service;

        public LeftNavigationViewComponent(ICrudService<BusinessTrip> service)
        {
            this.service = service;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return await Task.FromResult(View(service.GetAll()));
        }
    }
}

