using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab2_DoGiaLam.Models
{
    public class Course
    {
        internal DateTime DateTime;

        public int Id { get; set; }
        public ApplicationUser Lecturer { get; set; }
        [Required]
        public string LecturerId { get; set; }
        [Required]
        [StringLength(255)]
        public string Place { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time{ get; set; }
        public Category Categories { get; set; }
        [Required]
        public byte CategoryId { get; set; }
    }
}