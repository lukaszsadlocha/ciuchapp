using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CiuchApp.Dashboard.Controllers.ViewComponents
{
    public class IndexButtonRowViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(bool includeExcelActions)
        {
            return await Task.FromResult(View(includeExcelActions));
        }
    }
}

