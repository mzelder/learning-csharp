using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web.Http;
using ToDoApp.Models;

namespace ToDoApp.Controllers
{
    public class AssignmentController : ApiController
    {
        Assignment[] assignements = new Assignment[]
        {
            new Assignment { Id = 1, TaskName = "Cleaning room", IsCompleted = false, DueDate = DateTime.Now, Description = "You supposed to clean the room" },
            new Assignment { Id = 2, TaskName = "Clean floor", IsCompleted = false, DueDate = DateTime.Now, Description = "You supposed to clean the floor" }
        };

        public IEnumerable<Assignment> GetAllAssignments()
        {
            return assignements;
        }
        
        public IHttpActionResult GetAssignement(int id)
        {
            var assigment = assignements.FirstOrDefault(x => x.Id == id);
            if (assigment == null)
            {
                return NotFound();
            }
            return Ok(assigment);
        }
    }
}
