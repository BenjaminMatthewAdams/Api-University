# Api-University

Api University is a small .NET Core API that allows students to enroll in courses. 

Dependencies 
------------------------------------------------------------------------------------
.NET Core SDK 2.2 - https://dotnet.microsoft.com/download/dotnet-core/2.2
------------------------------------------------------------------------------------

There are a few things that need to be completed in order for us to make the application 
ready for its first release. 

1.  Create a new branch from development. Please include your name as part of the branch name. Once complete you should 
    create a pull request into the development branch.

2.  There is a bug in the startup.cs file that is preventing the Console.WriteLine from printing out the 
    professor's name. Make the necessary changes to correct this bug so that the professor name is written to 
    the console. 

3.  Need an endpoint that allows a student to enroll in a course. The url should be /api/enrollment/enroll. 
    - A student should only be able to enroll in a maximum of 2 courses. 
    - A student cannot enroll in a course that the specified professor does not teach.

    Following the existing validation patterns established in the application, return a 400 Bad Request to the 
    consumer when one of the validation rules above fails. 

4.  Need an endpoint that returns all the courses a student is enrolled in. The url should be /api/students/{studentId}/courses.


Documentation
------------------------------------------------------------------------------------
Dependency Injection - https://structuremap.github.io/documentation/
Entity Framework Core - https://docs.microsoft.com/en-us/ef/core/
ASP.NET Core - https://docs.microsoft.com/en-us/aspnet/core/?view=aspnetcore-2.2
------------------------------------------------------------------------------------

API Test Applications 
------------------------------------------------------------------------------------
Fiddler - https://www.telerik.com/fiddler
Postman - https://www.getpostman.com/
------------------------------------------------------------------------------------
