using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using netcore_school.Constants;
using netcore_school.Helpers;
using netcore_school.Models.Users;
using System.Net;

namespace netcore_school.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly Services.UserService _userService;

        public UserController(Services.UserService userService)
        {
            _userService = userService;
        }

        [HttpGet("find")]
        public async Task<IActionResult> FindUsers([FromBody] UserRequestModel request)
        {
            const string descriptionFunction = "Lista de los usuarios";

            if (!ModelState.IsValid)
            {
                var errores = ModelState.Values
                    .SelectMany(v => v.Errors)
                    .Select(e => e.ErrorMessage)
                    .ToList();

                return BadRequest(HttpResponseHelper.Error(
                    descriptionFunction,
                    HttpConstant.STATUS_HTTP_ERROR,
                    errores
                ));
            }

            var (exito, message, data) = await _userService.FindUserAsync();

            if (!exito)
                return BadRequest(HttpResponseHelper.Error(
                    message,
                    HttpConstant.STATUS_HTTP_ERROR,
                    data
                ));

            return Ok(HttpResponseHelper.Success(
                message,
                HttpConstant.STATUS_HTTP_SUCCESS,
                data
            ));
        }
    }
}
