using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ScaffoldCoumnDataAnnotation.Controllers
{
    public class HomeController : Controller
    {
        //      SCAFFOLD COLUMN DATA ANNOTATION
        //when you use scaffolding using the Create Templete,
        //they view by default will create UI fields for all the properties of the model.
        //However, you might need to ensure that the template does not create UI fields for certain properties.
        //in such scenario, we will use the ScaffoldColumn annotation passing a false value.

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
    }
}