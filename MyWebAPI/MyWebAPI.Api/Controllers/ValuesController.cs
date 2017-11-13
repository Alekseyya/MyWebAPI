using MyWebAPI.BL.Services.Intefaces;
using System;
using System.Collections.Generic;
using System.Web.Http;
using MyWebAPI.BL.Services;
using Ninject.Web.WebApi.Filter;

namespace MyWebAPI.Api.Controllers
{
    public class ValuesController : ApiController
    {
        private readonly IClientService _service;
        public ValuesController(IClientService service)
        {
            _service = service;
        }
        //public ValuesController()
        //{
        //    _service = new ClientService();
        //}

        // GET api/values
        public IEnumerable<string> Get()
        {
            //return new string[] { "value1", "value2" };
            var clients = _service.GetAllClients();
            var list = new List<string>();
            //jhksjdhf
            foreach (var client in clients)
            {
                list.Add(client.FirstName);
            }
            return list;
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
