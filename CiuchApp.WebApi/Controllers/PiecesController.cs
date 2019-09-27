using CiuchApp.Domain;
using CiuchApp.Services;
using Microsoft.Extensions.Logging;

namespace CiuchApp.WebApi.Controllers
{
    public class PiecesController : BaseController<Piece>
    {
        public PiecesController(ICrudService<Piece> service, ILogger<Piece> logger) : base(service, logger)
        {
        }
    }
}
