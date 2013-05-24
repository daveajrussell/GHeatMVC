
using GHeatMVC.Helpers.ExtensionMethods;
using GHeatMVCDomainModel.Interfaces.Services;
using GMap.NET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GHeatMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPointService _pointService;
        private readonly IGHeatService _gheatService;

        private List<PointLatLng> _points;

        public HomeController(IPointService pointService, IGHeatService gheatService)
        {
            if (pointService == null)
                throw new ArgumentNullException("Point Service");

            _pointService = pointService;

            if (gheatService == null)
                throw new ArgumentNullException("GHeat Service");

            _gheatService = gheatService;

            _points = _pointService.LoadPoints();
        }

        public ActionResult Index()
        {
            return View();
        }

        public TileResult Tile(string zoom, string x, string y)
        {
            using (var tile = _gheatService.GetTile(_points, "classic", int.Parse(zoom), int.Parse(x), int.Parse(y)))
            {
                return new TileResult(tile);
            }
        }
    }
}
