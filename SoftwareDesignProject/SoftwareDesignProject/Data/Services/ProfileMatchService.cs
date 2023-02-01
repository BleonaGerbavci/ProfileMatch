using SoftwareDesignProject.Data.Interfaces;

namespace SoftwareDesignProject.Data.Services
{
    public class ProfileMatchService : IProfileMatchService
    {
        private readonly AppDbContext _context;

        public ProfileMatchService(AppDbContext context)
        {
            _context = context;
        }

        public int CalculateAverageGradePoints(float averageGrade)
        {
           int averageGradePoints = 0;

            if (averageGrade >= 6.00 && averageGrade <= 6.99)
            {
                averageGradePoints = 1;
            }
            else if (averageGrade >= 7.00 && averageGrade <= 7.99)
            {
                averageGradePoints = 2;
            }
            else if (averageGrade >= 8.00 && averageGrade <= 8.99)
            {
                averageGradePoints = 3;
            }
            else if (averageGrade >= 9.00 && averageGrade <= 10.00)
            {
                averageGradePoints = 4;
            }
            else
            {
                averageGradePoints = 0;
            }

            return averageGradePoints;
        }

        public int CalculateCityPoints(string city)
        {
            int cityPoints = 0;

            if (!string.IsNullOrEmpty(city))
            {
                switch (city)
                {
                    case "Gjilan":
                    case "Viti":
                        cityPoints = 4;
                        break;
                    case "Gjakove":
                    case "Decan":
                        cityPoints = 9;
                        break;
                    case "Peje":
                    case "Istog":
                        cityPoints = 8;
                        break;
                    case "Kamenice":
                    case "Prizren":
                        cityPoints = 7;
                        break;
                    case "Kline":
                    case "Suhareke":
                        cityPoints = 6;
                        break;
                    case "Rahovec":
                    case "Skenderaj":
                        cityPoints = 5;
                        break;
                    case "Podujeve":
                    case "Ferizaj":
                    case "Mitrovice":
                        cityPoints = 3;
                        break;
                    case "Lipjan":
                    case "Vushtrri":
                        cityPoints = 2;
                        break;
                    default:
                        cityPoints = 0;
                        break;
                }
            }

            return cityPoints;
        }
    }
}
