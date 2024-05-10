using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text;
using UserManagementSystem.Database;

namespace UserManagementSystem.Controllers {

    /// <summary>
    /// Various APIs for diagnosing various compoonents
    /// </summary>
    [AllowAnonymous]
    [Route("")]
    [ApiController]
    public class HealthCheckController(UserDbContext userDbContext) : ControllerBase {

        /// <summary>
        /// Check if API is active
        /// </summary>
        /// <returns>OK</returns>
        /// <remarks>
        /// No Sample request
        /// </remarks>
        /// <response code="200">Should always return OK</response>
        [HttpGet]
        [Produces("text/plain")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<string> Index() {
            return "User Management System is Active";
        }

        /// <summary>
        /// Checks the connectivity of all databases
        /// </summary>
        /// <returns>
        /// Status of all databases
        /// </returns>
        /// <remarks>
        /// No Remarks
        /// </remarks>
        /// <response code="200">Returns OK if all DB Connections are established</response>
        /// <response code="503">Return Service Unavailable if at least one DB connection is inactive</response>
        [HttpGet("checkdb")]
        [Produces("text/plain")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status503ServiceUnavailable)]
        public ActionResult<string> DbCheck() {
            StringBuilder sb = new();
            
            if (userDbContext.Database.CanConnect()) {
                sb.AppendLine("UserDb is connected.");
            }

            return sb.ToString();
        }
    }
}
