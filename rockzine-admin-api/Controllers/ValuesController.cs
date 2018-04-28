using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using rockzine_admin_api.Models;
//using rockzine_admin_api.DAL;

namespace rockzine_admin_api.Controllers
{
    [Route("api/[controller]")]
    public class FacebookController : Controller
    {
       

        // POST api/values
        [HttpPost]
        public void Post([FromForm]FacebookModel model)
        {
            // using (var db = new RockzinedbContext())
            // {

            //               foreach (var sandboxItem in db.Sandbox)
            //               {
            //                   Console.WriteLine(sandboxItem.Name);
            //               }
            // }

        }

       
    }
}
