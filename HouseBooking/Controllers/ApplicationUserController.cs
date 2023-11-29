using AutoMapper;
using BusinessLayer.IService;
using Microsoft.AspNetCore.Mvc;
using Model.DTO;

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
            try
            {
                var users = await _userService.GetAllApplicationUsersInFirstNameAsync(firstName);
                return Ok(users);
            }
            catch (Exception ex)
            {
                return NotFound("Users are not founded");
            }
        }

        // GET api/<ApplicationUserController>/5
        [HttpGet("GetAllApplicationUsersInLastNameAsync/{lastName}")]
        public async Task<IActionResult> GetAllApplicationUsersInLastNameAsync(string lastName)
        {
            try
            {
                var users = await _userService.GetAllApplicationUsersInLastNameAsync(lastName);
                return Ok(users);
            }
            catch (Exception)
            {
                return NotFound("Users are not founded");
            }
        }
        [HttpGet("GetAllActiveUsersAsync")]
        public async Task<IActionResult> GetAllActiveUsersAsync()
        {           
            try
            {
                var users = await _userService.GetAllActiveUsersAsync();
                return Ok(users);
            }
            catch (Exception)
            {
                return NotFound("Users are not founded");
            }
        }
        [HttpGet("CountAllActiveUsersAsync")]
        public async Task<IActionResult> CountAllActiveUsersAsync()
        {
            try
            {
                var usersCount = await _userService.CountAllActiveUsersAsync();
                return Ok(usersCount);
            }
            catch (Exception)
            {
                return NotFound("Users are not founded");
            }
        }
        [HttpGet("GetAllApplicationUsersInCreatedTimeAsync")]
        public async Task<IActionResult> GetAllApplicationUsersInCreatedTimeAsync(DateTime createdTime)
        {
            try
            {
                var users = await _userService.GetAllApplicationUsersInCreatedTimeAsync(createdTime);
                return Ok(users);
            }
            catch (Exception)
            {
                return NotFound("Users are not founded");
            }
        }
        [HttpGet("GetAllApplicationUSersInDeactivatedAsync")]
        public async Task<IActionResult> GetAllApplicationUSersInDeactivatedAsync(DateTime deactivatedTime)
        {
            try
            {
                var users = await _userService.GetAllApplicationUSersInDeactivatedAsync(deactivatedTime);
                return Ok(users);
            }
            catch (Exception)
            {
                return NotFound("Users are not founded");
            }
        }
        [HttpGet("GetApplicationUserInClientIdAsync/{id}")]
        public async Task<IActionResult> GetApplicationUserInClientIdAsync(int id)
        {
            try
            {
                var user = await _userService.GetApplicationUserInClientIdAsync(id);
                return Ok(user);
            }
            catch (Exception)
            {
                return NotFound("User is not founded");
            }
        }
        [HttpGet("GetApplicationUserInPhoneNumberAsync/{phoneNumber}")]
        public async Task<IActionResult> GetApplicationUserInPhoneNumberAsync(string phoneNumber)
        {
            try
            {
                var user = await _userService.GetApplicationUserInPhoneNumberAsync(phoneNumber);
                return Ok(user);
            }
            catch (Exception)
            {
                return NotFound("User is not founded");
            }
        }
        [HttpGet("GetAllApplicationUSersByAccesTokenAsync/{accesToken}")]
        public async Task<IActionResult> GetAllApplicationUSersByAccesTokenAsync(string accesToken)
        {
            try
            {
                var users = await _userService.GetAllApplicationUSersByAccesTokenAsync(accesToken);
                return Ok(users);
            }
            catch (Exception)
            {
                return NotFound("Users are not founded");
            }
        }
        [HttpGet("GetAllApplicationUsersByBirthDateAsync/{birthDate}")]
        public async Task<IActionResult> GetAllApplicationUsersByBirthDateAsync(DateTime birthDate)
        {
            try
            {
                var users = await _userService.GetAllApplicationUsersByBirthDateAsync(birthDate);
                return Ok(users);
            }
            catch (Exception)
            {
                return NotFound("User are not founded");
            }
        }
        // POST api/<ApplicationUserController>
        [HttpPost]
        public void CreateApplicationUser([FromBody] ApplicationUserDTO applicationUserDTO)
        {
            try
            {
                _userService.CreateApplicationUserAsync(applicationUserDTO);
                Ok("User was succesfully created");
            }
            catch (Exception)
            {
                BadRequest();
            }
        }

        // PUT api/<ApplicationUserController>/5
        [HttpPut]
        public void UpdateApplicationUser([FromBody] ApplicationUserDTO applicationUserDTO)
        {
            try
            {
                _userService.UpdateApplicationUserAsync(applicationUserDTO);
                Ok("User was succesfully updated");
            }
            catch (Exception)
            {
                NotFound("User does not exist");
            }
        }

        // DELETE api/<ApplicationUserController>/5
        [HttpDelete]
        public void DeleteApplicationUser([FromBody] ApplicationUserDTO applicationUserDTO)
        {
            try
            {
                _userService.DeleteApplicationUserAsync(applicationUserDTO);
                Ok("User was succesfully deleted");
            }
            catch (Exception)
            {
                NotFound("User does not exist");
            }
        }
    }
}
