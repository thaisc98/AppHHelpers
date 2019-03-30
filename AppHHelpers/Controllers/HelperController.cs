using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using AppHHelpers.Models;

namespace AppHHelpers.Controllers
{
    public class HelperController : Controller
    {
        private HtmlHelpDbEntities db;

        public HelperController()
        {
            db = new HtmlHelpDbEntities();

        }

        // GET: Helper
        public ActionResult Index()
        {
            return View(db.Persona.ToList());
        }


        [HttpGet]
        public ActionResult Create()
        {


            ViewBag.GeneroId = new SelectList(db.Genero.ToList(), "Id", "Descripcion");

            List<string> list = new List<string>();
            
            list.Add("Ver pelicula");
            list.Add("Leer manga");
            list.Add("Leer");
            list.Add("Estudiar");


            ViewBag.Hobbies = list;
            return View();
        }

        [HttpPost]
        public ActionResult Create(Persona p, FormCollection c)
        {
            if (ModelState.IsValid)
            {
                var x = c["Hobby"];
                p.Hobbies = x;
                db.Persona.Add(p);
                db.SaveChanges();
                return RedirectToAction("Index", "Helper");
            }

            return View();
        }


        






    }
}