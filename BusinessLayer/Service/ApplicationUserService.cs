using AutoMapper;
using BusinessLayer.IService;
using DataLayer.IRepository;
using Entity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Model;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Service
{
    public class ApplicationUserService : IApplicationUserService
    {
        private readonly IApplicationUserRepository _applicationUserRepository;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;
        private readonly UserManager<ApplicationUser> _userManager;



        public ApplicationUserService(IApplicationUserRepository applicationUserRepository, UserManager<ApplicationUser> userManager, IMapper mapper, IConfiguration configuration)
        {
            _applicationUserRepository = applicationUserRepository;
            _configuration = configuration;
            _userManager = userManager;
            _mapper = mapper;
        }
        public void CreateApplicationUserAsync(ApplicationUserDTO applicationUserDTO)
        {
            var appUser = _mapper.Map<ApplicationUserDTO,ApplicationUser>(applicationUserDTO);
             _applicationUserRepository.Add(appUser);
        }
        public void UpdateApplicationUserAsync(ApplicationUserDTO applicationUserDTO)
        {
            var appUser = _mapper.Map<ApplicationUserDTO, ApplicationUser>(applicationUserDTO);
             _applicationUserRepository.Update(appUser);
        }

        public void DeleteApplicationUserAsync(ApplicationUserDTO applicationUserDTO)
        {
            var appUser = _mapper.Map<ApplicationUserDTO, ApplicationUser>(applicationUserDTO);
            if (appUser != null)
            {
                _applicationUserRepository.Remove(appUser);
            }
        }

        public async Task<IEnumerable<ApplicationUserDTO>> GetAllActiveUsersAsync()
        {
            var appActiveUsers = await _applicationUserRepository.GetAllApplicationUserInActiveAsync(true);
            return _mapper.Map<IEnumerable<ApplicationUser>, IEnumerable<ApplicationUserDTO>>(appActiveUsers);
        }

        public async Task<IEnumerable<ApplicationUserDTO>> GetAllApplicationUSersByAccesTokenAsync(string accesToken)
        {
            var appUsers = await _applicationUserRepository.GetAllApplicationUserInAccessTokenAsync(accesToken);
            return _mapper.Map<IEnumerable<ApplicationUser>, IEnumerable<ApplicationUserDTO>>(appUsers);
        }

        public async Task<IEnumerable<ApplicationUserDTO>> GetAllApplicationUsersByBirthDateAsync(DateTime birthDate)
        {
            var appUsers = await _applicationUserRepository.GetAllApplicationUserByBirthDateAsync(birthDate);
            return _mapper.Map<IEnumerable<ApplicationUser>, IEnumerable<ApplicationUserDTO>>(appUsers);
        }

        public async Task<IEnumerable<ApplicationUserDTO>> GetAllApplicationUsersInCreatedTimeAsync(DateTime createdTime)
        {
            var appUsers = await _applicationUserRepository.GetAllApplicationUserInCreatedDateAsync(createdTime);
            return _mapper.Map<IEnumerable<ApplicationUser>, IEnumerable<ApplicationUserDTO>>(appUsers);
        }

        public async Task<IEnumerable<ApplicationUserDTO>> GetAllApplicationUSersInDeactivatedAsync(DateTime deactivatedTime)
        {
            var appUsers = await _applicationUserRepository.GetAllApplicationUserInDeactivationDateAsync(deactivatedTime);
            return _mapper.Map<IEnumerable<ApplicationUser>, IEnumerable<ApplicationUserDTO>>(appUsers);
        }

        public async Task<IEnumerable<ApplicationUserDTO>> GetAllApplicationUsersInFirstNameAsync(string firstName)
        {
            var appUsers = await _applicationUserRepository.GetAllApplicationUserInNameAsync(firstName);
            return _mapper.Map<IEnumerable<ApplicationUser>, IEnumerable<ApplicationUserDTO>>(appUsers);
        }

        public async Task<IEnumerable<ApplicationUserDTO>> GetAllApplicationUsersInLastNameAsync(string lastName)
        {
            var appUsers = await _applicationUserRepository.GetAllApplicationUserInLastNameAsync(lastName);
            return _mapper.Map<IEnumerable<ApplicationUser>, IEnumerable<ApplicationUserDTO>>(appUsers);
        }

        public async Task<ApplicationUserDTO> GetApplicationUserInClientIdAsync(int clientId)
        {
            var appUsers = await _applicationUserRepository.GetApplicationUserInCleantIdAsync(clientId);
            return _mapper.Map<ApplicationUser, ApplicationUserDTO>(appUsers);
        }

        public async Task<ApplicationUserDTO> GetApplicationUserInPhoneNumberAsync(string phoneNumber)
        {
            var appUsers = await _applicationUserRepository.GetApplicationUsersInPhoneNumberAsync(phoneNumber);
            return _mapper.Map<ApplicationUser, ApplicationUserDTO>(appUsers);
        }
        public async Task<int> CountAllActiveUsersAsync()
        {
            return await _applicationUserRepository.CountApplicationUsersByIsActiveAsync(true);
        }

        private string generateJwtToken(ApplicationUser user)
        {
            // generate token that is valid for 7 days
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_configuration["Jwt:Key"]);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[] { new Claim("id", user.Id), new Claim("access", user.AccessToken), new Claim(ClaimTypes.Email, user.Email) }),
                Expires = DateTime.UtcNow.AddDays(1),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature),
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }

        public async Task<ApplicationUser> GetById(string id)
        {
            return _userManager.Users.Include(i => i.Client).FirstOrDefault(x => x.Id == id);
        }










        public async Task<UserManagerResponse> LoginUserAsync(LoginModel model)
        {
            var user = await _userManager.FindByEmailAsync(model.Email);

            if (user == null || !user.IsActive)
            {
                return new UserManagerResponse
                {
                    Message = "InvalidUser",
                    IsSuccess = false
                };
            }

            if (!user.EmailConfirmed)
            {
                return new UserManagerResponse
                {
                    Message = "ActivateEmail",
                    IsSuccess = false
                };
            }

            var result = await _userManager.CheckPasswordAsync(user, model.Password);

            if (!result)
            {
                return new UserManagerResponse
                {
                    Message = "PasswordInvalid",
                    IsSuccess = false
                };
            }

            #region NotNeed

            //var jwt = _jwtHandler.Create(user.UserName);
            //var refreshToken = _passwordHasher.HashPassword(user, Guid.NewGuid().ToString())
            //    .Replace("+", string.Empty)
            //    .Replace("=", string.Empty)
            //    .Replace("/", string.Empty);
            //jwt.RefreshToken = refreshToken;
            //_refreshTokens.Add(new RefreshToken { Username = username, Token = refreshToken });

            //var claims = new[]
            //{
            //    new Claim("Email", model.Email),
            //    new Claim(ClaimTypes.NameIdentifier, user.Id),
            //};

            //var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));

            //var token = new JwtSecurityToken(
            //    issuer: _configuration["Jwt:Issuer"],
            //    audience: _configuration["Jwt:Issuer"],
            //    claims: claims,
            //    expires: DateTime.Now.AddDays(30),
            //    signingCredentials: new SigningCredentials(key, SecurityAlgorithms.HmacSha256));

            //string tokenAsString = new JwtSecurityTokenHandler().WriteToken(token);

            #endregion

            string token = generateJwtToken(user);

            return new UserManagerResponse
            {
                Message = token,
                IsSuccess = true,
            };
        }

        public async Task<UserManagerResponse> RegisterUserAsync(RegisterModel model)
        {
            if (model == null)
                throw new NullReferenceException("NotFound");

            if (model.Password != model.ConfirmPassword)
                return new UserManagerResponse
                {
                    Message = "PasswordMissMatch",
                    IsSuccess = false
                };


            var user = new ApplicationUser
            {
                UserName = model.Email,
                Email = model.Email,
                FirstName = model.FirstName,
                LastName = model.LastName,
                IsActive = true,
                CreatedDate = DateTime.Now,
                AccessToken = Guid.NewGuid().ToString()
                                            .Replace("+", string.Empty)
                                            .Replace("=", string.Empty)
                                            .Replace("/", string.Empty)
            };

            var result = await _userManager.CreateAsync(user, model.Password);

            if (result.Succeeded)
            {
                var confirmEmailToken = await _userManager.GenerateEmailConfirmationTokenAsync(user);

                var encodedEmailToken = Encoding.UTF8.GetBytes(confirmEmailToken);
                var validEmailToken = WebEncoders.Base64UrlEncode(encodedEmailToken);

                return new UserManagerResponse
                {
                    Message = "User created successfully!",
                    IsSuccess = true,
                };
            }

            return new UserManagerResponse
            {
                Message = "SomethingWrong",
                IsSuccess = false,
                Errors = result.Errors.Select(e => e.Description)
            };
        }
    }
}
