using DogAndPeoples.Infra;
using DogAndPeoples.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DogAndPeoples.DAO
{
    public class PostDAO
    {
        private readonly DogAndPeoplesContext context;

        //Dependency Injection
        public PostDAO(DogAndPeoplesContext context)
        {
            this.context = context;
        }
        public List<People> List()
        {
            //var list = (from a in context.Peoples
            //               join c in context.Peoples on a.PeopleID equals c.Dog.DogID into lg
            //               from x in lg.DefaultIfEmpty()
            //               select new People()
            //               {
            //                   a.PeopleID,
            //                   a.PeopleName,
            //                   x.Dog.DogName,
            //                   x.Dog.DogBreed
            //               }).ToList();
            var list = context.Peoples.Include(d => d.Dog).OrderBy(x => x.PeopleID).ToList(); //Using include
            return list;
        }
        public void Add(People people)
        {
            context.Peoples.Add(people);
            context.SaveChanges();
        }

        public void Remove(int id)
        {
            var people = context.Peoples.OrderBy(p => p.PeopleID).Include(d => d.Dog.DogID).First();
            context.Peoples.Remove(people);
            context.SaveChanges();
        }

        public List<People> BreedFilter(string breed)
        {
            List<People> list = context.Peoples.Where(post => post.Dog.DogBreed.Contains(breed)).ToList();
            return list;
        }

        public void Update(People post)
        {
            context.Entry(post).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
