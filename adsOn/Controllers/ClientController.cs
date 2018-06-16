using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//using System.Web.Mvc;
using System.Web.Http;

namespace adsOn.Controllers
{
    public class ClientController : ApiController
    {
        [HttpPost]  
        public bool AddClientDetails()  
        {  
            return true;  
  
        }  
        [HttpGet]  
        public string GetClientDetails()  
        {  
            return "Vithal Wadje";  
  
        }  
        [HttpDelete]  
        public string DeleteClientDetails(string id)  
        {  
            return "Employee details deleted having Id " + id;  
  
        }  
        [HttpPut]  
        public string UpdateClientDetails(string Name, String Id)  
        {  
            return "Employee details Updated with Name " + Name + " and Id " + Id;  
  
        }  
    }
}
