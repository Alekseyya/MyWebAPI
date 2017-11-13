using MyWebAPI.BL.Services.Intefaces;
using System;
using System.Collections.Generic;
using System.Web.Http;
using AutoMapper;
using MyWebAPI.Api.Models;
using MyWebAPI.BL.ModelsContract;
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

        // GET api/values
        public IEnumerable<Client> Get()
        {
            var users =
                Mapper.Map<IEnumerable<ClientContract>, List<Client>>(_service.GetAllClients());
            return users;
        }

        // GET api/values/5
        public string Get(int id)
        {
            //var findClient = 
            //var client = Mapper.Map<Client, ClientContract>(_service.GetClientById(id));
            return "value";
        }

        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        [HttpPut]
        public void Put(int id, [FromBody]string value)
        {
        }

        [HttpDelete]
        public void Delete(int id)
        {
        }
    }
}
