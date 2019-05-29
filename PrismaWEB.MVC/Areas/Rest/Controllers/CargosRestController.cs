using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using ProjetoModeloDDD.Application.Interface;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.MVC.ViewModels;

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
            var cargoViewModel = Mapper.Map<IEnumerable<Cargo>, IEnumerable<CargoViewModel>>(_cargoApp.GetAll());
            return Json(cargoViewModel, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetById(int id)
        {
            return Json(_cargoApp.GetById(id), JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public JsonResult Create(CargoViewModel cargo)
        {
            if (ModelState.IsValid)
            {
                var cargoDomain = Mapper.Map<CargoViewModel, Cargo>(cargo);
                _cargoApp.Add(cargoDomain);
                
            }

            return Json(cargo, JsonRequestBehavior.AllowGet);
        }

        public JsonResult Delete(int id)
        {
            try
            {
                var cargo = _cargoApp.GetById(id);
                _cargoApp.Remove(cargo);

                return Json($"Cargo {cargo.Nome} deletado com sucesso", JsonRequestBehavior.AllowGet);
            }
            catch (Exception exp)
            {
                return Json(exp, JsonRequestBehavior.AllowGet);
                throw;
            }
        }
    }
}