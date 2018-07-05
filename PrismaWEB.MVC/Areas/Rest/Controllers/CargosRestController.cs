using ProjetoModeloDDD.Application.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoModeloDDD.MVC.Areas.Rest.Controllers
{
    public class CargosRestController : Controller
    {
        private readonly ICargoAppService _cargoApp;

        public CargosRestController(ICargoAppService cargoApp)
        {
            _cargoApp = cargoApp;
        }

        // GET: Rest/CargosRest
        //public ActionResult Index()
        //{
        //    return View();
        //}

        public JsonResult GetAll()
        {
            return Json(_cargoApp.GetAll(), JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetById(int id)
        {
            return Json(_cargoApp.GetById(id), JsonRequestBehavior.AllowGet);
        }
    }
}