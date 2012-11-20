using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QuickBooksSample.Models;

namespace QuickBooksSample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ClientsAndServices()
        {
            var model = new ClientListingViewModel
            {
                AccountName = "Sample Client Name",
                ClientList = GetAllClientNames(),
                ServicesList = GetAllServiceNames()
            };
            return View(model);
        }

        public ActionResult TimeActivities()
        {
            return View();
        }

        public ActionResult ShowTimeActivities(DateTime StartDate, DateTime EndDate)
        {
            var model = GetTimeActivitiesBetween(StartDate, EndDate);
            return PartialView("ActivityListing", model);
        }

        public ActionResult CreateTimeActivity()
        {
            return View();
        }

        private List<string> GetAllClientNames()
        {
            // TODO #1 Gather the names of all active clients and return in a list
            List<string> clientnames = new List<string>();
            clientnames.Add("First Example Client Name"); 
            clientnames.Add("Second Example Client Name");
            return clientnames;
        }

        private List<string> GetAllServiceNames()
        {
            // TODO #2 Gather the names of all services for all clients and return in a list
            List<string> servicenames = new List<string>();
            servicenames.Add("Service name #1");
            servicenames.Add("Service name #2");
            return servicenames;
        }

        private List<TimeActivityViewModel> GetTimeActivitiesBetween(DateTime startdate, DateTime enddate)
        {
            // TODO #3 Gather all activities between the start and end dates and create
            // TODO    a new instance of TimeActivityViewModel for each
            List<TimeActivityViewModel> models = new List<TimeActivityViewModel>();
            var sample = new TimeActivityViewModel
                {
                    ActivityDate = DateTime.Today,
                    ClientName = "The Client Name",
                    ServiceName = "Which Service",
                    Description = "Here's a description of the work I performed",
                    HoursWorked = (decimal)1.25,
                    IsBillable = true,
                    UserName = "Steve Scheffler"
                };
            models.Add(sample);
            return models;
        }

        [HttpPost]
        public ActionResult CreateNewTimeActivity(TimeActivityViewModel model)
        {
            // TODO #4 Given the model information, create a new Time Activity
            return RedirectToAction("Index");
        }

    }
}
