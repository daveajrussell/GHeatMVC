using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GHeatMVCDomainModel.Interfaces.Services
{
    public interface ISettingsService
    {
        string BaseDirectory { get; }
    }
}
