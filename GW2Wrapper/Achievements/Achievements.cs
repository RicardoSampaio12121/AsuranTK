using System;
using System.Collections.Generic;
using GW2Wrapper.Connector;
using GW2Wrapper.Mapper;
using GW2Wrapper.Models.Achievements;

namespace GW2Wrapper.Achievements
{
    public class Achievements
    {
        private readonly IConnector _apiConnector;
        private readonly IMapper _apiMapper;
        private const string AchievementsEndpoint = "v2/achievements";

        public Achievements(IConnector apiConnector, IMapper apiMapper)
        {
            _apiConnector = apiConnector;
            _apiMapper = apiMapper;
        }

        public AchievementModel GetAchievementById(int id)
        {
            var json = _apiConnector.ApiCall($"{AchievementsEndpoint}/{id.ToString()}");
            return _apiMapper.MapTop<AchievementModel>(json);
        }
        
        public string GetAchievementNameById(int id)
        {
            var output = GetAchievementById(id);
            return output.Name;
        }

        public string GetAchievementDescriptionById(int id)
        {
            var output = GetAchievementById(id);
            return output.Description;
        }
    }
}