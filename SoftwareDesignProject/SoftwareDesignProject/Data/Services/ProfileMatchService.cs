using Microsoft.EntityFrameworkCore;
using SoftwareDesignProject.Data.Interfaces;
using SoftwareDesignProject.Data.Models;
using SoftwareDesignProject.Data.ViewModels;

namespace SoftwareDesignProject.Data.Services
{
    public class ProfileMatchService : IProfileMatchService
    {
        private readonly AppDbContext _context;

        public ProfileMatchService(AppDbContext context)
        {
            _context = context;
        }

        public int CalculateAverageGradePoints(double averageGrade)
        {
            int averageGradePoints;
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
                averageGradePoints = 1;
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

        public int CalculateExtraPoints(string category)
        {
            int extraPoints = 0;
            if (!string.IsNullOrEmpty(category))
            {
                switch (category)
                {
                    case "Student(femije) i deshmorit":
                        extraPoints = 10;
                        break;
                    case "Student me aftesi te kufizuara":
                        extraPoints = 6;
                        break;
                    case "Student(femije) i prindit invalid te luftes":
                    case "Student i te pagjeturit":
                    case "Student invalid civil i luftes":
                        extraPoints = 5;
                        break;
                    case "Student me asistence sociale":
                    case "Student i prindit martir nga lufta":
                    case "Student i te burgosurit politik":
                        extraPoints = 4;
                        break;
                    case "Dy e me shume student nga nje familje aplikant ne QS":
                    case "Student, prindi i te cilit eshte veteran i luftes":
                        extraPoints = 3;
                        break;
                    default:
                        extraPoints = 0;
                        break;

                }
            }
            return extraPoints;
        }

        public List<ProfileMatch> CalculateTotalPointsForAllStudents()
        {
            var aplikimet = _context.Aplikimet
                                 .Include(s => s.Studenti)
                                 .ToList();

            foreach (var aplikimi in aplikimet)
            {
                var profileMatch = _context.ProfileMatch
                    .FirstOrDefault(p => p.AplikimiId == aplikimi.Id);

                if (profileMatch == null)
                {
                    profileMatch = new ProfileMatch()
                    {
                        AplikimiId = aplikimi.Id,
                        PointsForGPA = CalculateAverageGradePoints(aplikimi.Studenti.NotaMesatare),
                        PointsForCity = CalculateCityPoints(aplikimi.Studenti.Qyteti),
                        ExtraPoints = CalculateExtraPoints(aplikimi.SpecialCategoryReason)
                  
                    };

                    profileMatch.TotalPoints = profileMatch.PointsForCity + profileMatch.PointsForGPA + profileMatch.ExtraPoints;
                    

                    _context.ProfileMatch.Add(profileMatch);
                }

                _context.SaveChanges();
            }
            return _context.ProfileMatch.ToList();
        }

        public List<ProfileMatch> SortByTotalPoints()
        {
            return _context.ProfileMatch
                .OrderByDescending(p => p.TotalPoints)
                .ToList();
        }

        public List<ProfileMatch> GetTop10ProfileMatches()
        {
            return SortByTotalPoints().Take(10).ToList();
        }

    }
}
