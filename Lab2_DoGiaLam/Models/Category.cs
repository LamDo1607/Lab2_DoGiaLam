using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using System.Web;

namespace Lab2_DoGiaLam.Models
{
    public class Category
    {
        public byte Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
    }
}