using iron_dome.Dto;

namespace iron_dome.Service
{
    public interface IAdminService
    {
        Task<int> GetMissileAmount();
        Task UpdateMissileAmount(int amount);
    }
}
