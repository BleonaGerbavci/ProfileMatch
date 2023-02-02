﻿namespace SoftwareDesignProject.Data.Models
{
    public class ProfileMatch
    {
        public int Id { get; set; }
        public int PointsForGPA { get; set; }
        public int PointsForCity { get; set; }
        public int ExtraPoints { get; set; }
        public int TotalPoints { get; set; }

        public int AplikimiId { get; set; }
        public Aplikimi Aplikimi { get; set; }
    }
}
