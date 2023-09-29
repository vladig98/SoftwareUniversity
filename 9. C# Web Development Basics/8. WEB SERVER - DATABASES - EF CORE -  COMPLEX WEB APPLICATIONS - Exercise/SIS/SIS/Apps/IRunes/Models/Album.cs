using System.Collections.Generic;
using System.Linq;

namespace IRunes.Models
{
    public class Album
    {
        public Album()
        {
            Tracks = new HashSet<Track>();
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public string Cover { get; set; }
        public decimal Price => Tracks.Sum(x => x.Price) * 0.87m;
        public ICollection<Track> Tracks { get; set; }
    }
}
