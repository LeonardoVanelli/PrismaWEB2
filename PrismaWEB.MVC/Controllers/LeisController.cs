using System.Collections.Generic;
using System.Web.Mvc;
using AutoMapper;
using ProjetoModeloDDD.Application.Interface;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.MVC.ViewModels;

namespace ProjetoModeloDDD.MVC.Controllers
{
    public class LeisController : Controller
    {
        private readonly ILeiAppService _leiApp;

        public LeisController(ILeiAppService leiApp)
        {
            _leiApp = leiApp;
        }

        // GET: Leis
        public ActionResult Index()
        {
            var leiViewModel = Mapper.Map<IEnumerable<Lei>, IEnumerable<LeiViewModel>>(_leiApp.GetAll());
            return View(leiViewModel);
        }

        // GET: Leis/Details/5
        public ActionResult Details(int id)
        {
            var lei = _leiApp.GetById(id);
            var leiViewModel = Mapper.Map<Lei, LeiViewModel>(lei);
            return View(leiViewModel);
        }

        // GET: Leis/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Leis/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(LeiViewModel lei)
        {
            if (ModelState.IsValid)
            {
                var leiDomain = Mapper.Map<LeiViewModel, Lei>(lei);
                _leiApp.Add(leiDomain);

                return RedirectToAction("Index");
            }

            return View(lei);
        }

        // GET: Leis/Edit/5
        public ActionResult Edit(int id)
        {
            var lei = _leiApp.GetById(id);
            var leiViewModel = Mapper.Map<Lei, LeiViewModel>(lei);

            return View(leiViewModel);
        }

        // POST: Leis/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(LeiViewModel lei)
        {
            if (ModelState.IsValid)
            {
                var leiDomain = Mapper.Map<LeiViewModel, Lei>(lei);
                _leiApp.Update(leiDomain);

                return RedirectToAction("Index");
            }

            return View(lei);
        }

        // GET: Leis/Delete/5
        public ActionResult Delete(int id)
        {
            var lei = _leiApp.GetById(id);
            var leiViewModel = Mapper.Map<Lei, LeiViewModel>(lei);

            return View(leiViewModel);
        }

        // POST: Leis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var lei = _leiApp.GetById(id);

            _leiApp.Remove(lei);

            return RedirectToAction("Index");
        }
    }
}

