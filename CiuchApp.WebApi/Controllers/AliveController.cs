using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CiuchApp.DataContext;
using CiuchApp.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CiuchApp.WebApi.Controllers
{
    [ApiController]
    [Route("/")]
    public  class AliveController : ControllerBase 
    {
        [HttpGet]
        public bool Get() => true;
    }

}
