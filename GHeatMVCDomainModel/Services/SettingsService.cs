using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GHeatMVCDomainModel.Services;
using GHeatMVCDomainModel.Interfaces.Repositories;
using GHeatMVCDomainModel.Interfaces.Services;

namespace GHeatMVCDomainModel.Services
{
    public class SettingsService : ISettingsService
    {
        private ISettingsRepository _settingsRepository;

        public SettingsService(ISettingsRepository settingsRepository)
        {
            if (settingsRepository == null)
                throw new ArgumentNullException("Repository");

            _settingsRepository = settingsRepository;
        }

        public string BaseDirectory
        {
            get
            {
                return _settingsRepository.BaseDirectory;
            }
        }
    }
}