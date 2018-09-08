using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Edu.Models
{
    public class Teacher
    {
        public int TeacherId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public int OIB { get; set; }
    }
}