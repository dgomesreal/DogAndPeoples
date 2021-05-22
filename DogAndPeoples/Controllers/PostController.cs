﻿using DogAndPeoples.DAO;
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

        public ActionResult Add(People people)
        {
            dao.Add(people);
            return RedirectToAction("Index", "Home");
        }

        [HttpDelete("{id}")]
        public ActionResult Remove(int id)
        {
            dao.Remove(id);
            return RedirectToAction("Index");
        }

        public ActionResult BreedFilter([Bind(Prefix = "id")] string breed)
        {
            List<People> list = dao.BreedFilter(breed);
            return View("Index", list);
        }

        public ActionResult Edit(People p)
        {
            if (ModelState.IsValid)
            {
                dao.Update(p);
                return RedirectToAction("Index");
            }
            else
            {
                return View("Edit", p);
            }
        }

        public ActionResult Report()
        {
            list = dao.List();
            return View(list);
        }
    }
}
