using System.Collections.Generic;

namespace DogAndPeoples.Models
{
    public class People
    {
        public int PeopleID { get; set; }
        public string PeopleName { get; set; }
        public List<Dog> Dogs { get; set; }
    }
}
