using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LinkedIn.Models;

namespace LinkedIn.Services
{
    public class UserStore : IUserData
    {
        List<User> UserData { get; set; }


      public UserStore()
        {
            userdate();
        }


       public void setLike(string profileID)
        {

            var item = UserData.FirstOrDefault(x => x.Id == int.Parse(profileID));
            item.PageNotification += 1;
            UserData = new List<User>();
        }

        void userdate()
        {
            UserData = new List<User>()
            {
                new User
                {
                    Id = 1,
                    AutomatedId = 1,
                    Name = "Bhekinkosi Elijih",
                    Bio = "Founder of LearnOne \n Founder of Taxi Handler",
                    ProfilePicture = "../drawable/profile_image/Profile.png",
                    Email = "ndumiso5154kk@gmail.com",
                    PageNotification = 2,
                    PageVisitors = 0,
                    PostViews = 0,
                    ProfileViews = 0,
                    CoverPage = "../drawable/profile_image/cover1.jpg",
                    NewsFeeds = new List<NewsFeed>()
                    {
                        new NewsFeed
                        {
                            Name = "Bhekinkosi Elijih",
                            Profile = "../drawable/profile_image/Profile.png",
                            ID = 1,
                            KnowAs = "LearnOne Founder",
                            PostDescription = "I would like to puch forward the workings of pick and pay",
                            Time = new DateTime(2021,8,28),
                            Source = "../drawable/Videos/picknpayVideo.mp4"
                        },
                        new NewsFeed
                        {
                            Name = "Amanda Nkosi",
                            Profile = "../drawable/profile_image/profileAmanda.jpg",
                            ID = 12,
                            KnowAs = "Senior Software Engineer",
                            PostDescription = "Game Stores have one of the best offers and deals in the retail market",
                            Time = new DateTime(2021,10,2),
                            Source = "../drawable/Videos/GameSAWinterBlues.mp4"
                            
                        },
                         new NewsFeed
                        {
                            Name = "Aydan Norts",
                            Profile = "../drawable/profile_image/profile3.jpg",
                            ID = 3,
                            KnowAs = "Juniour Software engineer",
                            PostDescription = "My brother helped me build this site!",
                            Time = new DateTime(2021,10,1),
                            Source = "../drawable/Videos/portfolio.mp4"
                        }
                    }


                },


                  new User
                {
                    Id = 2,
                    AutomatedId = 2,
                    Name = "Amanda Nkosi",
                    Bio = " Brand Promotor",
                    ProfilePicture = "../drawable/profile_image/profileAmanda.jpg",
                    Email = "Amanda@gmail.com",
                    PageNotification = 3,
                    PageVisitors = 10,
                    PostViews = 5,
                    ProfileViews = 10,
                    CoverPage = "../drawable/profile_image/cover2.jpg",
                    NewsFeeds = new List<NewsFeed>()
                    {
                         new NewsFeed
                        {
                            Name = "Aydan Norts",
                            Profile = "../drawable/profile_image/profile3.jpg",
                            ID = 3,
                            KnowAs = "Juniour Software engineer",
                            PostDescription = "My brother helped me build this site!",
                            Time = new DateTime(2021,10,1),
                            Source = "../drawable/Videos/portfolio.mp4"
                        },
                        new NewsFeed
                        {
                            Name = "Bhekinkosi Elijih",
                            Profile = "../drawable/profile_image/Profile.png",
                            ID = 1,
                            KnowAs = "LearnOne Founder",
                            PostDescription = "I would like to puch forward the workings of pick and pay",
                            Time = new DateTime(2021,8,28),
                            Source = "../drawable/Videos/picknpayVideo.mp4"
                        },
                        new NewsFeed
                        {
                            Name = "Amanda Nkosi",
                            Profile = "../drawable/profile_image/profileAmanda.jpg",
                            ID = 2,
                            KnowAs = "Senior Software Engineer",
                            PostDescription = "Game Stores have one of the best offers and deals in the retail market",
                            Time = new DateTime(2021,10,2),
                            Source = "../drawable/Videos/GameSAWinterBlues.mp4"

                        }
                    }


                }

                  ,
                     new User
                {
                    Id = 3,
                    AutomatedId = 3,
                    Name = "Aydan Norts",
                    Bio = " Junior Software Engineer",
                    ProfilePicture = "../drawable/profile_image/profile3.jpg",
                    Email = "Norts21@gmail.com",
                    PageNotification = 120,
                    PageVisitors = 13,
                    PostViews = 155,
                    ProfileViews = 120,
                    CoverPage = "../drawable/profile_image/cover3.jpg",
                    NewsFeeds = new List<NewsFeed>()
                    {
                        new NewsFeed
                        {
                            Name = "Amanda Nkosi",
                            Profile = "../drawable/profile_image/profileAmanda.jpg",
                            ID = 2,
                            KnowAs = "Senior Brand Promotor",
                            PostDescription = "Game Stores have one of the best offers and deals in the retail market",
                            Time = new DateTime(2021,10,2),
                            Source = "../drawable/Videos/GameSAWinterBlues.mp4"

                        },
                        new NewsFeed
                        {
                            Name = "Aydan Norts",
                            Profile = "../drawable/profile_image/profile3.jpg",
                            ID = 3,
                            KnowAs = "Juniour Software engineer",
                            PostDescription = "My brother helped me build this site!",
                            Time = new DateTime(2021,10,1),
                            Source = "../drawable/Videos/portfolio.mp4"
                        },
                        new NewsFeed
                        {
                            Name = "Bhekinkosi Elijih",
                            Profile = "../drawable/profile_image/Profile.png",
                            ID = 1,
                            KnowAs = "LearnOne Founder",
                            PostDescription = "I would like to puch forward the workings of pick and pay",
                            Time = new DateTime(2021,8,28),
                            Source = "../drawable/Videos/picknpayVideo.mp4"
                        }
                    }


                }

            };
        }

        public User ReturnUser(int id)
        {
            return UserData.FirstOrDefault(x => x.Id == id);
        }
        public List<User> ReturnAll()
        {
            return UserData;
        }

        public void LikePost(int postId)
        {
            var posts = UserData.FirstOrDefault(x => x.NewsFeeds == x.NewsFeeds);
            
        }

        public List<NewsFeed> ReturnPosts(int userId)
        {
            List<NewsFeed> news = new List<NewsFeed>();
            foreach(var i in UserData)
            {
                news = i.NewsFeeds;
            }
            return news;
        }

        public void ViewPost(int postId)
        {
            
        }
    }
}
