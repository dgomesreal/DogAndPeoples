using System.ComponentModel.DataAnnotations;

namespace DogAndPeoples.Models
{
    public class People
    {
        [Key()]
        public int PeopleID { get; set; }
        [Required(ErrorMessage = "Required")]
        public string PeopleName { get; set; }
        public virtual Dog Dog { get; set; }
    }
}
