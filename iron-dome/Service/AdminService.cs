using iron_dome.Data;
using iron_dome.Dto;
using iron_dome.Models;
using Microsoft.EntityFrameworkCore;

namespace iron_dome.Service
{
    public class AdminService(ApplicationDbContext dbContext) : IAdminService
    {
        static Exception NotEnoughMissliesToRemoveException = new("Can't remove Misslies beecause you are trying to remove more missiles than total missile amount");
        static Func<int, int, bool> NotEnoughMissilesToRemove = 
            (amount, amountToDelete) => amount + amountToDelete < 0;
        
        static Func<int, AdminModel> IntToAdminModel =
            (num) => new AdminModel () { MissileAmount = num };
        public async Task<int> GetMissileAmount() => await dbContext.Admin.SumAsync(admin => admin.MissileAmount);


        public async Task UpdateMissileAmount(int amount)
        {
            if (NotEnoughMissilesToRemove(await GetMissileAmount(), amount))
            {
                throw NotEnoughMissliesToRemoveException;
            }
            await dbContext.Admin.AddAsync(IntToAdminModel(amount)); 
            await dbContext.SaveChangesAsync();
        }
    } 
}
