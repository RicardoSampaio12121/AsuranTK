using System;
using GW2Wrapper.Connector;
using GW2Wrapper.Mapper;
using GW2Wrapper.Models.Achievements;
using GW2Wrapper.Models.Achievements.Dailies;

namespace GW2Wrapper.Achievements
{
    public class Daily
    {
        private readonly IConnector _apiConnector;
        private readonly IMapper _apiMapper;
        private const string DailyAchievementsEndpoint = "v2/achievements/daily";

        public Daily(IConnector apiConnector, IMapper apiMapper)
        {
            _apiConnector = apiConnector;
            _apiMapper = apiMapper;
        }
        
        /// <summary>
        /// Returns the daily achievements 
        /// </summary>
        /// <returns></returns>
        public DailyAchievementsModel Get()
        {
            var json = _apiConnector.ApiCall(DailyAchievementsEndpoint);
            return _apiMapper.MapTop<DailyAchievementsModel>(json);
        }
    }
}