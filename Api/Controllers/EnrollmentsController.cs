using Api.Models;
using Data.Providers;
using Microsoft.AspNetCore.Mvc;
using Data.Entities;
using Data.Exceptions;
using System.Linq;

namespace Api.Controllers
{
	/// <summary>
	///		An API controller used to manage student enrollments. 
	/// </summary>
	public class EnrollmentsController
		: Controller
	{
	    private readonly IEnrollmentProvider _enrollmentProvider;

	    public EnrollmentsController(IEnrollmentProvider enrollmentProvider)
	    {
	        _enrollmentProvider = enrollmentProvider;
	    }

        [HttpPost]
	    [Route("api/enrollment/enroll")]
        public IActionResult EnrollStudent([FromBody] EnrollmentModel enrollment)
	    {
	        try
	        {
	            var x = _enrollmentProvider.Enroll(new Student {Id = enrollment.StudentId }, new Course {Id = enrollment.CourseId }, new Professor {Id = enrollment.ProfessorId });
	            enrollment.Id = x.Id;
	        }
	        catch (ValidationException ve)
	        {
	            return BadRequest(ve.Message);
	        }

	        return Ok(enrollment);
	    }

	}
}
