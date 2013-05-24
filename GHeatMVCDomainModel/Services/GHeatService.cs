using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using GMap.NET;
using GHeatMVCDomainModel.Interfaces.Services;
using GHeatMVCDomainModel.Interfaces.Repositories;

namespace GHeatMVCDomainModel.Services
{
    public class GHeatService : IGHeatService
    {
        private IGHeatRepository _gheatRepository;

        public GHeatService(IGHeatRepository gheatRepository)
        {
            if (gheatRepository == null)
                throw new ArgumentNullException("GHeat Repository");

            _gheatRepository = gheatRepository;
        }

        public Bitmap GetTile(List<PointLatLng> _points, string colourScheme, int zoom, int x, int y)
        {
            if (_points == null || _points.Count <= 0)
                throw new ArgumentNullException("Points");
            if(string.IsNullOrEmpty(colourScheme))
                throw new ArgumentNullException("Colour Scheme");

            return _gheatRepository.GetTile(_points, colourScheme, zoom, x, y);
        }

        public Bitmap GetDot(int zoom)
        {
            if (zoom < 0)
                throw new ArgumentOutOfRangeException("Zoom");

            return _gheatRepository.GetDot(zoom);
        }

        public Bitmap GetColourScheme(string schemeName)
        {
            if (string.IsNullOrEmpty(schemeName))
                throw new ArgumentNullException("Scheme Name");

            return _gheatRepository.GetColourScheme(schemeName);
        }

        public string[] AvailableColourSchemes()
        {
            return _gheatRepository.AvailableColourSchemes();
        }
    }
}