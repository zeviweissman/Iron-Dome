using iron_dome.Models;
using System.ComponentModel.DataAnnotations;

namespace iron_dome.Dto
{
    public class ThreatManagmentModel
    {

        public long Id { get; set; }
        public ThreatSource ThreatSource { get; set; }
        public ThreatType ThreatType { get; set; }
        public ThreatTarget ThreatTarget { get; set; }
        [Range(0, 999)]
        public int ThreatCount { get; set; }
        public bool IsActive { get; set; }

    }
}
