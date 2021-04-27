using DogAndPeoples.DAO;
using DogAndPeoples.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Dynamic;

namespace DogAndPeoples.Controllers
{
    public class PostController : Controller
    {
        private PostDAO dao;

        //Dependency Injection
        public PostController(PostDAO dao)
        {
            this.dao = dao;
        }

        /*public ActionResult Add(Post post)
        {
            dao.Add(post);
            return RedirectToAction("Index");
        }

        public ActionResult Remove(int id)
        {
            dao.Remove(id);
            return RedirectToAction("Index");
        }

        public ActionResult BreedFilter([Bind(Prefix = "id")] string breed)
        {
            List<Post> list = dao.BreedFilter(breed);
            return View("Index", list);
        }

        public ActionResult Edit(Post p)
        {
            if (ModelState.IsValid)
            {
                dao.Update(p);
                return RedirectToAction("Index");
            }
            else
            {
                return View("Edit",p);
            }
        }*/
        public ActionResult Report()
        {
            List<Tuple<People, Dog>> list = dao.List();
            return View(list);
        }
    }
}
