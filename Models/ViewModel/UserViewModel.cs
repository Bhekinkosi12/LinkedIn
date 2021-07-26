using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LinkedIn.Models;
using LinkedIn.Services;

namespace LinkedIn.Models.ViewModel
{
    public class UserViewModel : BaseViewModel
    {
        IUserData data { get; set; } = new UserStore();
        UserStore store { get; set; } = new UserStore();

        private string name;
        private string bio = "Love";
        private string email;
        private string profilePicture;
        private string coverPage;
        private int profileView;
        private int postView;
        private int pageNotification;
        private int pageVisitors;
        private List<NewsFeed> feed;
        private List<User> users;

        public UserViewModel(string id)
        {
            getData(Int32.Parse(id));
           // getData();
        }
        public UserViewModel(string id,int likeId)
        {
            setLike(id, likeId);
        }


        public List<User> Users
        {
            get => users;
            set
            {
                SetProperty(ref users, value);
                OnPropertyChanged(nameof(Users));
            }
        }

        public string Name
        {
            get => name;

            set
            {
                SetProperty(ref name, value);
                OnPropertyChanged(nameof(Name));
            }
        }
        public string Bio
        {
            get => bio;
            set
            {
                SetProperty(ref bio, value);
                OnPropertyChanged(nameof(Bio));
            }

        }
        public string Email
        {
            get => email;
            set
            {
                SetProperty(ref email, value);
                OnPropertyChanged(nameof(Email));
            }

        }
        public string ProfilePicture
        {
            get => profilePicture;
            set
            {
                SetProperty(ref profilePicture, value);
                OnPropertyChanged(nameof(ProfilePicture));
            }

        }
        public string CoverPage
        {
            get => coverPage;
            set
            {
                SetProperty(ref coverPage, value);
                OnPropertyChanged(nameof(CoverPage));
            }
        }
        public int ProfileViews
        {
            get => profileView;
            set
            {
                SetProperty(ref profileView, value);
                OnPropertyChanged(nameof(ProfilePicture));
            }
        }
        public int PostViews
        {
            get => postView;
            set
            {
                SetProperty(ref postView, value);
                OnPropertyChanged(nameof(PostViews));
            }
        }
        public int PageNotification
        {
            get => pageNotification;
            set
            {
                SetProperty(ref pageNotification, value);
                OnPropertyChanged(nameof(PageNotification));
            }
        }
        public int PageVisitors
        {
            get => pageVisitors;
            set
            {
                SetProperty(ref pageVisitors, value);
                OnPropertyChanged(nameof(PageVisitors));
            }

        }
        public List<NewsFeed> Feed
        {
            get => feed;
            set
            {
                SetProperty(ref feed, value);
                OnPropertyChanged(nameof(Feed));
            }
        }



        public void setLike(string id, int likeIds)
        {
                store.setLike(likeIds.ToString());
            try
            {
                feed = data.ReturnPosts(Int32.Parse(id));
                var user = data.ReturnUser(Int32.Parse(id));
                Users = store.ReturnAll();



                Name = user.Name;
                Bio = user.Bio;
                Email = user.Email;
                ProfilePicture = user.ProfilePicture;
                CoverPage = user.CoverPage;
                ProfileViews = user.ProfileViews;
                PostViews = user.PostViews;
                PageNotification = user.PageNotification;
                PageVisitors = user.PageVisitors;

            }
            catch (Exception ex)
            {

            }

         


        }



        public void getDataById(string id)
        {
            try
            {

                feed = data.ReturnPosts(Int32.Parse(id));
                var user = data.ReturnUser(Int32.Parse(id));
                Users = store.ReturnAll();



                Name = user.Name;
                Bio = user.Bio;
                Email = user.Email;
                ProfilePicture = user.ProfilePicture;
                CoverPage = user.CoverPage;
                ProfileViews = user.ProfileViews;
                PostViews = user.PostViews;
                PageNotification = user.PageNotification;
                PageVisitors = user.PageVisitors;

            }
            catch (Exception ex)
            {

            }



        }



        public UserViewModel NewData(string id)
        {
           getDataById(id);
            return new UserViewModel(id);

        }

       public void getData(int id)
        {
            try
            {

            feed = data.ReturnPosts(id);
            var user = data.ReturnUser(id);
                Users = store.ReturnAll();



            Name = user.Name;
            Bio = user.Bio;
            Email = user.Email;
            ProfilePicture = user.ProfilePicture;
            CoverPage = user.CoverPage;
            ProfileViews = user.ProfileViews;
            PostViews = user.PostViews;
            PageNotification = user.PageNotification;
            PageVisitors = user.PageVisitors;

            }
            catch(Exception ex)
            {
                
            }

            
            
        }



    }
}
