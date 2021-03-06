﻿using System.Collections.Generic;
using GW2Wrapper.Connector;
using GW2Wrapper.Mapper;
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
        /// Gets the daily pve, pvp, wvw, fractals, and special events achievements
        /// </summary>
        /// <returns></returns>
        public DailyAchievementsModel Get()
        {
            var json = _apiConnector.ApiCall(DailyAchievementsEndpoint);
            return _apiMapper.MapTop<DailyAchievementsModel>(json);
        }
        
        /// <summary>
        /// Get the fractal dailies
        /// </summary>
        /// <returns></returns>
        public List<FractalDailyModel> GetFractalDailies()
        {
            var output = Get();
            return output.Fractals;
        }
        
        /// <summary>
        /// Gets the pve dailies
        /// </summary>
        /// <returns></returns>
        public List<PveDailyModel> GetPveDailies()
        {
            var output = Get();
            return output.Pve;
        }
        
        /// <summary>
        /// Gets the wvw dailies
        /// </summary>
        /// <returns></returns>
        public List<WvwDailyModel> GetWvwDailies()
        {
            var output = Get();
            return output.Wvw;
        }

        /// <summary>
        /// Gets the pvp dailies
        /// </summary>
        /// <returns></returns>
        public List<PvpDailyModel> GetPvpDailies()
        {
            var output = Get();
            return output.Pvp;
        }
        
        /// <summary>
        /// Gets the special events dailies
        /// </summary>
        /// <returns></returns>
        public List<SpecialDailyModel> GetSpecialDailies()
        {
            var output = Get();
            return output.Special;
        }
    }
}