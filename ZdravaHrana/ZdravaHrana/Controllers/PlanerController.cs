using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using ZdravaHrana.Domain.Entities;
using ZdravaHrana.Domain.Entities.Interfaces;
using ZdravaHrana.Infrastructure.DataSql.Repositories;

namespace ZdravaHrana.Controllers
{
    public class PlanerController : ApiController
    {
        IPlanerRepository _planerRepository;

        [HttpGet]
        [ResponseType(typeof(List<Planer>))]
        [ActionName("planer")]
        public HttpResponseMessage GetAllPlaners(string name = "")
        {
            _planerRepository = new PlanerRepository();

            List<Planer> planer = new List<Planer>();

            if (!string.IsNullOrWhiteSpace(name))
                planer = _planerRepository.getAllPlaners()
                    .Where(x => x.planerName.ToLower().Contains(name.ToLower()))
                    .ToList();
            else
                planer = _planerRepository.getAllPlaners().ToList();

            return Request.CreateResponse(HttpStatusCode.OK, planer);
        }
    }
}
