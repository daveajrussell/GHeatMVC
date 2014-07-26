using GHeatMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GHeatMVC.Controllers
{
    public class SiteSelectionController : Controller
    {
        private List<SiteSelectionViewModel> items = new List<SiteSelectionViewModel>()
        {
            new SiteSelectionViewModel()
            {
                Display = "Projects",
                URL = "http://www.daveajrussell.com/Projects"
            },
            new SiteSelectionViewModel()
            {
                Display = "Contact",
                URL = "http://www.daveajrussell.com/Contact"
            },
            new SiteSelectionViewModel()
            {
                Display = "Blog",
                URL = "http://daveajrussell.wordpress.com/"
            },
            new SiteSelectionViewModel()
            {
                Display = "Acknowledgements",
                URL = "http://www.daveajrussell.com/Acknowledgements"
            }
        };

        public ActionResult Index()
        {
            return PartialView("SiteSelectionPartial", items);
        }
    }
}
