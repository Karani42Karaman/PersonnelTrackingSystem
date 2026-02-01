using System.Web.Mvc;
using PersonnelTrackingSystem.BLL.Abstract;
using PersonnelTrackingSystem.BLL.Concrete;
using PersonnelTrackingSystem.Entities.DTOs;

namespace PersonnelTrackingSystem.UI.Controllers
{
    public class PersonelController : Controller
    {
        private readonly IPersonelService _personelService;

        public PersonelController()
        {
            _personelService = new PersonelManager();
        }

        // LIST
        public ActionResult Index()
        {
            var model = _personelService.GetAll();
            return View(model);
        }

        // CREATE - GET
        public ActionResult Create()
        {
            return View();
        }

        // CREATE - POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PersonelDto model)
        {
            if (!ModelState.IsValid)
                return View(model);

            _personelService.Add(model);
            return RedirectToAction("Index");
        }

        // EDIT - GET
        public ActionResult Edit(int id)
        {
            var model = _personelService.GetById(id);
            return View(model);
        }

        // EDIT - POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(PersonelDto model)
        {
            if (!ModelState.IsValid)
                return View(model);

            _personelService.Update(model);
            return RedirectToAction("Index");
        }

        // DELETE
        public ActionResult Delete(int id)
        {
            _personelService.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
