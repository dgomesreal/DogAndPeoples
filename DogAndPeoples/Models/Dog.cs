using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DogAndPeoples.Models
{
    public class Dog
    {
        [Key()]
        public int DogID { get; set; }
        public string DogName { get; set; }
        public string DogBreed { get; set; }

        [ForeignKey("People")]
        public int PeopleId { get; set; }
        public virtual People People { get; set; }
    }
}
