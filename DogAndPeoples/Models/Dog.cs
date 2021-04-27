using System.Collections.Generic;

namespace DogAndPeoples.Models
{
    public class Dog
    {
        public int DogID { get; set; }
        public string DogName { get; set; }
        public string DogBreed { get; set; }

        public int PeopleID { get; set; }
        public People People { get; set; }
    }
}
