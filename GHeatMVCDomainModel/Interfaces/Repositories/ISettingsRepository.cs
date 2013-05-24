using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GHeatMVCDomainModel.Interfaces.Repositories
{
    public interface ISettingsRepository
    {
        string BaseDirectory { get; }
    }
}
