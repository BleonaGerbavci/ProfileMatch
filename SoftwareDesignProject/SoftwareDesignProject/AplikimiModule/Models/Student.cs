﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SoftwareDesignProject.AplikimiModule.Models
{
    public class Student
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public int NrLeternjoftimit { get; set; }
        public string Emri { get; set; }
        public string EmriIPrindit { get; set; }
        public string Mbiemri { get; set; }
        public string Qyteti { get; set; }
        public double NotaMesatare { get; set; }
        public int NumriKontaktues { get; set; }
        public string Email { get; set; }
        public char Gjinia { get; set; }
        public int VitiIStudimeve { get; set; }
        public string Statusi { get; set; }
        public string ProfilePicUrl { get; set; }

        //Fakulteti 

        public int FakultetiId { get; set; }
        public Fakulteti Fakulteti { get; set; }

    }
}
