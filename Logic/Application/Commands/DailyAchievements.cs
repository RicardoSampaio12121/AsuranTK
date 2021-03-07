using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DBManager.UsersDatabase.Get;
using GW2Wrapper;
using GW2Wrapper.Achievements;
using GW2Wrapper.Models.Achievements;
using GW2Wrapper.Models.Achievements.Dailies;

namespace Logic.Application.Commands
{
    public static class DailyAchievements
    {
        private static Dictionary<string, IList<(string title, string description)>> _output;

        public static IDictionary<string, IList<(string, string)>> GetNameAndRequirements(string apiKey)
        {
            //Get the daily achievements
            var dailyManager = Factory.InitializeDaily(apiKey);
            var dailies = dailyManager.Get();

            //Get the name and description of the daily achievements
            var achievements = Factory.InitializeAchievements();
            _output = new Dictionary<string, IList<(string title, string description)>>();
            
            Parallel.Invoke
            (
                () => FillDailiesDictionary("pve", dailies.Pve, achievements),
                () => FillDailiesDictionary("wvw", dailies.Wvw, achievements),
                () => FillDailiesDictionary("pvp", dailies.Pve, achievements),
                () => FillDailiesDictionary("fractals", dailies.Pve, achievements)
            );

            //FillPve("special", dailies.pve, achievements);

            return _output;
        }

        private static void FillDailiesDictionary(string key, IEnumerable<IDailyModel> lst,
            Achievements achievementManager)
        {
            foreach (var daily in lst)
            {
                var achievement = achievementManager.GetAchievement(daily.Id);
                if (!_output.ContainsKey(key))
                {
                    _output.Add(key, new List<(string, string)> {(achievement.Name, achievement.Requirement)});
                }
                else
                {
                    _output[key].Add((achievement.Name, achievement.Description));
                }
            }
        }
    }


}