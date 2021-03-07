using System.Collections.Generic;
using GW2Wrapper.Connector;
using GW2Wrapper.Mapper;
using GW2Wrapper.Models.Achievements.Dailies;

namespace GW2Wrapper.Achievements
{
    public class DailyTomorrow
    {
        private readonly IConnector _apiConnector;
        private readonly IMapper _apiMapper;
        private const string DailyTomorrowAchievementsEndpoint = "v2/achievements/daily/tomorrow";

        public DailyTomorrow(IConnector apiConnector, IMapper apiMapper)
        {
            _apiConnector = apiConnector;
            _apiMapper = apiMapper;
        }

        public DailyAchievementsModel Get()
        {
            var json = _apiConnector.ApiCall(DailyTomorrowAchievementsEndpoint);
            return _apiMapper.MapTop<DailyAchievementsModel>(json);
        }
        
        /// <summary>
        /// Get the fractal dailies for tomorrow
        /// </summary>
        /// <returns></returns>
        public List<FractalDailyModel> GetFractalDailies()
        {
            var output = Get();
            return output.Fractals;
        }
        
        /// <summary>
        /// Gets the pve dailies for tomorrow
        /// </summary>
        /// <returns></returns>
        public List<PveDailyModel> GetPveDailies()
        {
            var output = Get();
            return output.Pve;
        }
        
        /// <summary>
        /// Gets the wvw dailies for tomorrow
        /// </summary>
        /// <returns></returns>
        public List<WvwDailyModel> GetWvwDailies()
        {
            var output = Get();
            return output.Wvw;
        }

        /// <summary>
        /// Gets the pvp dailies for tomorrow
        /// </summary>
        /// <returns></returns>
        public List<PvpDailyModel> GetPvpDailies()
        {
            var output = Get();
            return output.Pvp;
        }
        
        /// <summary>
        /// Gets the special events dailies for tomorrow
        /// </summary>
        /// <returns></returns>
        public List<SpecialDailyModel> GetSpecialDailies()
        {
            var output = Get();
            return output.Special;
        }
    }
}