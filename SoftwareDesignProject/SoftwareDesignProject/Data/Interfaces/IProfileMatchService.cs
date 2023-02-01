namespace SoftwareDesignProject.Data.Interfaces
{
    public interface IProfileMatchService
    {
        public int CalculateAverageGradePoints(float averageGrade);
        public int CalculateCityPoints(string city);
    }
}
