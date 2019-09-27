using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CiuchApp.Dashboard.Controllers.ViewComponents
{
    public class CardImageViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(int itemId)
        {
            //e.g. /Countries
            var folder = Request.Path.Value;
            var path = $@"/images{folder}/{itemId}.PNG";

            return await Task.Run(() => View(model: path));
        }
    }
}

