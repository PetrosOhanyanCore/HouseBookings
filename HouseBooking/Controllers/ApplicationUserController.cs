using AutoMapper;
using BusinessLayer.IService;
using Microsoft.AspNetCore.Mvc;
using Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HouseBooking.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationUserController : ControllerBase
    {
        private readonly IApplicationUserService _userService;
        public ApplicationUserController(IApplicationUserService userService, IMapper mapper)
        {
            _userService = userService;
        }
        // GET: api/<ApplicationUserController>
        [HttpGet("GetAllApplicationUsersInFirstNameAsync/{firstName}")]
        public async Task<IActionResult> GetAllApplicationUsersInFirstNameAsync(string firstName)
        {
            var users = await _userService.GetAllApplicationUsersInFirstNameAsync(firstName);
            if (users == null)
            {
                NotFound("Users are not founded");
            }
            return Ok(users);
        }

        // GET api/<ApplicationUserController>/5
        [HttpGet("GetAllApplicationUsersInLastNameAsync/{lastName}")]
        public async Task<IActionResult> GetAllApplicationUsersInLastNameAsync(string lastName)
        {
            var users = await _userService.GetAllApplicationUsersInLastNameAsync(lastName);
            if (users == null)
            {
                NotFound("Users are not founded");
            }
            return Ok(users);
        }
        [HttpGet("GetAllActiveUsersAsync")]
        public async Task<IActionResult> GetAllActiveUsersAsync()
        {
            var users = await _userService.GetAllActiveUsersAsync();
            if (users == null)
            {
                NotFound("Users are not founded");
            }
            return Ok(users);
        }
        [HttpGet("CountAllActiveUsersAsync")]
        public async Task<IActionResult> CountAllActiveUsersAsync()
        {
            var usersCount = await _userService.CountAllActiveUsersAsync();
            return Ok(usersCount);
        }
        [HttpGet("GetAllApplicationUsersInCreatedTimeAsync")]
        public async Task<IActionResult> GetAllApplicationUsersInCreatedTimeAsync(DateTime createdTime)
        {
            var users = await _userService.GetAllApplicationUsersInCreatedTimeAsync(createdTime);
            if (users == null)
            {
                NotFound("Users are not founded");
            }
            return Ok(users);
        }
        [HttpGet("GetAllApplicationUSersInDeactivatedAsync")]
        public async Task<IActionResult> GetAllApplicationUSersInDeactivatedAsync(DateTime deactivatedTime)
        {
            var users = await _userService.GetAllApplicationUSersInDeactivatedAsync(deactivatedTime);
            if (users == null)
            {
                NotFound("Users are not founded");
            }
            return Ok(users);
        }
        [HttpGet("GetApplicationUserInClientIdAsync/{id}")]
        public async Task<IActionResult> GetApplicationUserInClientIdAsync(int id)
        {
            var user = await _userService.GetApplicationUserInClientIdAsync(id);
            if (user == null)
            {
                NotFound("User is not founded");
            }
            return Ok(user);
        }
        [HttpGet("GetApplicationUserInPhoneNumberAsync/{phoneNumber}")]
        public async Task<IActionResult> GetApplicationUserInPhoneNumberAsync(string phoneNumber)
        {
            var user = await _userService.GetApplicationUserInPhoneNumberAsync(phoneNumber);
            if (user == null)
            {
                NotFound("User is not founded");
            }
            return Ok(user);
        }
        [HttpGet("GetAllApplicationUSersByAccesTokenAsync/{accesToken}")]
        public async Task<IActionResult> GetAllApplicationUSersByAccesTokenAsync(string accesToken)
        {
            var users = await _userService.GetAllApplicationUSersByAccesTokenAsync(accesToken);
            if (users == null)
            {
                NotFound("User are not founded");
            }
            return Ok(users);
        }
        [HttpGet("GetAllApplicationUsersByBirthDateAsync/{birthDate}")]
        public async Task<IActionResult> GetAllApplicationUsersByBirthDateAsync(DateTime birthDate)
        {
            var users = await _userService.GetAllApplicationUsersByBirthDateAsync(birthDate);
            if (users == null)
            {
                NotFound("User are not founded");
            }
            return Ok(users);
        }
        // POST api/<ApplicationUserController>
        [HttpPost]
        public void CreateApplicationUser([FromBody] ApplicationUserDTO applicationUserDTO)
        {
                _userService.CreateApplicationUserAsync(applicationUserDTO);
                Ok("User was succesfully created");
        }

        // PUT api/<ApplicationUserController>/5
        [HttpPut]
        public void UpdateApplicationUser([FromBody] ApplicationUserDTO applicationUserDTO)
        {
            if (applicationUserDTO == null)
            {
                NotFound("User does not exist");
            }
            _userService.UpdateApplicationUserAsync(applicationUserDTO);
            Ok("User was succesfully updated");
        }

        // DELETE api/<ApplicationUserController>/5
        [HttpDelete]
        public void DeleteApplicationUser([FromBody] ApplicationUserDTO applicationUserDTO)
        {
            if (applicationUserDTO == null)
            {
                NotFound("User does not exist");
            }
            _userService.DeleteApplicationUserAsync(applicationUserDTO);
            Ok("User was succesfully deleted");

        }
    }
}
