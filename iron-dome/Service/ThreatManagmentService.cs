using iron_dome.Dto;
using static iron_dome.Utils.Utils;

namespace iron_dome.Service
{
    public class ThreatManagmentService(AdminDto adminDto) : IThreatManagmentService
    {
        List<ThreatManagmentModel> activeThreats = adminDto.ActiveThreats;
        public void AddThreat(ThreatManagmentModel model)
        {
            model.Id = GenreateId(activeThreats);
            adminDto.ActiveThreats.Add(model);
        }

        public void DeleteThreat(long id)
        {
            var index = activeThreats.FindIndex(threat => threat.Id == id);
            activeThreats.RemoveAt(index);
        }

        public void LaunchThreat(long id)
        {
            var index = activeThreats.FindIndex(threat => threat.Id == id);
            activeThreats[index].IsActive = true;
        }

    }
}
