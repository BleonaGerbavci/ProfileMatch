using Microsoft.AspNetCore.Mvc;
using SoftwareDesignProject.Data.Models;

namespace SoftwareDesignProject.Data.Interfaces
{
    public interface IProfileMatchService
    {
        public int CalculateAverageGradePoints(double averageGrade);
        public int CalculateCityPoints(string city);
        public int CalculateExtraPoints(string category);
        public List<ProfileMatch> CalculateTotalPointsForAllStudents();
        public List<ProfileMatch> SortByTotalPoints();
        public List<ProfileMatch> GetTop10ProfileMatches();
        public List<ProfileMatch> GetLast10ProfileMatches();
    }
}