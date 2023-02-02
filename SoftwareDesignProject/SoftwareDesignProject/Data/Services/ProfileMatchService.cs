using Microsoft.Data.SqlClient;
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

        public int CalculateExtraPoints(string category)
        {
            int extraPoints = 0;
            if (!string.IsNullOrEmpty(category))
            {
                switch (category)
                {
                    case "Student (femije) i deshmorit":
                        extraPoints = 10;
                        break;
                    case "Student me aftesi te kufizuara":
                        extraPoints = 6;
                        break;
                    case "Student (femije) i prindit invalid te luftes":
                    case "Student (femije) i te pagjeturit":
                    case "Student invalid civil i luftes":
                        extraPoints = 5;
                        break;
                    case "Student me asistence sociale":
                    case "Student i prindit martir nga lufta":
                    case "Student i te burgosurit":
                        extraPoints = 4;
                        break;
                    case "Dy e me shume student nga nje familje aplikant ne QS":
                    case "Student (femije) i prindit veterean te luftes":
                        extraPoints = 3;
                        break;
                    default:
                        extraPoints = 0;
                        break;

                }
            }
            return extraPoints;
        }

        /*public List<ProfileMatch> GetAllMatches() =>
               _context.ProfileMatch.Include(a => a.Aplikimi).
                                    Include(a => a.Aplikimi.Studenti).
                                    Include(a => a.Aplikimi.Studenti.Fakulteti).ToList();*/

/*
        public void AutoPopulateProfileMatch()
        {
            var aplikime = _context.Aplikimet.ToList();

            foreach (var aplikimi in aplikime)
            {
                var profileMatch = new ProfileMatch
                {
                    PointsForGPA = CalculateAverageGradePoints(aplikimi.Studenti.NotaMesatare),
                    PointsForCity = CalculateCityPoints(aplikimi.Studenti.Qyteti),
                    ExtraPoints = CalculateExtraPoints(aplikimi.SpecialCategoryReason),
                    TotalPoints = CalculateAverageGradePoints(aplikimi.Studenti.NotaMesatare) + CalculateCityPoints(aplikimi.Studenti.Qyteti)
                        + CalculateExtraPoints(aplikimi.SpecialCategoryReason),
                    AplikimiId = aplikimi.Id
                };

                _context.ProfileMatch.Add(profileMatch);
            }

            _context.SaveChanges();
        }
*/
        

        /*  public void AddProfileMatch(ProfileMatch profileMatch)
          {
              var _profileMatch = new ProfileMatch
              {
                  PointsForGPA = CalculateAverageGradePoints(profileMatch.Aplikimi.Studenti.NotaMesatare),
                  PointsForCity = CalculateCityPoints(profileMatch.Aplikimi.Studenti.Qyteti),
                  ExtraPoints = CalculateExtraPoints(profileMatch.Aplikimi.SpecialCategoryReason),
                  TotalPoints = CalculateAverageGradePoints(profileMatch.Aplikimi.Studenti.NotaMesatare) + CalculateCityPoints(profileMatch.Aplikimi.Studenti.Qyteti)
                  + CalculateExtraPoints(profileMatch.Aplikimi.SpecialCategoryReason),
                  AplikimiId = profileMatch.AplikimiId
              };

              _context.ProfileMatch.Add(profileMatch);
              _context.SaveChanges();
          }

          */
        
           public List<ProfileMatch> CalculateTotalPointsForAllStudents()
           {
               var aplikimet = _context.Aplikimet
                                .Include(s => s.Studenti)
                                 .ToList();
               foreach (var aplikimi in aplikimet)
               {

                
                var profileMatch = new ProfileMatch()
                {
                    AplikimiId = aplikimi.Id,
                    PointsForGPA = CalculateAverageGradePoints(aplikimi.Studenti.NotaMesatare),
                    PointsForCity = CalculateCityPoints(aplikimi.Studenti.Qyteti),
                    ExtraPoints = CalculateExtraPoints(aplikimi.SpecialCategoryReason),
                    TotalPoints = CalculateAverageGradePoints(aplikimi.Studenti.NotaMesatare) +
                                              CalculateCityPoints(aplikimi.Studenti.Qyteti) +
                                              CalculateExtraPoints(aplikimi.SpecialCategoryReason)

            };
                 

                _context.ProfileMatch.Add(profileMatch);
                   _context.SaveChanges();
               }
               return _context.ProfileMatch.ToList();
           }

           /* public List<ProfileMatch> CalculateTotalPoints()
            {
            var aplikimet = _context.Aplikimet.ToList();

            foreach (var aplikimi in aplikimet)
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

                builder.DataSource = "DESKTOP-0JO8GCJ";
                builder.InitialCatalog = "profile.m.db";

                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    connection.Open();

                    String id = "Select id, from Aplikimi";

                }
            }
            }
           */

       
        }
    }
