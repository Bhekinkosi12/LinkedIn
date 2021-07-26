using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LinkedIn.Models
{
    public class NewsFeed
    {


        public int ID { get; set; }
        public string Name { get; set; }
        public string Profile { get; set; }
        public string KnowAs { get; set; }
        public DateTime Time { get; set; }
        public string PostDescription { get; set; }
        public string Source { get; set; }

    }
}
