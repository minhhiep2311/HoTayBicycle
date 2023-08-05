using HoTayBicycle.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HoTayBicycle.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BicycleController : ControllerBase
    {
        QLThueXeDapContext db = new QLThueXeDapContext();
        public void Dispose()
        {
            if (db != null)
            { db.Dispose(); }
        }

        [HttpGet]
        public XeDap[] GetBike()
        {
            return db.XeDaps.ToArray();
        }
    }
}
