using System.Collections.Generic;
using System.Linq;
using KiberlabLMS.Data.Common.Repositories;
using KiberlabLMS.Data.Models;
using KiberlabLMS.Services.Mapping;

namespace KiberlabLMS.Services.Data
{
    public class SettingsService : ISettingsService
    {
        private readonly IDeletableEntityRepository<Setting> settingsRepository;

        public SettingsService(IDeletableEntityRepository<Setting> settingsRepository)
        {
            this.settingsRepository = settingsRepository;
        }

        public int GetCount()
        {
            return this.settingsRepository.AllAsNoTracking().Count();
        }

        public IEnumerable<T> GetAll<T>()
        {
            return this.settingsRepository.All().To<T>().ToList();
        }
    }
}
