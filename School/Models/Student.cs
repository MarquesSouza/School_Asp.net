using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace School.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        public string Cpf { get; set; }
        public int Rg { get; set; }

        public int Telephone { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public int Number { get; set; }

        public City City { get; set; }

        public int IdCity { get; set; }
    }
}