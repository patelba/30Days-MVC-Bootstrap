using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GenFu;
using _30Days_MVC_Bootstrap.Models;



namespace _30Days_MVC_Bootstrap.Controllers
{
    public class SimpleController : Controller
    {
        // GET: Simple
        public ActionResult Index()
        {
            A.Configure<Person>().Fill(p => p.BirthDate).AsPastDate()
                .Fill(p2 => p2.LikesMusic).WithRandom(new bool[] { true, false })
                .Fill(p3 => p3.Skills).WithRandom(new ICollection<string>[] { new Collection<string>() { "Music", "Drilling", "DIY", "Driving" } });

            var person = A.New<Person>();

            //.Fill(p => p)
            //.WithinRange(19, 25);


            return View(person);
        }

        public ActionResult Create()
        {
            var person = new Person(); 
            return View(person);
        }


    }
}