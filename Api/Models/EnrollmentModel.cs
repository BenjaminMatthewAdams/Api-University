using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Api.Models
{
    public class EnrollmentModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("studentId")]
        public int StudentId { get; set; }
        [JsonProperty("courseId")]
        public int CourseId { get; set; }
        [JsonProperty("professorId")]
        public int ProfessorId { get; set; }
    }
}
