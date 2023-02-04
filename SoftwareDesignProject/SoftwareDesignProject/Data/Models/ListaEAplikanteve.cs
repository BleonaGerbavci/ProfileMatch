using System.ComponentModel.DataAnnotations;

namespace SoftwareDesignProject.Data.Models
{
    public class ListaEAplikanteve
    {
        [Key]
        public int NumriRendor { get; set; }
        public int TotalApplicants { get; set; }


        public ICollection<ProfileMatch> ProfileMatches { get; set; }
    }
}
