using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DogAndPeoples.Models
{
    public class People
    {
        [Key()]
        public int PeopleID { get; set; }
        public string PeopleName { get; set; }
        public virtual Dog Dog { get; set; }
    }
}
