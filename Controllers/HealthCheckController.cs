using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UserManagementSystem.Controllers {

    /// <summary>
    /// Various APIs for diagnosing various compoonents
    /// </summary>
    [AllowAnonymous]
    [Route("")]
    [ApiController]
    public class HealthCheckController : ControllerBase {

        /// <summary>
        /// Check if API is active
        /// </summary>
        /// <returns></returns>
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
    }
}
