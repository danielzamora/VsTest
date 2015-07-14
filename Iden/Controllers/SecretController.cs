using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Iden.Controllers
{
    
    [Authorize(Users="admin")] //makes whole controller protected and only user "admin" is allowed in
    public class SecretController : Controller
    {
        
        
        public ContentResult Secret()
        {
            return Content("this is a secret");
        }

        [AllowAnonymous] //overrules the authorize at the top for this method
        public ContentResult Overt()
        {
            return Content("this is NOT  secret");
        }


    }
}