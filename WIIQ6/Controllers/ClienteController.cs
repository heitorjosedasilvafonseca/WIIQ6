using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WIIQ6.Context;
using WIIQ6.Models;

namespace WIIQ6.Controllers
{
    public class ClienteController : Controller
    {
        private WIIContext context = new WIIContext();

        // GET: Cliente
        public ActionResult Index()
        {
            return View(context.Clientes.OrderBy(c => c.Nome));
        }

        // GET: Cliente/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cliente/Create
        [HttpPost]
        public ActionResult Create(Cliente cliente)
        {
            try
            {
                context.Clientes.Add(cliente);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

    }
}
