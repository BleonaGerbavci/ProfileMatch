namespace SoftwareDesignProject.Data.Models
{
    public class Aplikimi
    {
        public int Id { get; set; }
        public int NrPersonal { get; set; }
        public string Fakulteti { get; set; }
        public bool canApply { get; set; }
        public DateTime ApplicationDate { get; set; }
        public DateTime OpenDate { get; set; }
        public DateTime CloseDate { get; set; }
        public string ApplicationStatus { get; set; }
        public bool isSpecialCategory { get; set; }
        public string SpecialCategoryReason   { get; set; }
      
        //public FileUpload fileUpload { get; set; }

        public Student Studenti { get; set; }

    }
}
