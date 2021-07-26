using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LinkedIn.Models
{
    public class User
    {

        public int Id { get; set; }
        public int AutomatedId { get; set; }
        public string Name { get; set; }
        
        public string Bio { get; set; }
        public string Email { get; set; }
        public string ProfilePicture { get; set; }
        public string CoverPage { get; set; }
        public int ProfileViews { get; set; }
        public int PostViews { get; set; }
        public int PageNotification { get; set; }
        public int PageVisitors { get; set; }

        public List<NewsFeed> NewsFeeds { get; set; }
      



    }
}
