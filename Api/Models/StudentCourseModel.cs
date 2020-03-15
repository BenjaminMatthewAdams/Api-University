using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data.Common;
using Newtonsoft.Json;

namespace Api.Models
{
    public class StudentCourseModel
    {
        public int Id { get; set; }
        public string CourseName { get; set; }
        public string ProfessorName { get; set; }
    }
}
