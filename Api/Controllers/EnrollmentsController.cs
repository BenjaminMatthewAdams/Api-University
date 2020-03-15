using Data.Providers;
using Microsoft.AspNetCore.Mvc;
using Data.Entities;
using Data.Exceptions;

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
        public IActionResult EnrollStudent(int studentId, int courseId, int professorId)
	    {
	        try
	        {
	            _enrollmentProvider.Enroll(new Student {Id = studentId}, new Course {Id = courseId}, new Professor {Id = professorId});
	        }
	        catch (ValidationException ve)
	        {
	            return BadRequest(ve.Message);
	        }

	        return Ok();
	    }

	}
}
