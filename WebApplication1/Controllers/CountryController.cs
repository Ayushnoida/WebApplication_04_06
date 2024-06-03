using Microsoft.AspNetCore.Mvc;
using MyLearning.Repo.Interfaces;
using MyLearning.Entities.Models;

namespace MyLearning.UI.Controllers
{
    public class CountryController : Controller
    {
        private readonly ICountryRepo _country;

        public CountryController(ICountryRepo country)
        {
            this._country = country;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var b = _country.AllData();
            return View(b);
        }
        [HttpGet]
        public IActionResult Create()
        {
            Country c = new Country();
            return View(c);

        }
        [HttpPost]
        public IActionResult Create(Country country)
        {
            _country.CreateCountry(country);
            
            return RedirectToAction("Index");

        }

        [HttpGet]
        public IActionResult Details(int id )
        {
            var c = _country.GetCountry(id);
           
            return View(c);

        }
        //[HttpPost]
        //public IActionResult Details(Country country)
        //{
        //    _country.CreateCountry(country);

        //    return RedirectToAction("Index");

        //}
        [HttpGet]
        public IActionResult Updatedata(int id )
        {
            Country country = _country.GetCountry(id);
            return View(country);

        }
        [HttpPost]
        public IActionResult Updatedata(Country country)
        {
           
            _country.UpdateCountry(country);

            return RedirectToAction("Index");

        }
        [HttpGet]
        public IActionResult Deletedata(int id)
        {
            Country country = _country.GetCountry(id);
            _country.DeleteCountry(country);

            return RedirectToAction("Index");

        }
      

    }
}
