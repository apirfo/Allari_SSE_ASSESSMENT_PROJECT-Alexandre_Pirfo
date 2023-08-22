using Allari_SSE_ASSESSMENT_PROJECT_Alexandre_Pirfo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Text.Json;

namespace Allari_SSE_ASSESSMENT_PROJECT_Alexandre_Pirfo.Controllers
{
    public class HomeController : Controller
    {
        

        public IActionResult Index()
        {
            PropertiesList propertiesList = new PropertiesList();
            List<Property> defaultPropertiesList = propertiesList.GeerateDefaultProperties();
            return View(defaultPropertiesList);
        }

        public JsonResult UpdateData()
        {
            PropertiesList propertiesList = new PropertiesList();
            List<Property> defaultPropertiesList = propertiesList.GeerateDefaultProperties();
           
            return Json(
                defaultPropertiesList.Select(a => new
                {
                    id = a._id,
                    name = a.name,
                    description = a.description,
                    province = a.province ,
                    state =  a.state,
                    country = a.country,
                    owner = new {
                        name = a._owner.name,
                        phone = a._owner.phoneNumber,
                        email = a._owner.email
                    }
    })
            );
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}