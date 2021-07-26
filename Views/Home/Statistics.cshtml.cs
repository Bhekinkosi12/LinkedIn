using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LinkedIn.Models.ViewModel;
using LinkedIn.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LinkedIn.Views.Home
{
    public class StatisticsModel : PageModel
    {
        UserStore store { get; set; } = new UserStore();
        UserViewModel models = new UserViewModel("1");
        public void OnGet()
        {
           
        }
        public StatisticsModel()
        {
            getdata();
        }

        public string ProfilePicture { get; set; }




        void getdata()
        {
            var user = store.ReturnUser(1);
          ProfilePicture =  models.ProfilePicture;
                
        }


    }
}
