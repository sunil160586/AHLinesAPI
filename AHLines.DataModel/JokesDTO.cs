using System;

namespace AHLines.DataModel
{
    public class Joke
    {
        public int? JokeId { get; set; }
        public string JokeCaption { get; set; }
        public string JokeCategory { get; set; }
        public bool JokeStatus { get; set; }
        public string JokeAbstract { get; set; }
        public string JokeDescription { get; set; }
        public string JokeAuthor { get; set; }
        public string AuthorEmail { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
    }
}
