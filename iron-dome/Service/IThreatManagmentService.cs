using iron_dome.Dto;

namespace iron_dome.Service
{
    public interface IThreatManagmentService
    {
        void AddThreat(ThreatManagmentModel model);
        void DeleteThreat(long id);
        void LaunchThreat(long id);
    }
}
