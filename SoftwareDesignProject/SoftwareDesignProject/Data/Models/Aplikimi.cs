namespace SoftwareDesignProject.Data.Models
{
    public class Aplikimi
    {
        public int Id { get; set; }
        public bool isSpecialCategory { get; set; }
        public string? SpecialCategoryReason   { get; set; }
        public DateTime ApplyDate { get; set; }
        public int StudentiNrLeternjoftimit { get; set; }
        public Student Studenti { get; set; }
       

        //public DateTime OpenedDate { get; set; }
        //public DateTime ClosedDate { get; set; }
        //public string ApplicationStatus { get; set; }
        //public FileUpload fileUpload { get; set; }

    }
}
