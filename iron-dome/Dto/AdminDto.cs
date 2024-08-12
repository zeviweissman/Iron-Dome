using iron_dome.Models;
using System.ComponentModel.DataAnnotations;

namespace iron_dome.Dto
{
    public class AdminDto
    {
       
        public int MissileAmount { get; set; } 
        public Queue<ThreatModel> ActiveThreats1 { get; set; } = [];
        public List<ThreatManagmentModel> ActiveThreats { get; set; } = [];
    }
}
