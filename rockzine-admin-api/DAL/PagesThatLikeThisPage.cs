using System;
using System.Collections.Generic;

namespace rockzine_admin_api.DAL
{
    public  class PagesThatLikeThisPage 
    {
        public int Id { get; set; }
        public int ResponseOffset { get; set; }
        public string ResponseText { get; set; }
    }    
}
