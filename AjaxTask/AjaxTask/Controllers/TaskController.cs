using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AjaxTask.Models;

namespace AjaxTask.Controllers
{
    public class TaskController : Controller
    {
        // GET: Task
        public ActionResult Index()
        {
            taskEntities sd = new taskEntities();
            ViewBag.CountryList = new SelectList(GetCountryList(), "Cid", "Cname");
            return View();
        }
        public List<dbCountry> GetCountryList()
        {
            taskEntities sd = new taskEntities();
            List<dbCountry> countries = sd.dbCountries.ToList();
            return countries;
        }
        public ActionResult GetStateList(int Cid)
        {
            taskEntities sd = new taskEntities();
            List<dbState> selectList = sd.dbStates.Where(x => x.cid == Cid).ToList();
            ViewBag.Slist = new SelectList(selectList, "Sid", "Sname");
            return PartialView("DisplayStates");
        }
        public ActionResult GetCityList(int Sid)
        {
            taskEntities sd = new taskEntities();
            List<dbCity> selectList = sd.dbCities.Where(x => x.sid == Sid).ToList();
            ViewBag.Citylist = new SelectList(selectList, "Cityid", "Cityname");
            return PartialView("DisplayCities");
        }
    }
}