using DogAndPeoples.DAO;
using DogAndPeoples.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DogAndPeoples.Controllers
{
    public class PostController : Controller
    {
        private readonly PostDAO dao;
        private List<People> list;

        //Dependency Injection
        public PostController(PostDAO dao)
        {
            this.dao = dao;
        }

        [HttpPost]
        public ActionResult Add(People people)
        {
            dao.Add(people);
            return RedirectToAction("Index", "Home");
        }

        public ActionResult Remove(int id)
        {
            dao.Remove(id);
            return RedirectToAction("Report");
        }

        public ActionResult BreedFilter([Bind(Prefix = "id")] string breed)
        {
            List<People> list = dao.BreedFilter(breed);
            return View("Index", list);
        }

        public ActionResult PeopleUpdate(People people)
        {
            if (ModelState.IsValid)
            {
                dao.Update(people);
                return RedirectToAction("Index");
            }
            else
            {
                return View("Report", people);
            }
        }

        public ActionResult Edit(int id)
        {
            People post = dao.FindPerId(id);
            return View(post);
        }

        public ActionResult Report()
        {
            list = dao.List();
            return View(list);
        }
    }
}
