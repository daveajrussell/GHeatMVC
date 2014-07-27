using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GHeatMVC.Models
{
    public class SiteSelectionViewModel
    {
        public string URL { get; set; }
        public string Display { get; set; }
        public bool IsExternal { get; set; }
    }
}