using System.Collections.Generic;
using GW2Wrapper.Connector;
using GW2Wrapper.Mapper;
using GW2Wrapper.Models.Achievements;

namespace GW2Wrapper.Achievements
{
    public class Groups
    {
        private readonly IConnector _apiConnector;
        private readonly IMapper _apiMapper;
        private string _groupsAchievementsEndpoint = "v2/achievements/groups/";

        public Groups(IConnector apiConnector, IMapper apiMapper)
        {
            _apiConnector = apiConnector;
            _apiMapper = apiMapper;
        }

        public GroupModel Get(string guid)
        {
            var json = _apiConnector.ApiCall($"{_groupsAchievementsEndpoint}{guid}");
            return _apiMapper.MapTop<GroupModel>(json);
        }

        public List<GroupModel> Get(params string[] guids)
        {
            for (int i = 0; i < guids.Length; i++)
            {
                _groupsAchievementsEndpoint += guids[i];
                if (i + 1 != guids.Length)
                {
                    _groupsAchievementsEndpoint += ",";
                }
            }

            var json = _apiConnector.ApiCall(_groupsAchievementsEndpoint);
            return _apiMapper.MapTop<List<GroupModel>>(json);
        }
        
        
        
    }
}