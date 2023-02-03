using System.ComponentModel.DataAnnotations.Schema;

namespace SoftwareDesignProject.Data.Models
{
    public class Aplikimi
    {
        public int Id { get; set; }
        public bool isSpecialCategory { get; set; }
        public string? SpecialCategoryReason { get; set; }
        public DateTime ApplyDate { get; set; }

        [ForeignKey("Studenti")]
        public int StudentiNrLeternjoftimit { get; set; }
        public Student Studenti { get; set; }

        [ForeignKey("FileDetails")]
        public int FileId { get; set; }
        public FileDetails FileDetails { get; set; }



        //public DateTime OpenedDate { get; set; }
        //public DateTime ClosedDate { get; set; }
        //public string ApplicationStatus { get; set; }
        //public FileUpload fileUpload { get; set; }

    }
}
