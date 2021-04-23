namespace DogAndPeoples.Models
{
    public class Post
    {
        public int ID { get; set; }
        public People People { get; set; }
        public Dog Dog { get; set; }
    }
}
