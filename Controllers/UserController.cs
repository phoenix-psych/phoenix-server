using AIMSService.Entity;
using AIMSService.Model;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Web.Entity;
using Web.Entity.Context;
using Web.Helper;
using Web.Helper.Enum;
using Web.Model;

namespace Web.Controllers
{
    [Route("api")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly AppDbContext _dbContext;
        private readonly IMapper _mapper;
        public UserController(AppDbContext appDbContext, IMapper mapper)
        {
            _dbContext = appDbContext;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("user")]
        public async Task<ActionResult<List<UserDto>>> GetUser()
        {
            var results = await _dbContext.Users.ToListAsync();
            return Ok(_mapper.Map<List<UserDto>>(results));
        }

        [HttpGet]
        [Route("user/{userId}")]
        public async Task<ActionResult<UserDto>> GetUserById(Guid userId)
        {
            var result = await _dbContext.Users.FirstOrDefaultAsync(x => x.Id == userId);
            if (result == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<UserDto>(result));
        }

        [HttpPost]
        [Route("user")]
        public async Task<ActionResult> AddUser([FromBody] UserDto userDto)
        {
            if (userDto == null)
            {
                return BadRequest();
            }

            userDto.UserType = GetUserType(userDto.Type);
            var user = _mapper.Map<User>(userDto);
            await _dbContext.Users.AddAsync(user);
            await _dbContext.SaveChangesAsync();

            var client = new Client()
            {
                Name = $"{user.FirstName} {user.LastName}",
                Dob = user.Dob,
                Email = user.Email,
                Phone = "NIL",
                Service = 1,
                Address = "NIL",
                University = "NIL",
                Course = "NIL",
                CourseYear = "NIL",
                UserName = user.Username,
                Passwod = user.Password,
                UserId = user.Id,

                Status = ClientStatusEnum.Created
            };

            await _dbContext.Clients.AddAsync(client);

            var result = await _dbContext.SaveChangesAsync();
            if (result > 0)
            {
                var mailtask = SendLoginNotification($"{user.FirstName} {user.LastName}");
                return Ok(new
                {
                    Data = _mapper.Map<UserDto>(user)
                });
            }

            return Ok(new
            {
                Message = "Create failed!"
            });
        }

        private async Task SendLoginNotification(string loggedInUser)
        {
            string recipients = "noyal@phoenix-psych.com";
            string subject = $"Register : {loggedInUser}";
            string message = $"{loggedInUser} - Register Successfully @{DateTime.Now.ToLocalTime()}";
            var email = new EmailManager();
            if (false)
            {
                email.SendGmailMail(recipients, subject, message);
            }
        }

        private UserTypeEnum GetUserType(string type)
        {
            switch (type)
            {
                case "School Student":
                    {
                        return UserTypeEnum.School_Student;
                    }
                case "Graduate Student":
                    {
                        return UserTypeEnum.Graduate_Student;
                    }
                case "Post Graduate":
                    {
                        return UserTypeEnum.Post_Graduate;
                    }
                case "Private Individual":
                    {
                        return UserTypeEnum.Private_Individual;
                    }
                case "University":
                    {
                        return UserTypeEnum.University;
                    }
                case "Organizatiion / Workplace":
                    {
                        return UserTypeEnum.Organizatiion;
                    }
                case "Assessor":
                    {
                        return UserTypeEnum.Assessor;
                    }
                case "Psychologist":
                    {
                        return UserTypeEnum.Psychologist;
                    }
                case "Tutor":
                    {
                        return UserTypeEnum.Tutor;
                    }
                case "Counsellor":
                    {
                        return UserTypeEnum.Counsellor;
                    }
                default:
                    {
                        return 0;
                    }
            }
        }

        [HttpPut]
        [Route("user")]
        public async Task<ActionResult> ModifyUser([FromBody] UserDto userDto)
        {
            if (userDto == null)
            {
                return BadRequest();
            }

            var user = _mapper.Map<User>(userDto);
            _dbContext.Users.Update(user);
            var result = await _dbContext.SaveChangesAsync();
            if (result > 0)
            {
                return Ok(new
                {
                    Data = _mapper.Map<UserDto>(user)
                });
            }

            return Ok(new
            {
                Message = "Update failed!"
            });
        }


        [HttpDelete]
        [Route("user")]
        public async Task<ActionResult> DeleteUser(Guid userId)
        {
            var deletedUser = _dbContext.Users.FirstOrDefault(x => x.Id == userId);
            if (deletedUser == null)
            {
                return Ok(new
                {
                    Message = "User not exist!"
                });
            }
            _dbContext.Users.Remove(deletedUser);
            var result = await _dbContext.SaveChangesAsync();
            if (result > 0)
            {
                return Ok(new
                {
                    Message = "Delete success!"
                });
            }

            return Ok(new
            {
                Message = "Delete failed!"
            });
        }

    }
}
