using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CiuchApp.Dashboard.Controllers.ViewComponents
{
    public class DeleteButtonRowViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return await Task.FromResult(View());
        }
    }
}

