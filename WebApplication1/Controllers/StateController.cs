using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyLearning.Entities.Models;
using MyLearning.Repo.Interfaces;

namespace MyLearning.UI.Controllers
{
    public class StateController : Controller
    {
        private readonly IStateRepo _state;
        private readonly ICountryRepo _country;

        public StateController(IStateRepo state, ICountryRepo country)
        {
            this._state = state;
            _country = country;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var b = _state.AllData();
            return View(b);
        }
        [HttpGet]
        public IActionResult Create()
        {
            var countries = _country.AllData();
            ViewBag.CountryList = new SelectList(countries, "CountryId", "CountryName");
            State s = new State();
            return View(s);

        }
        [HttpPost]
        public IActionResult Create(State state)
        {
            _state.CreateState(state);
            

            return RedirectToAction("Index");

        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var c = _state.GetState(id);

            return View(c);

        }
        //[HttpPost]
        //public IActionResult Details(Country country)
        //{
        //    _country.CreateCountry(country);

        //    return RedirectToAction("Index");

        //}
        [HttpGet]
        public IActionResult Edit(int id)
        {
            State state = _state.GetState(id);
            return View(state);

        }
        [HttpPost]
        public IActionResult Edit(State state)
        {

            _state.UpdateState(state);

            return RedirectToAction("Index");

        }
        [HttpGet]
        public IActionResult Deletedata(int id)
        {
            State state = _state.GetState(id);
            _state.DeleteState(state);

            return RedirectToAction("Index");

        }

    }
}
