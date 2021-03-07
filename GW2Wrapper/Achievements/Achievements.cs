using System.Collections.Generic;
using GW2Wrapper.Connector;
using GW2Wrapper.Mapper;
using GW2Wrapper.Models.Achievements;

namespace GW2Wrapper.Achievements
{
    /// <summary>
    /// This class has methods to interact with the
    /// achievements endpoint and everything to do with it
    /// </summary>
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

        /// <summary>
        /// Gets the information of an achievement from the api
        /// </summary>
        /// <param name="id">
        /// The id of the achievement
        /// </param>
        /// <returns></returns>
        public AchievementModel GetAchievement(int id)
        {
            var json = _apiConnector.ApiCall($"{AchievementsEndpoint}/{id.ToString()}");
            return _apiMapper.MapTop<AchievementModel>(json);
        }
        
        /// <summary>
        /// Gets the name of an achievement
        /// </summary>
        /// <param name="id">
        /// The id of the achievement
        /// </param>
        /// <returns></returns>
        public string GetAchievementName(int id)
        {
            var output = GetAchievement(id);
            return output.Name;
        }
        
        /// <summary>
        /// Gets the description of the achievement
        /// </summary>
        /// <param name="id">
        /// The id of the achievement
        /// </param>
        /// <returns></returns>
        public string GetAchievementDescription(int id)
        {
            var output = GetAchievement(id);
            return output.Description;
        }
        
        /// <summary>
        /// Gets the achievement icon if it has one
        /// </summary>
        /// <param name="id">
        /// The achievement id
        /// </param>
        /// <returns>
        /// Returns null if there is no icon
        /// </returns>
        public string GetAchievementIcon(int id)
        {
            var output = GetAchievement(id);
            return output.Icon ?? null;
        }
        
        /// <summary>
        /// Gets the achievement requirement as listed in game
        /// </summary>
        /// <param name="id">
        /// The achievement id
        /// </param>
        /// <returns></returns>
        public string GetAchievementRequirement(int id)
        {
            var output = GetAchievement(id);
            return output.Requirement;
        }
        
        /// <summary>
        /// Gets the achievement description prior to
        /// unlocking it
        /// </summary>
        /// <param name="id">
        /// The achievement id
        /// </param>
        /// <returns></returns>
        public string GetAchievementLockedText(int id)
        {
            var output = GetAchievement(id);
            return output.LockedText;
        }
        
        /// <summary>
        /// Gets the achievement type
        /// </summary>
        /// <param name="id">
        /// The achievement id
        /// </param>
        /// <returns></returns>
        public string GetAchievementType(int id)
        {
            var output = GetAchievement(id);
            return output.Type;
        }
        
        /// <summary>
        /// Gets the achievement flags
        /// </summary>
        /// <param name="id">
        /// The achievement id
        /// </param>
        /// <returns></returns>
        public List<string> GetAchievementFlags(int id)
        {
            var output = GetAchievement(id);
            return output.Flags;
        }
        
        /// <summary>
        /// Gets the achievement tiers
        /// </summary>
        /// <param name="id">
        /// The achievement id
        /// </param>
        /// <returns></returns>
        public List<TierModel> GetAchievementTiers(int id)
        {
            var output = GetAchievement(id);
            return output.Tiers;
        }
        
        /// <summary>
        /// Gets the achievement id's required to progress the given achievement
        /// </summary>
        /// <param name="id">
        /// The achievement id
        /// </param>
        /// <returns>
        /// Returns null if there are no prerequesites
        /// </returns>
        public List<int> GetAchievementPrerequesitesIds(int id)
        {
            var output = GetAchievement(id);
            return output.Prerequesites ?? null;
        }
        
        /// <summary>
        /// Gets the achievement rewards
        /// If type = coins only count has a value
        /// If type = Item only id and count has a value
        /// If type = Mastery only id and region has a value
        /// If type =  title only id has a value
        /// </summary>
        /// <param name="id">
        /// The achievement id
        /// </param>
        /// <returns></returns>
        public List<RewardModel> GetAchievementRewards(int id)
        {
            var output = GetAchievement(id);
            return output.Rewards;
        }
        
        /// <summary>
        /// Gets the achievement bits
        /// </summary>
        /// <param name="id">
        /// The achievement id
        /// </param>
        /// <returns></returns>
        public List<BitModel> GetAchievementBits(int id)
        {
            var output = GetAchievement(id);
            return output.Bits ?? null;
        }

        /// <summary>
        /// Gets the achievement AP cap for repeatable achievements
        /// </summary>
        /// <param name="id">
        /// The achievement id
        /// </param>
        /// <returns>
        /// Returns -1 if the achievement is not repeatable
        /// </returns>
        public int GetAchievementPointCap(int id)
        {
            var output = GetAchievement(id);
            return output.PointCap;
        }
        

        
    }
}