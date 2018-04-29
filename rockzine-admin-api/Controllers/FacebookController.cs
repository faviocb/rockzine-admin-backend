using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using rockzine_admin_api.Models;
using rockzine_admin_api.DAL;

namespace rockzine_admin_api.Controllers
{
    [Route("api/[controller]")]
    public class FacebookController : Controller
    {
       
        private readonly RockzineDbContext _dbContext;

        public FacebookController(RockzineDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        // POST api/values
        [HttpPost]
        public void Post([FromForm]FacebookModel model)
        {
            // foreach (var sandboxItem in _dbContext.Sandbox)      // TODO FAVIO delete this
            // {
            //     Console.WriteLine(sandboxItem.Name);
            // }

            
            // TODO FAVIO make this dynamic in .Net ans postgresql table:
            switch(model.usersPool)     
            {
                case "PEOPLE_WHO_LIKE_THIS_PAGE":

                    _dbContext.PeopleWhoLikeThisPage.Add(new PeopleWhoLikeThisPage (){
                        ResponseOffset = model.offset,
                        ResponseText = model.rawFacebookResponse
                    });
                    break;
                case "PEOPLE_WHO_FOLLOW_THIS_PAGE":

                    _dbContext.PeopleWhoFollowThisPage.Add(new PeopleWhoFollowThisPage (){
                        ResponseOffset = model.offset,
                        ResponseText = model.rawFacebookResponse
                    });                
                    break;
                case "PAGES_THAT_LIKE_THIS_PAGE":
                
                    _dbContext.PagesThatLikeThisPage.Add(new PagesThatLikeThisPage (){
                        ResponseOffset = model.offset,
                        ResponseText = model.rawFacebookResponse
                    });
                    break;
                case "PEOPLE_BANNED_FROM_PAGE":
                
                    _dbContext.PeopleBannedFromPage.Add(new PeopleBannedFromPage (){
                        ResponseOffset = model.offset,
                        ResponseText = model.rawFacebookResponse
                    });
                    break;                                        
            }



            _dbContext.SaveChanges();

        }

       
    }
}
