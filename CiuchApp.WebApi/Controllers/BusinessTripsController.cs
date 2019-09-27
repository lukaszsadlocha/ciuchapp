using CiuchApp.DataContext;
using CiuchApp.Domain;
using CiuchApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;

namespace CiuchApp.WebApi.Controllers
{
    public class BusinessTripsController : BaseController<BusinessTrip>
    {
        public BusinessTripsController(ICrudService<BusinessTrip> service, ILogger<BusinessTrip> logger) : base(service, logger)
        {
        }

        [HttpGet]
        [Route("{id}/Pieces")]
        public IEnumerable<Piece> GetBusinessTripPieces(int id)
        {
            return _service.GetContext().Pieces.Where(x => x.BusinessTripId == id)
                .Include(p => p.CodeCn)
                .Include(p => p.Color)
                .Include(p => p.ColorName)
                .Include(p => p.Component)
                .Include(p => p.CountryOfOrigin)
                .Include(p => p.Group)
                .Include(p => p.MainCategory)
                .Include(p => p.Set)
                .Include(p => p.Supplier)
                .Include(p => p.TopCategory)
                .Include(p => p.SizeAmountPairs);
        }
    }
}
