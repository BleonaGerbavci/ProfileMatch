using SoftwareDesignProject.AplikimiModule.Models;

namespace SoftwareDesignProject.ProfileMatchModule.Models
{
    public class Ankesa
    {
        public int Id { get; set; }
        public string Permbajtja { get; set; }


        //navigation properties
        public int StudentiNrLeternjoftimit { get; set; } 
        public Student Studenti { get; set; }
    }
}
