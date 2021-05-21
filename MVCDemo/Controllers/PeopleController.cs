using MVCDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class PeopleController : Controller
    {
        // Default for a controller is index..
        // GET: People
        public ActionResult Index()
        {
            return View();
        }

        // Create a new Action Result to return the view ListPeople

        public ActionResult ListPeople()
        {
            // Create an instance of Person Model
            List<PersonModel> people = new List<PersonModel>();

            // Add values to person Model

            people.Add(new PersonModel { FirstName = "Adithya", LastName = "Vijay", Age = 24 });
            people.Add(new PersonModel { FirstName = "Akhila", LastName = "Jebin", Age = 26 });
            people.Add(new PersonModel { FirstName = "Arjun", LastName = "Narayanan", Age = 25 });

            // Passing the list of models to View, so that we can display it in the view
            // we can pass any sort of data to the view
            return View(people);
        }
    }
}