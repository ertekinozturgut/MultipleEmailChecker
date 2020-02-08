using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Newtonsoft.Json;
using Presentation.Models;
using Services;

namespace Presentation.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }
        [HttpPost]
        public List<Emails> GetEmails(string emailaddres)
        {
            List<string> emaillist = new List<string>();
            emailaddres=emailaddres.Trim();
            emaillist = emailaddres.Split(",").ToList();
            List<Emails> results = new List<Emails>();
            foreach (string email in emaillist)
            {
                try
                {
                    Emails emailadr = new Emails();
                    emailadr.email = email;
                    CheckService checkService = new CheckService(emailadr);
                    emailadr = checkService.getAllEmailDetails();
                    results.Add(emailadr);
                    GC.Collect();
                }
                catch(Exception ex)
                {

                }
          
            }
            //return RedirectToRoute("Home/Privacy",results);
            //TempDataExtensions.Put<List<Emails>>("emailresults", results);
            return results;
        }

        public ActionResult Privacy()
        {
            
            List<Emails> sonuclar = new List<Emails>();
            object o;
            TempData.TryGetValue("results", out o);
            sonuclar = o == null ? null : JsonConvert.DeserializeObject<List<Emails>>((string)o);          
            return View(sonuclar);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
    public static class TempDataExtensions
    {

        public static void Put<T>(this ITempDataDictionary tempData, string key, T value) where T : class
        {
            tempData[key] = JsonConvert.SerializeObject(value);
        }

        public static T Get<T>(this ITempDataDictionary tempData, string key) where T : class
        {
            object o;
            tempData.TryGetValue(key, out o);
            return o == null ? null : JsonConvert.DeserializeObject<T>((string)o);
        }

    }

}
