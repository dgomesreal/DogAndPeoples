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
        private DogAndPeoplesContext context;

        //Dependency Injection
        public PostDAO(DogAndPeoplesContext context)
        {
            this.context = context;
        }

        public List<Tuple<People, Dog>> List()
        {
            var list = context.Tuples.ToList();
            return list;
        }

        /*
        public void Add(People post)
        {
            context.People.Add(post);
            context.SaveChanges();
        }

        public void Remove(int id)
        {
            var p = new People() { PeopleID = id };
            context.People.Remove(p);
            context.SaveChanges();
            var d = new Dog() { DogID = id };
            context.Dog.Remove(d);
            context.SaveChanges();
        }

        public List<Post> BreedFilter(string breed)
        {
            List<Post> list = context.Post.Where(post => post.Dog.DogBreed.Contains(breed)).ToList();
            return list;
        }

        public void Update(Post post)
        {
            context.Entry(post).State = EntityState.Modified;
            context.SaveChanges();
        }*/
    }
}
