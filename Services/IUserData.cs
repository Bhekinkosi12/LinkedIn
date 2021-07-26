using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LinkedIn.Models;


namespace LinkedIn.Services
{
   public interface IUserData
    {
        User ReturnUser(int id);
        void LikePost(int postId);
        List<NewsFeed> ReturnPosts(int userId);
        void ViewPost(int postId);
        List<User> ReturnAll();
    }
}
