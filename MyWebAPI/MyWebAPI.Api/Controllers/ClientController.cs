using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using MyWebAPI.Api.Models;
using MyWebAPI.BL.ModelsContract;
using MyWebAPI.BL.Services.Intefaces;

namespace MyWebAPI.Api.Controllers
{
    public class ClientController : Controller
    {
        private readonly IClientService _service;
        public ClientController(IClientService service)
        {
            _service = service;
        }
        // GET: Client
        //public ActionResult GetAllClients()
        //{
        //    var users =
        //        Mapper.Map<IEnumerable<ClientContract>, List<Client>>(_service.GetAllClients());
        //    return View(users);
        //}
    }
}