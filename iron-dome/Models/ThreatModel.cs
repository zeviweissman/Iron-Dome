namespace iron_dome.Models
{
    public enum ThreatType
    {
        Missile = 800,
        Drone = 300,
        Ballistic = 18000
    }

    public enum ThreatSource
    {
        Iran = 1600,
        Hamas = 70,
        Hezbollah = 100,
        Yemen = 2337
    }

    public enum ThreatTarget
    {
        North,
        South, 
        Center
    }
    public class ThreatModel
    {
        public long Id { get; set; }
        public ThreatSource ThreatSource { get; set; }
        public ThreatType ThreatType { get; set; }      
        public ThreatTarget ThreatTarget { get; set; }
        public  int ThreatCount { get; set; }
        public bool IsIntercepted { get; set; }
    }
}
