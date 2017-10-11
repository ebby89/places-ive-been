using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using PlacesWebsite.Models;

namespace PlacesWebsite.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/"), ActionName("PlaceForm")]
        public ActionResult Index()
        {
            return View(Place.GetAll());
        }

        [HttpPost("/places/new"), ActionName("PlaceForm")]
        public ActionResult NewPlace()
        {
            string placeName = Request.Form["place-name"];
            string placeImageURL = Request.Form["place-image"];
            Place newPlace = new Place(placeName, placeImageURL);
            return View(Place.GetAll());
        }

        [HttpGet("/places/{id}"), ActionName("PlaceInfo")]
        public ActionResult PlaceInfo(int id)
        {
            Place selectedPlace = Place.Find(id);
            return View(selectedPlace);
        }
    }
}
