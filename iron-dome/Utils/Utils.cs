using iron_dome.Dto;
using iron_dome.Models;

namespace iron_dome.Utils
{
    public class Utils
    {
        
        
        private static Func<int, int, double> CalculateTravelTime = (speed, distance)
            => speed / distance;

        public static Func<ThreatManagmentModel, double> GetResponseTime = (threat)
            => CalculateTravelTime((int)threat.ThreatType, (int)threat.ThreatSource);

        public static Func<List<ThreatManagmentModel>, long> GenreateId =
            (list) => list.Any() ? list.Max(threat => threat.Id) + 1 : 1;
    }
}
