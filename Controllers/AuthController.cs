using Microsoft.AspNetCore.Mvc;
using UserManagementSystem.Database;
using UserManagementSystem.Dto;
using UserManagementSystem.Dto.AuthDtos;

namespace UserManagementSystem.Controllers {

    /// <summary>
    /// Authentication controller
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController(UserDbContext userDbContext) : ControllerBase {

        /// <summary>
        /// Sign Up the user
        /// </summary>
        /// <param name="signUpRequestDto"></param>
        /// <returns>
        /// Status of the signup.(<see cref="string"/>)
        /// </returns>
        /// <remarks>
        /// Sample request:
        ///
        ///     POST /api/Auth/SignUp
        ///     {
        ///         "username": "jdoe",
        ///         "password": "my-Passw0rd",
        ///         "firstName": "John",
        ///         "middleName": "Rock",
        ///         "lastName": "Doe",
        ///         "isMale": true,
        ///         "addressLine1": "St. 123",
        ///         "addressLine2": "NYC",
        ///         "addressLine3": "USA"
        ///     }
        ///
        /// </remarks>
        /// <response code="201">If the user was successfully created.</response>
        [HttpPost("SignUp")]
        [Produces("application/json")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status409Conflict)]
        async public Task<ActionResult<GenericResponseDto<object>>> SignUp(SignUpRequestDto signUpRequestDto) {
            return Created("", new GenericResponseDto<object>() {
                StatusCode = System.Net.HttpStatusCode.Created,
                Title = "Sign up wass successful."
            });
        }
    }
}
