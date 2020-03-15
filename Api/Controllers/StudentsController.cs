using System;
using System.Collections.Generic;
using System.Linq;
using Data.Providers;
using Microsoft.AspNetCore.Mvc;
using Data.Entities;
using Data.Exceptions;
using Api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Api.Controllers
{
    /// <summary>
    ///		An API controller used to manage student enrollments. 
    /// </summary>
    public class StudentsController
        : Controller
    {
        private readonly IStudentProvider _studentProvider;

        public StudentsController(IStudentProvider studentProvider)
        {
            _studentProvider = studentProvider;
        }

        [HttpGet]
        [Route("/api/students/{studentId}/courses")]
        public IEnumerable<StudentCourseModel> GetStudentCourses(int studentId)
        {
            var enrolledCourses = _studentProvider.GetEnrollments(studentId)
                .Select(x => new StudentCourseModel {Id = x.Id, CourseName = x.Course.Name, ProfessorName = x.Professor.Name});

            return enrolledCourses;
        }
    }
}