using System.Collections.Generic;
using System.Threading.Tasks;
using CiuchApp.DataContext;
using CiuchApp.Domain;
using CiuchApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace CiuchApp.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public abstract class BaseController<T> : ControllerBase where T : CiuchAppBaseModel
    {
        protected readonly ICrudService<T> _service;
        protected readonly ILogger<T> _logger;

        public BaseController(ICrudService<T> service, ILogger<T> logger)
        {
            _service = service;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IEnumerable<T>> Get() => await _service.GetAllAsync();

        [HttpGet("{id}")]
        public async Task<T> Get(int id) => await _service.GetByIdAsync(id);

        [HttpPost]
        public IActionResult Add([FromForm] T item)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (_service.Add(item))
                return Ok(item.Id);

            return NotFound();
        }

        [HttpPut]
        public IActionResult Edit([FromForm] T item)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (_service.Update(item))
                return Ok();

            return NotFound();
        }
        [HttpDelete]
        public IActionResult Delete([FromForm] T item)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (_service.Delete(item))
                return Ok();

            return NotFound();
        }
    }
}
