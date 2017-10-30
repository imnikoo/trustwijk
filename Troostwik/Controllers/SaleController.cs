using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Troostwik.Repositories;
using Troostwik.Domain;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Troostwik.Controllers
{
    [Produces("application/json")]
    [Route("api/Sale")]
    public class SaleController : BaseController
    {
        public SaleRepository SaleRepository { get; set; }
        public SaleController()
        {
            SaleRepository = new SaleRepository(); //dependency injection should be right here (!!!)
        }
        // GET: api/Sale
        [HttpGet]
        public ActionResult Get()
        {
            return Serialize(SaleRepository.GetAll());
        }

        // GET: api/Sale/5
        [HttpGet("{id}", Name = "Get")]
        public ActionResult Get(int id)
        {
            return Serialize(SaleRepository.Read(id));
        }
        
        // POST: api/Sale
        [HttpPost]
        public void Post([FromBody]string value)
        {
            //post
        }
        
        // PUT: api/Sale/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
            //put
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            SaleRepository.Delete(id);
        }
    }
}
